
namespace BusyDial
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            numDiskRadius = new System.Windows.Forms.NumericUpDown();
            numHoleRadius = new System.Windows.Forms.NumericUpDown();
            colorDialog1 = new System.Windows.Forms.ColorDialog();
            label3 = new System.Windows.Forms.Label();
            numHoleRed = new System.Windows.Forms.NumericUpDown();
            numHoleGreen = new System.Windows.Forms.NumericUpDown();
            numHoleBlue = new System.Windows.Forms.NumericUpDown();
            label4 = new System.Windows.Forms.Label();
            textTelephoneNumber = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            textFileName = new System.Windows.Forms.TextBox();
            buttonOpenFileDialog = new System.Windows.Forms.Button();
            buttonGenerate = new System.Windows.Forms.Button();
            buttonHoleColor = new System.Windows.Forms.Button();
            label6 = new System.Windows.Forms.Label();
            numBGRed = new System.Windows.Forms.NumericUpDown();
            numBGGreen = new System.Windows.Forms.NumericUpDown();
            numBGBlue = new System.Windows.Forms.NumericUpDown();
            buttonBGColor = new System.Windows.Forms.Button();
            comboTransparent = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)numDiskRadius).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numHoleRadius).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numHoleRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numHoleGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numHoleBlue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numBGRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numBGGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numBGBlue).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 14);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(52, 15);
            label1.TabIndex = 0;
            label1.Text = "半径(px)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 43);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(78, 15);
            label2.TabIndex = 1;
            label2.Text = "穴のサイズ(px)";
            // 
            // numDiskRadius
            // 
            numDiskRadius.DecimalPlaces = 1;
            numDiskRadius.Location = new System.Drawing.Point(103, 12);
            numDiskRadius.Maximum = new decimal(new int[] { 512, 0, 0, 0 });
            numDiskRadius.Name = "numDiskRadius";
            numDiskRadius.Size = new System.Drawing.Size(69, 23);
            numDiskRadius.TabIndex = 2;
            // 
            // numHoleRadius
            // 
            numHoleRadius.DecimalPlaces = 1;
            numHoleRadius.Location = new System.Drawing.Point(103, 41);
            numHoleRadius.Maximum = new decimal(new int[] { 64, 0, 0, 0 });
            numHoleRadius.Name = "numHoleRadius";
            numHoleRadius.Size = new System.Drawing.Size(69, 23);
            numHoleRadius.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 72);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(41, 15);
            label3.TabIndex = 4;
            label3.Text = "穴の色";
            // 
            // numHoleRed
            // 
            numHoleRed.Location = new System.Drawing.Point(103, 70);
            numHoleRed.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numHoleRed.Name = "numHoleRed";
            numHoleRed.Size = new System.Drawing.Size(69, 23);
            numHoleRed.TabIndex = 5;
            // 
            // numHoleGreen
            // 
            numHoleGreen.Location = new System.Drawing.Point(178, 70);
            numHoleGreen.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numHoleGreen.Name = "numHoleGreen";
            numHoleGreen.Size = new System.Drawing.Size(69, 23);
            numHoleGreen.TabIndex = 5;
            // 
            // numHoleBlue
            // 
            numHoleBlue.Location = new System.Drawing.Point(253, 70);
            numHoleBlue.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numHoleBlue.Name = "numHoleBlue";
            numHoleBlue.Size = new System.Drawing.Size(69, 23);
            numHoleBlue.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(12, 160);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(50, 15);
            label4.TabIndex = 6;
            label4.Text = "Number";
            // 
            // textTelephoneNumber
            // 
            textTelephoneNumber.Location = new System.Drawing.Point(103, 157);
            textTelephoneNumber.Name = "textTelephoneNumber";
            textTelephoneNumber.Size = new System.Drawing.Size(219, 23);
            textTelephoneNumber.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(12, 189);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(53, 15);
            label5.TabIndex = 8;
            label5.Text = "ファイル名";
            // 
            // textFileName
            // 
            textFileName.Location = new System.Drawing.Point(103, 186);
            textFileName.Name = "textFileName";
            textFileName.Size = new System.Drawing.Size(219, 23);
            textFileName.TabIndex = 9;
            // 
            // buttonOpenFileDialog
            // 
            buttonOpenFileDialog.Location = new System.Drawing.Point(328, 184);
            buttonOpenFileDialog.Name = "buttonOpenFileDialog";
            buttonOpenFileDialog.Size = new System.Drawing.Size(75, 24);
            buttonOpenFileDialog.TabIndex = 10;
            buttonOpenFileDialog.Text = "参照";
            buttonOpenFileDialog.UseVisualStyleBackColor = true;
            // 
            // buttonGenerate
            // 
            buttonGenerate.Location = new System.Drawing.Point(103, 215);
            buttonGenerate.Name = "buttonGenerate";
            buttonGenerate.Size = new System.Drawing.Size(219, 23);
            buttonGenerate.TabIndex = 11;
            buttonGenerate.Text = "ジェネレート";
            buttonGenerate.UseVisualStyleBackColor = true;
            buttonGenerate.Click += buttonGenerate_Click;
            // 
            // buttonHoleColor
            // 
            buttonHoleColor.Location = new System.Drawing.Point(328, 68);
            buttonHoleColor.Name = "buttonHoleColor";
            buttonHoleColor.Size = new System.Drawing.Size(75, 23);
            buttonHoleColor.TabIndex = 12;
            buttonHoleColor.Text = "選択";
            buttonHoleColor.UseVisualStyleBackColor = true;
            buttonHoleColor.Click += buttonHoleColor_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(12, 101);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(43, 15);
            label6.TabIndex = 4;
            label6.Text = "背景色";
            // 
            // numBGRed
            // 
            numBGRed.Location = new System.Drawing.Point(103, 99);
            numBGRed.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numBGRed.Name = "numBGRed";
            numBGRed.Size = new System.Drawing.Size(69, 23);
            numBGRed.TabIndex = 5;
            // 
            // numBGGreen
            // 
            numBGGreen.Location = new System.Drawing.Point(178, 99);
            numBGGreen.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numBGGreen.Name = "numBGGreen";
            numBGGreen.Size = new System.Drawing.Size(69, 23);
            numBGGreen.TabIndex = 5;
            // 
            // numBGBlue
            // 
            numBGBlue.Location = new System.Drawing.Point(253, 99);
            numBGBlue.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numBGBlue.Name = "numBGBlue";
            numBGBlue.Size = new System.Drawing.Size(69, 23);
            numBGBlue.TabIndex = 5;
            // 
            // buttonBGColor
            // 
            buttonBGColor.Location = new System.Drawing.Point(328, 97);
            buttonBGColor.Name = "buttonBGColor";
            buttonBGColor.Size = new System.Drawing.Size(75, 23);
            buttonBGColor.TabIndex = 12;
            buttonBGColor.Text = "選択";
            buttonBGColor.UseVisualStyleBackColor = true;
            buttonBGColor.Click += buttonBGColor_Click;
            // 
            // comboTransparent
            // 
            comboTransparent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboTransparent.FormattingEnabled = true;
            comboTransparent.Items.AddRange(new object[] { "背景を透明", "穴を透明", "透明なし" });
            comboTransparent.Location = new System.Drawing.Point(103, 128);
            comboTransparent.Name = "comboTransparent";
            comboTransparent.Size = new System.Drawing.Size(144, 23);
            comboTransparent.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(comboTransparent);
            Controls.Add(buttonBGColor);
            Controls.Add(buttonHoleColor);
            Controls.Add(buttonGenerate);
            Controls.Add(buttonOpenFileDialog);
            Controls.Add(textFileName);
            Controls.Add(label5);
            Controls.Add(textTelephoneNumber);
            Controls.Add(label4);
            Controls.Add(numBGBlue);
            Controls.Add(numBGGreen);
            Controls.Add(numHoleBlue);
            Controls.Add(numBGRed);
            Controls.Add(numHoleGreen);
            Controls.Add(label6);
            Controls.Add(numHoleRed);
            Controls.Add(label3);
            Controls.Add(numHoleRadius);
            Controls.Add(numDiskRadius);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numDiskRadius).EndInit();
            ((System.ComponentModel.ISupportInitialize)numHoleRadius).EndInit();
            ((System.ComponentModel.ISupportInitialize)numHoleRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)numHoleGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)numHoleBlue).EndInit();
            ((System.ComponentModel.ISupportInitialize)numBGRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)numBGGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)numBGBlue).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numDiskRadius;
        private System.Windows.Forms.NumericUpDown numHoleRadius;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numHoleRed;
        private System.Windows.Forms.NumericUpDown numHoleGreen;
        private System.Windows.Forms.NumericUpDown numHoleBlue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textTelephoneNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textFileName;
        private System.Windows.Forms.Button buttonOpenFileDialog;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Button buttonHoleColor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numBGRed;
        private System.Windows.Forms.NumericUpDown numBGGreen;
        private System.Windows.Forms.NumericUpDown numBGBlue;
        private System.Windows.Forms.Button buttonBGColor;
        private System.Windows.Forms.ComboBox comboTransparent;
    }
}

