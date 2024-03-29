﻿
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
            this.Set7SegCol = new System.Windows.Forms.Button();
            this.SegOnCol = new System.Windows.Forms.Panel();
            this.ClearAllSeg = new System.Windows.Forms.Button();
            this.Get7Seg = new System.Windows.Forms.Button();
            this.digitTex = new System.Windows.Forms.TextBox();
            this.digit = new System.Windows.Forms.Label();
            this.ColNear = new System.Windows.Forms.Label();
            this.SegNearCol = new System.Windows.Forms.TextBox();
            this.LoopOnOff = new System.Windows.Forms.Button();
            this.LoopCheck = new System.Windows.Forms.Timer(this.components);
            this.statusCheck = new System.Windows.Forms.Timer(this.components);
            this.ShowCol = new System.Windows.Forms.ComboBox();
            this.ShowAns = new System.Windows.Forms.ListBox();
            this.GetCam = new System.Windows.Forms.Timer(this.components);
            this.PerScreen = new System.Windows.Forms.ComboBox();
            this.AllOneCol = new System.Windows.Forms.CheckBox();
            this.SetAnalogPos = new System.Windows.Forms.Button();
            this.AnalogCheck = new System.Windows.Forms.Button();
            this.AnalogCol = new System.Windows.Forms.Button();
            this.AnalogReset = new System.Windows.Forms.Button();
            this.AnalogColBox = new System.Windows.Forms.PictureBox();
            this.AnaNearCol = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AnaOr7Seg = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SetCheckPoint = new System.Windows.Forms.Button();
            this.CheckPointLabel = new System.Windows.Forms.Label();
            this.PointListBox = new System.Windows.Forms.ListBox();
            this.AddPoint = new System.Windows.Forms.Button();
            this.PontAddTex = new System.Windows.Forms.TextBox();
            this.ClearPointBox = new System.Windows.Forms.Button();
            this.CheckPointNum = new System.Windows.Forms.Label();
            this.Gamma = new System.Windows.Forms.Timer(this.components);
            this.GammaBar = new System.Windows.Forms.TrackBar();
            this.GammaOn = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LightBar = new System.Windows.Forms.TrackBar();
            this.LightBarNum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SevenSegPic)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnalogColBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GammaBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LightBar)).BeginInit();
            this.SuspendLayout();
            // 
            // SevenSegPic
            // 
            this.SevenSegPic.BackColor = System.Drawing.Color.Transparent;
            this.SevenSegPic.ErrorImage = null;
            this.SevenSegPic.InitialImage = null;
            this.SevenSegPic.Location = new System.Drawing.Point(16, 21);
            this.SevenSegPic.Name = "SevenSegPic";
            this.SevenSegPic.Size = new System.Drawing.Size(640, 360);
            this.SevenSegPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SevenSegPic.TabIndex = 0;
            this.SevenSegPic.TabStop = false;
            this.SevenSegPic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SevenSegPic_MouseDown);
            this.SevenSegPic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SevenSegPic_MouseMove);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.SevenSegPic);
            this.panel1.Location = new System.Drawing.Point(18, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(679, 405);
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
            this.Get7Seg.Location = new System.Drawing.Point(714, 227);
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
            // SegNearCol
            // 
            this.SegNearCol.Location = new System.Drawing.Point(750, 315);
            this.SegNearCol.Name = "SegNearCol";
            this.SegNearCol.Size = new System.Drawing.Size(78, 23);
            this.SegNearCol.TabIndex = 13;
            this.SegNearCol.Text = "30";
            // 
            // LoopOnOff
            // 
            this.LoopOnOff.BackColor = System.Drawing.Color.Red;
            this.LoopOnOff.Location = new System.Drawing.Point(744, 256);
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
            // ShowCol
            // 
            this.ShowCol.FormattingEnabled = true;
            this.ShowCol.Location = new System.Drawing.Point(714, 160);
            this.ShowCol.Name = "ShowCol";
            this.ShowCol.Size = new System.Drawing.Size(121, 23);
            this.ShowCol.TabIndex = 17;
            // 
            // ShowAns
            // 
            this.ShowAns.Font = new System.Drawing.Font("Yu Gothic UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ShowAns.FormattingEnabled = true;
            this.ShowAns.ItemHeight = 30;
            this.ShowAns.Location = new System.Drawing.Point(720, 348);
            this.ShowAns.Name = "ShowAns";
            this.ShowAns.Size = new System.Drawing.Size(120, 94);
            this.ShowAns.TabIndex = 18;
            // 
            // GetCam
            // 
            this.GetCam.Enabled = true;
            this.GetCam.Tick += new System.EventHandler(this.GetCam_Tick);
            // 
            // PerScreen
            // 
            this.PerScreen.FormattingEnabled = true;
            this.PerScreen.Items.AddRange(new object[] {
            "100%",
            "200%",
            "400%"});
            this.PerScreen.Location = new System.Drawing.Point(714, 12);
            this.PerScreen.Name = "PerScreen";
            this.PerScreen.Size = new System.Drawing.Size(76, 23);
            this.PerScreen.TabIndex = 20;
            // 
            // AllOneCol
            // 
            this.AllOneCol.AutoSize = true;
            this.AllOneCol.Checked = true;
            this.AllOneCol.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AllOneCol.Location = new System.Drawing.Point(736, 189);
            this.AllOneCol.Name = "AllOneCol";
            this.AllOneCol.Size = new System.Drawing.Size(62, 19);
            this.AllOneCol.TabIndex = 21;
            this.AllOneCol.Text = "色統一";
            this.AllOneCol.UseVisualStyleBackColor = true;
            // 
            // SetAnalogPos
            // 
            this.SetAnalogPos.Location = new System.Drawing.Point(13, 441);
            this.SetAnalogPos.Name = "SetAnalogPos";
            this.SetAnalogPos.Size = new System.Drawing.Size(102, 23);
            this.SetAnalogPos.TabIndex = 22;
            this.SetAnalogPos.Text = "アナログ位置設定";
            this.SetAnalogPos.UseVisualStyleBackColor = true;
            this.SetAnalogPos.Click += new System.EventHandler(this.SetAnalogPos_Click);
            // 
            // AnalogCheck
            // 
            this.AnalogCheck.Location = new System.Drawing.Point(13, 493);
            this.AnalogCheck.Name = "AnalogCheck";
            this.AnalogCheck.Size = new System.Drawing.Size(102, 23);
            this.AnalogCheck.TabIndex = 23;
            this.AnalogCheck.Text = "アナログ値チェック";
            this.AnalogCheck.UseVisualStyleBackColor = true;
            this.AnalogCheck.Click += new System.EventHandler(this.AnalogCheck_Click);
            // 
            // AnalogCol
            // 
            this.AnalogCol.Location = new System.Drawing.Point(284, 442);
            this.AnalogCol.Name = "AnalogCol";
            this.AnalogCol.Size = new System.Drawing.Size(71, 23);
            this.AnalogCol.TabIndex = 24;
            this.AnalogCol.Text = "指針色";
            this.AnalogCol.UseVisualStyleBackColor = true;
            this.AnalogCol.Click += new System.EventHandler(this.AnalogCol_Click);
            // 
            // AnalogReset
            // 
            this.AnalogReset.Location = new System.Drawing.Point(13, 536);
            this.AnalogReset.Name = "AnalogReset";
            this.AnalogReset.Size = new System.Drawing.Size(88, 23);
            this.AnalogReset.TabIndex = 26;
            this.AnalogReset.Text = "アナログリセット";
            this.AnalogReset.UseVisualStyleBackColor = true;
            this.AnalogReset.Click += new System.EventHandler(this.AnalogReset_Click);
            // 
            // AnalogColBox
            // 
            this.AnalogColBox.BackColor = System.Drawing.Color.Black;
            this.AnalogColBox.Location = new System.Drawing.Point(361, 447);
            this.AnalogColBox.Name = "AnalogColBox";
            this.AnalogColBox.Size = new System.Drawing.Size(27, 18);
            this.AnalogColBox.TabIndex = 27;
            this.AnalogColBox.TabStop = false;
            // 
            // AnaNearCol
            // 
            this.AnaNearCol.Location = new System.Drawing.Point(439, 443);
            this.AnaNearCol.Name = "AnaNearCol";
            this.AnaNearCol.Size = new System.Drawing.Size(38, 23);
            this.AnaNearCol.TabIndex = 28;
            this.AnaNearCol.Text = "10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(146, 523);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 37);
            this.label2.TabIndex = 29;
            this.label2.Text = "アナログ数値";
            // 
            // AnaOr7Seg
            // 
            this.AnaOr7Seg.AutoSize = true;
            this.AnaOr7Seg.Location = new System.Drawing.Point(170, 445);
            this.AnaOr7Seg.Name = "AnaOr7Seg";
            this.AnaOr7Seg.Size = new System.Drawing.Size(87, 19);
            this.AnaOr7Seg.TabIndex = 30;
            this.AnaOr7Seg.Text = "アナログモード";
            this.AnaOr7Seg.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(392, 447);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 31;
            this.label3.Text = "色合い";
            // 
            // SetCheckPoint
            // 
            this.SetCheckPoint.Location = new System.Drawing.Point(252, 493);
            this.SetCheckPoint.Name = "SetCheckPoint";
            this.SetCheckPoint.Size = new System.Drawing.Size(75, 23);
            this.SetCheckPoint.TabIndex = 32;
            this.SetCheckPoint.Text = "ポイント設置";
            this.SetCheckPoint.UseVisualStyleBackColor = true;
            this.SetCheckPoint.Click += new System.EventHandler(this.SetCheckPoint_Click);
            // 
            // CheckPointLabel
            // 
            this.CheckPointLabel.AutoSize = true;
            this.CheckPointLabel.Location = new System.Drawing.Point(146, 497);
            this.CheckPointLabel.Name = "CheckPointLabel";
            this.CheckPointLabel.Size = new System.Drawing.Size(49, 15);
            this.CheckPointLabel.TabIndex = 34;
            this.CheckPointLabel.Text = "SetNum";
            // 
            // PointListBox
            // 
            this.PointListBox.FormattingEnabled = true;
            this.PointListBox.ItemHeight = 15;
            this.PointListBox.Location = new System.Drawing.Point(333, 497);
            this.PointListBox.Name = "PointListBox";
            this.PointListBox.Size = new System.Drawing.Size(100, 79);
            this.PointListBox.TabIndex = 35;
            // 
            // AddPoint
            // 
            this.AddPoint.Location = new System.Drawing.Point(440, 552);
            this.AddPoint.Name = "AddPoint";
            this.AddPoint.Size = new System.Drawing.Size(75, 23);
            this.AddPoint.TabIndex = 36;
            this.AddPoint.Text = "Add";
            this.AddPoint.UseVisualStyleBackColor = true;
            this.AddPoint.Click += new System.EventHandler(this.AddPoint_Click);
            // 
            // PontAddTex
            // 
            this.PontAddTex.Location = new System.Drawing.Point(440, 523);
            this.PontAddTex.Name = "PontAddTex";
            this.PontAddTex.Size = new System.Drawing.Size(75, 23);
            this.PontAddTex.TabIndex = 37;
            this.PontAddTex.Text = "25";
            // 
            // ClearPointBox
            // 
            this.ClearPointBox.Location = new System.Drawing.Point(522, 552);
            this.ClearPointBox.Name = "ClearPointBox";
            this.ClearPointBox.Size = new System.Drawing.Size(75, 23);
            this.ClearPointBox.TabIndex = 38;
            this.ClearPointBox.Text = "Clear";
            this.ClearPointBox.UseVisualStyleBackColor = true;
            this.ClearPointBox.Click += new System.EventHandler(this.ClearPointBox_Click);
            // 
            // CheckPointNum
            // 
            this.CheckPointNum.AutoSize = true;
            this.CheckPointNum.Location = new System.Drawing.Point(201, 497);
            this.CheckPointNum.Name = "CheckPointNum";
            this.CheckPointNum.Size = new System.Drawing.Size(13, 15);
            this.CheckPointNum.TabIndex = 39;
            this.CheckPointNum.Text = "0";
            // 
            // Gamma
            // 
            this.Gamma.Tick += new System.EventHandler(this.Gamma_Tick);
            // 
            // GammaBar
            // 
            this.GammaBar.Location = new System.Drawing.Point(570, 471);
            this.GammaBar.Maximum = 300;
            this.GammaBar.Name = "GammaBar";
            this.GammaBar.Size = new System.Drawing.Size(104, 45);
            this.GammaBar.TabIndex = 41;
            // 
            // GammaOn
            // 
            this.GammaOn.AutoSize = true;
            this.GammaOn.Location = new System.Drawing.Point(486, 479);
            this.GammaOn.Name = "GammaOn";
            this.GammaOn.Size = new System.Drawing.Size(78, 19);
            this.GammaOn.TabIndex = 42;
            this.GammaOn.Text = "ガンマ補正";
            this.GammaOn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(483, 447);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 43;
            this.label1.Text = "明るさ";
            // 
            // LightBar
            // 
            this.LightBar.Location = new System.Drawing.Point(525, 430);
            this.LightBar.Maximum = 30;
            this.LightBar.Minimum = -20;
            this.LightBar.Name = "LightBar";
            this.LightBar.Size = new System.Drawing.Size(104, 45);
            this.LightBar.TabIndex = 45;
            this.LightBar.Scroll += new System.EventHandler(this.LightBar_Scroll);
            // 
            // LightBarNum
            // 
            this.LightBarNum.AutoSize = true;
            this.LightBarNum.Location = new System.Drawing.Point(631, 443);
            this.LightBarNum.Name = "LightBarNum";
            this.LightBarNum.Size = new System.Drawing.Size(13, 15);
            this.LightBarNum.TabIndex = 46;
            this.LightBarNum.Text = "0";
            // 
            // MainScene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 611);
            this.Controls.Add(this.LightBarNum);
            this.Controls.Add(this.LightBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GammaOn);
            this.Controls.Add(this.GammaBar);
            this.Controls.Add(this.CheckPointNum);
            this.Controls.Add(this.ClearPointBox);
            this.Controls.Add(this.PontAddTex);
            this.Controls.Add(this.AddPoint);
            this.Controls.Add(this.PointListBox);
            this.Controls.Add(this.CheckPointLabel);
            this.Controls.Add(this.SetCheckPoint);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AnaOr7Seg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AnaNearCol);
            this.Controls.Add(this.AnalogColBox);
            this.Controls.Add(this.AnalogReset);
            this.Controls.Add(this.AnalogCol);
            this.Controls.Add(this.AnalogCheck);
            this.Controls.Add(this.SetAnalogPos);
            this.Controls.Add(this.AllOneCol);
            this.Controls.Add(this.PerScreen);
            this.Controls.Add(this.ShowAns);
            this.Controls.Add(this.ShowCol);
            this.Controls.Add(this.LoopOnOff);
            this.Controls.Add(this.ColNear);
            this.Controls.Add(this.SegNearCol);
            this.Controls.Add(this.digit);
            this.Controls.Add(this.digitTex);
            this.Controls.Add(this.Get7Seg);
            this.Controls.Add(this.ClearAllSeg);
            this.Controls.Add(this.SegOnCol);
            this.Controls.Add(this.Set7SegCol);
            this.Controls.Add(this.Add7seg);
            this.Controls.Add(this.panel1);
            this.Name = "MainScene";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainScene_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SevenSegPic)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AnalogColBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GammaBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LightBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox SevenSegPic;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Add7seg;
        private System.Windows.Forms.Button Set7SegCol;
        private System.Windows.Forms.Panel SegOnCol;
        private System.Windows.Forms.Button ClearAllSeg;
        private System.Windows.Forms.Button Get7Seg;
        private System.Windows.Forms.TextBox digitTex;
        private System.Windows.Forms.Label digit;
        private System.Windows.Forms.Label ColNear;
        private System.Windows.Forms.TextBox SegNearCol;
        private System.Windows.Forms.Button LoopOnOff;
        private System.Windows.Forms.Timer LoopCheck;
        private System.Windows.Forms.Timer statusCheck;
        private System.Windows.Forms.ComboBox ShowCol;
        private System.Windows.Forms.ListBox ShowAns;
        private System.Windows.Forms.Timer GetCam;
        private System.Windows.Forms.ComboBox PerScreen;
        private System.Windows.Forms.CheckBox AllOneCol;
        private System.Windows.Forms.Button SetAnalogPos;
        private System.Windows.Forms.Button AnalogCheck;
        private System.Windows.Forms.Button AnalogCol;
        private System.Windows.Forms.Button AnalogReset;
        private System.Windows.Forms.PictureBox AnalogColBox;
        private System.Windows.Forms.TextBox AnaNearCol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox AnaOr7Seg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SetCheckPoint;
        private System.Windows.Forms.Label CheckPointLabel;
        private System.Windows.Forms.ListBox PointListBox;
        private System.Windows.Forms.Button AddPoint;
        private System.Windows.Forms.TextBox PontAddTex;
        private System.Windows.Forms.Button ClearPointBox;
        private System.Windows.Forms.Label CheckPointNum;
        private System.Windows.Forms.Timer Gamma;
        private System.Windows.Forms.TrackBar GammaBar;
        private System.Windows.Forms.CheckBox GammaOn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar LightBar;
        private System.Windows.Forms.Label LightBarNum;
    }
}

