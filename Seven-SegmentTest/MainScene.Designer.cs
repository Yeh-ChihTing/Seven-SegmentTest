
namespace Seven_SegmentTest
{
    partial class MainScene
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
            this.components = new System.ComponentModel.Container();
            this.SevenSegPic = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Add7seg = new System.Windows.Forms.Button();
            this.Set7ToBack = new System.Windows.Forms.Button();
            this.Set7SegCol = new System.Windows.Forms.Button();
            this.SegOnCol = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ClearAllSeg = new System.Windows.Forms.Button();
            this.Get7Seg = new System.Windows.Forms.Button();
            this.digitTex = new System.Windows.Forms.TextBox();
            this.digit = new System.Windows.Forms.Label();
            this.ColNear = new System.Windows.Forms.Label();
            this.ColNearTex = new System.Windows.Forms.TextBox();
            this.LoopOnOff = new System.Windows.Forms.Button();
            this.LoopCheck = new System.Windows.Forms.Timer(this.components);
            this.statusCheck = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SevenSegPic)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SevenSegPic
            // 
            this.SevenSegPic.ErrorImage = null;
            this.SevenSegPic.InitialImage = null;
            this.SevenSegPic.Location = new System.Drawing.Point(18, 20);
            this.SevenSegPic.Name = "SevenSegPic";
            this.SevenSegPic.Size = new System.Drawing.Size(640, 360);
            this.SevenSegPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SevenSegPic.TabIndex = 0;
            this.SevenSegPic.TabStop = false;
            this.SevenSegPic.WaitOnLoad = true;
            this.SevenSegPic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SevenSegPic_MouseDown);
            this.SevenSegPic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SevenSegPic_MouseMove);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.SevenSegPic);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 401);
            this.panel1.TabIndex = 1;
            // 
            // Add7seg
            // 
            this.Add7seg.Location = new System.Drawing.Point(725, 93);
            this.Add7seg.Name = "Add7seg";
            this.Add7seg.Size = new System.Drawing.Size(94, 23);
            this.Add7seg.TabIndex = 2;
            this.Add7seg.Text = "7セグ位置設定";
            this.Add7seg.UseVisualStyleBackColor = true;
            this.Add7seg.Click += new System.EventHandler(this.Add7seg_Click);
            // 
            // Set7ToBack
            // 
            this.Set7ToBack.Location = new System.Drawing.Point(30, 491);
            this.Set7ToBack.Name = "Set7ToBack";
            this.Set7ToBack.Size = new System.Drawing.Size(82, 23);
            this.Set7ToBack.TabIndex = 3;
            this.Set7ToBack.Text = "セット7セグ";
            this.Set7ToBack.UseVisualStyleBackColor = true;
            this.Set7ToBack.Click += new System.EventHandler(this.Set7ToBack_Click);
            // 
            // Set7SegCol
            // 
            this.Set7SegCol.Location = new System.Drawing.Point(725, 131);
            this.Set7SegCol.Name = "Set7SegCol";
            this.Set7SegCol.Size = new System.Drawing.Size(82, 23);
            this.Set7SegCol.TabIndex = 4;
            this.Set7SegCol.Text = "セット7セグ色";
            this.Set7SegCol.UseVisualStyleBackColor = true;
            this.Set7SegCol.Click += new System.EventHandler(this.Set7SegCol_Click);
            // 
            // SegOnCol
            // 
            this.SegOnCol.Location = new System.Drawing.Point(815, 135);
            this.SegOnCol.Name = "SegOnCol";
            this.SegOnCol.Size = new System.Drawing.Size(25, 19);
            this.SegOnCol.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(713, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // ClearAllSeg
            // 
            this.ClearAllSeg.Location = new System.Drawing.Point(725, 52);
            this.ClearAllSeg.Name = "ClearAllSeg";
            this.ClearAllSeg.Size = new System.Drawing.Size(82, 23);
            this.ClearAllSeg.TabIndex = 9;
            this.ClearAllSeg.Text = "7セグリーセット";
            this.ClearAllSeg.UseVisualStyleBackColor = true;
            this.ClearAllSeg.Click += new System.EventHandler(this.ClearAllSeg_Click);
            // 
            // Get7Seg
            // 
            this.Get7Seg.Location = new System.Drawing.Point(713, 198);
            this.Get7Seg.Name = "Get7Seg";
            this.Get7Seg.Size = new System.Drawing.Size(114, 23);
            this.Get7Seg.TabIndex = 10;
            this.Get7Seg.Text = "7セグの値をチェック";
            this.Get7Seg.UseVisualStyleBackColor = true;
            this.Get7Seg.Click += new System.EventHandler(this.Get7Seg_Click);
            // 
            // digitTex
            // 
            this.digitTex.Location = new System.Drawing.Point(750, 285);
            this.digitTex.Name = "digitTex";
            this.digitTex.Size = new System.Drawing.Size(78, 23);
            this.digitTex.TabIndex = 11;
            this.digitTex.Text = "1";
            // 
            // digit
            // 
            this.digit.AutoSize = true;
            this.digit.Location = new System.Drawing.Point(725, 288);
            this.digit.Name = "digit";
            this.digit.Size = new System.Drawing.Size(19, 15);
            this.digit.TabIndex = 12;
            this.digit.Text = "桁";
            // 
            // ColNear
            // 
            this.ColNear.AutoSize = true;
            this.ColNear.Location = new System.Drawing.Point(703, 318);
            this.ColNear.Name = "ColNear";
            this.ColNear.Size = new System.Drawing.Size(41, 15);
            this.ColNear.TabIndex = 14;
            this.ColNear.Text = "色合い";
            // 
            // ColNearTex
            // 
            this.ColNearTex.Location = new System.Drawing.Point(750, 315);
            this.ColNearTex.Name = "ColNearTex";
            this.ColNearTex.Size = new System.Drawing.Size(78, 23);
            this.ColNearTex.TabIndex = 13;
            this.ColNearTex.Text = "65";
            // 
            // LoopOnOff
            // 
            this.LoopOnOff.BackColor = System.Drawing.Color.Red;
            this.LoopOnOff.Location = new System.Drawing.Point(713, 243);
            this.LoopOnOff.Name = "LoopOnOff";
            this.LoopOnOff.Size = new System.Drawing.Size(75, 23);
            this.LoopOnOff.TabIndex = 15;
            this.LoopOnOff.Text = "ループ";
            this.LoopOnOff.UseVisualStyleBackColor = false;
            this.LoopOnOff.Click += new System.EventHandler(this.LoopOnOff_Click);
            // 
            // LoopCheck
            // 
            this.LoopCheck.Interval = 5000;
            this.LoopCheck.Tick += new System.EventHandler(this.LoopCheck_Tick);
            // 
            // statusCheck
            // 
            this.statusCheck.Enabled = true;
            this.statusCheck.Interval = 500;
            this.statusCheck.Tick += new System.EventHandler(this.statusCheck_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(790, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "label2";
            // 
            // MainScene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 611);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LoopOnOff);
            this.Controls.Add(this.ColNear);
            this.Controls.Add(this.ColNearTex);
            this.Controls.Add(this.digit);
            this.Controls.Add(this.digitTex);
            this.Controls.Add(this.Get7Seg);
            this.Controls.Add(this.ClearAllSeg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SegOnCol);
            this.Controls.Add(this.Set7SegCol);
            this.Controls.Add(this.Set7ToBack);
            this.Controls.Add(this.Add7seg);
            this.Controls.Add(this.panel1);
            this.Name = "MainScene";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainScene_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SevenSegPic)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox SevenSegPic;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Add7seg;
        private System.Windows.Forms.Button Set7ToBack;
        private System.Windows.Forms.Button Set7SegCol;
        private System.Windows.Forms.Panel SegOnCol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ClearAllSeg;
        private System.Windows.Forms.Button Get7Seg;
        private System.Windows.Forms.TextBox digitTex;
        private System.Windows.Forms.Label digit;
        private System.Windows.Forms.Label ColNear;
        private System.Windows.Forms.TextBox ColNearTex;
        private System.Windows.Forms.Button LoopOnOff;
        private System.Windows.Forms.Timer LoopCheck;
        private System.Windows.Forms.Timer statusCheck;
        private System.Windows.Forms.Label label2;
    }
}

