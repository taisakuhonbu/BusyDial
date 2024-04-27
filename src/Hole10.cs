using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Devices.Bluetooth.Advertisement;

namespace BusyDial
{
    public class Hole10
    {
        public double DiskRadius
        {
            get;
            set;
        }
        public double HoleRadius
        {
            get;
            set;
        }
        public byte HoleRed
        {
            get;
            set;
        }
        public byte HoleGreen
        {
            get;
            set;
        }
        public byte HoleBlue
        {
            get;
            set;
        }
        public byte BGRed
        {
            get;
            set;
        }
        public byte BGGreen
        {
            get;
            set;
        }
        public byte BGBlue
        {
            get;
            set;
        }
        public bool BGTransparent
        {
            get;
            set;
        }
        public bool HoleTransparent
        {
            get;
            set;
        }

        public String TelephoneNumber
        {
            get;
            set;
        }
        public String FileName
        {
            get;
            set;
        }

        public Hole10()
        {
            DiskRadius = 31;
            HoleRadius = 5;
            HoleRed = 43;
            HoleGreen = 54;
            HoleBlue = 234;
            BGRed = 255;
            BGGreen = 255;
            BGBlue = 255;
            BGTransparent = true;
            HoleTransparent = false;
            TelephoneNumber = "177";
            FileName = "177.gif";
        }

        public int GetImageSize()
        {
            return ((int)(DiskRadius + HoleRadius + 0.5)) * 2;
        }
        private int GetOffset()
        {
            return (int)(DiskRadius + HoleRadius + 0.5);
        }

        // 穴の間隔（14.5 は1周の 1/14.5 という意味）
        private double dHoleStep = 14.5;
        // 0 をダイヤルするとき何個分回るか（13 は 13/14.5 周するという意味）
        private int nEndToEnd = 13;
        // 穴の間隔分移動するときのコマ割り数右回り
        private int nDivRight = 3;
        // 穴の間隔分移動するときのコマ割り数左回り
        private int nDivLeft = 5;
        // 一コマの表示時間（ミリ秒（1/100 での設定なので、10 で割って使う））
        private int nDelay = 30;

        // 画像データ右回り用
        private MemoryStream[] right;
        // 画像データ左回り用
        private MemoryStream[] left;


        private MemoryStream frame(int i, int div)
        {
            int sz = GetImageSize();
            double rsq = HoleRadius * HoleRadius;
            System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(sz, sz);
            byte[] pixels = new byte[sz * sz * 4];

            double theta = i * Math.PI * 2 / dHoleStep / div;
            System.Drawing.Imaging.BitmapData data = bitmap.LockBits(
                new System.Drawing.Rectangle(0, 0, sz, sz),
                System.Drawing.Imaging.ImageLockMode.WriteOnly,
                System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            int x, y;
            // 各ピクセルについて
            // 10 個の穴の中心からの距離が HoleSize より小さいなら指定の色を塗る
            double[] cx = new double[10];
            double[] cy = new double[10];
            for (int hole = 0; hole < 10; hole++)
            {
                double phi = hole * Math.PI * 2 / dHoleStep + Math.PI / 2;
                phi += theta;
                cx[hole] = DiskRadius * Math.Cos(phi);
                cy[hole] = DiskRadius * Math.Sin(phi);
            }
            for (y = 0; y < sz; y++)
            {
                for (x = 0; x < sz; x++)
                {
                    double dx = x - GetOffset() + 0.5;
                    double dy = y - GetOffset() + 0.5;
                    int hole;
                    for (hole = 0; hole < 10; hole++)
                    {
                        if ((dx - cx[hole]) * (dx - cx[hole]) + (dy - cy[hole]) * (dy - cy[hole]) < rsq)
                        {
                            pixels[y * sz * 4 + x * 4 + 0] = 0;
                            pixels[y * sz * 4 + x * 4 + 1] = 0;
                            pixels[y * sz * 4 + x * 4 + 2] = 0;
                            pixels[y * sz * 4 + x * 4 + 3] = 255;
                            break;
                        }
                    }
                    if (hole == 10)
                    {
                        pixels[y * sz * 4 + x * 4 + 0] = 255;
                        pixels[y * sz * 4 + x * 4 + 1] = 255;
                        pixels[y * sz * 4 + x * 4 + 2] = 255;
                        pixels[y * sz * 4 + x * 4 + 3] = 0;
                    }
                }
            }
            IntPtr ptr = data.Scan0;
            System.Runtime.InteropServices.Marshal.Copy(pixels, 0, ptr, sz * sz * 4);
            bitmap.UnlockBits(data);
            MemoryStream ms = new MemoryStream();
            bitmap.Save(ms, ImageFormat.Gif);
            return ms;
        }

        private MemoryStream GetRightRotate(int i)
        {
            if (right[i] != null)
            {
                return right[i];
            }
            return right[i] = frame(i, nDivRight);
        }
        private MemoryStream GetLeftRotate(int i)
        {
            if (left[i] != null)
            {
                return left[i];
            }
            return left[i] = frame(i, nDivLeft);
        }

        public void Generate()
        {
            // 13/14.5 回転する
            // 行きは 1/14.5/3 回転ずつ
            right = new MemoryStream[nEndToEnd * nDivRight + 1];
            // 帰りは 1/14.5/5 回転ずつ
            left = new MemoryStream[nEndToEnd * nDivLeft + 1];


            char[] numerals = TelephoneNumber.ToCharArray();
            int n = numerals.Length;
            for (int i = 0; i < n; i++)
            {
                numerals[i] = (char)((numerals[i] + 1) % 10 + 4);
            }

            // スタート画像を作る
            MemoryStream ms;
            ms = frame(0 * nDivRight + 0, nDivRight);
            right[0 * nDivRight + 0] = ms;
            left[0 * nDivLeft + 0] = ms;

            // Animation output
            FileStream stream = new FileStream(FileName, FileMode.Create);
            BinaryWriter w = new BinaryWriter(stream);

            // Header
            // 全画像左上が同じで使う色が２色なので、グローバルカラーマップを使う
            byte[] h0 = new byte[0x30D];
            ms.Position = 0;
            ms.Read(h0, 0, 0x30D);
            h0[0xD] = HoleRed;
            h0[0xE] = HoleGreen;
            h0[0xF] = HoleBlue;
            h0[0x2fe] = BGRed;
            h0[0x2ff] = BGGreen;
            h0[0x300] = BGBlue;
            w.Write(h0);
            w.Write(_LoopHeader(10));

            _WriteData(ms, w);

            for (int i = 0; i < n; i++)
            {
                int j;
                for (j = 0; j < numerals[i]; j++)
                {
                    for(int k = 0; k < nDivRight; k++)
                    {
                        ms = GetRightRotate(j * nDivRight + k + 1);
                        _WriteData(ms, w);
                    }
                }
                j--;
                for(; j >= 0; j--)
                {
                    for(int k = nDivLeft - 1 ; k >= 0; k--)
                    {
                        ms = GetLeftRotate(j * nDivLeft + k);
                        _WriteData(ms, w);
                    }
                }
            }
            w.Write((byte)0x3B);
            w.Close();
        }

        private void _WriteData(MemoryStream ms, BinaryWriter w)
        {
            byte[] data = new byte[ms.Length - 0x30D - 1];
            ms.Position = 0x30D;
            ms.Read(data, 0, data.Length);
            data[3] = (byte)9;
            data[4] = (byte)((nDelay / 10) & 0xFF);
            data[5] = (byte)(((nDelay / 10 ) >> 8) & 0xFF);
            if (BGTransparent)
            {
                data[6] = (byte)0xFB;
            }
            else
            {
                if (HoleTransparent)
                {
                    data[6] = (byte)0;
                }
                else
                {
                    data[6] = (byte)1;
                }
            }
            w.Write(data);
        }
        // GIF アニメのループ回数用ヘッダ
        private static byte[] _LoopHeader(UInt16 nLoops)
        {
            byte[] bs = new byte[19];

            bs[0] = 0x21;
            bs[1] = 0xFF;
            bs[2] = 0x0B;   // アプリケーション識別子の長さ
            bs[3] = (byte)'N';
            bs[4] = (byte)'E';
            bs[5] = (byte)'T';
            bs[6] = (byte)'S';
            bs[7] = (byte)'C';
            bs[8] = (byte)'A';
            bs[9] = (byte)'P';
            bs[10] = (byte)'E';
            bs[11] = (byte)'2';
            bs[12] = (byte)'.';
            bs[13] = (byte)'0';
            bs[14] = 0x03;  // データの長さ
            bs[15] = 0x01;  // ループ回数という意味
            // 繰り返し回数（0 は無限）
            bs[16] = (byte)(nLoops & 0xFF);
            bs[17] = (byte)((nLoops >> 8) & 0xFF);
            bs[18] = 0x00;

            return bs;
        }
    }
}