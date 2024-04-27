using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Graphics.Holographic;

namespace BusyDial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Hole10 hole;
        private void Form1_Load(object sender, EventArgs e)
        {
            hole = new Hole10();
            numDiskRadius.Value = (decimal)hole.DiskRadius;
            numHoleRadius.Value = (decimal)hole.HoleRadius;
            numHoleRed.Value = hole.HoleRed;
            numHoleGreen.Value = hole.HoleGreen;
            numHoleBlue.Value = hole.HoleBlue;
            numBGRed.Value = hole.BGRed;
            numBGGreen.Value = hole.BGGreen;
            numBGBlue.Value = hole.BGBlue;
            if (hole.BGTransparent)
            {
                comboTransparent.SelectedIndex = 0;
            }
            else
            {
                if (hole.HoleTransparent)
                {
                    comboTransparent.SelectedIndex = 1;
                }
                else
                {
                    comboTransparent.SelectedIndex = 2;
                }
            }
            textTelephoneNumber.Text = hole.TelephoneNumber;
            textFileName.Text = hole.FileName;
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            hole.DiskRadius = (double)numDiskRadius.Value;
            hole.HoleRadius = (double)numHoleRadius.Value;
            hole.HoleRed = (byte)numHoleRed.Value;
            hole.HoleGreen = (byte)numHoleGreen.Value;
            hole.HoleBlue = (byte)numHoleBlue.Value;
            hole.BGRed = (byte)numBGRed.Value;
            hole.BGGreen = (byte)numBGGreen.Value;
            hole.BGBlue = (byte)numBGBlue.Value;
            if (comboTransparent.SelectedIndex == 0)
            {
                hole.BGTransparent = true;
                hole.HoleTransparent = false;
            }
            else
            {
                hole.BGTransparent = false;
                if (comboTransparent.SelectedIndex == 1)
                {
                    hole.HoleTransparent = true;
                }
                else
                {
                    hole.HoleTransparent = false;
                }
            }
            hole.TelephoneNumber = textTelephoneNumber.Text;
            hole.FileName = textFileName.Text;
            hole.Generate();
        }

        private void buttonHoleColor_Click(object sender, EventArgs e)
        {

        }

        private void buttonBGColor_Click(object sender, EventArgs e)
        {

        }
    }
}
