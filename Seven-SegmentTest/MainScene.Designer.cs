
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
            this.label1 = new System.Windows.Forms.Label();
            this.AnalogReset = new System.Windows.Forms.Button();
            this.AnalogColBox = new System.Windows.Forms.PictureBox();
            this.AnaNearCol = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AnaOr7Seg = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.SevenSegPic)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnalogColBox)).BeginInit();
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
            this.ShowAns.FormattingEnabled = true;
            this.ShowAns.ItemHeight = 15;
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
            this.AnalogCol.Location = new System.Drawing.Point(170, 493);
            this.AnalogCol.Name = "AnalogCol";
            this.AnalogCol.Size = new System.Drawing.Size(71, 23);
            this.AnalogCol.TabIndex = 24;
            this.AnalogCol.Text = "指針色";
            this.AnalogCol.UseVisualStyleBackColor = true;
            this.AnalogCol.Click += new System.EventHandler(this.AnalogCol_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 497);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 25;
            this.label1.Text = "label1";
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
            this.AnalogColBox.Location = new System.Drawing.Point(247, 498);
            this.AnalogColBox.Name = "AnalogColBox";
            this.AnalogColBox.Size = new System.Drawing.Size(27, 18);
            this.AnalogColBox.TabIndex = 27;
            this.AnalogColBox.TabStop = false;
            // 
            // AnaNearCol
            // 
            this.AnaNearCol.Location = new System.Drawing.Point(203, 522);
            this.AnaNearCol.Name = "AnaNearCol";
            this.AnaNearCol.Size = new System.Drawing.Size(38, 23);
            this.AnaNearCol.TabIndex = 28;
            this.AnaNearCol.Text = "10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 516);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 29;
            this.label2.Text = "label2";
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
            // MainScene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 611);
            this.Controls.Add(this.AnaOr7Seg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AnaNearCol);
            this.Controls.Add(this.AnalogColBox);
            this.Controls.Add(this.AnalogReset);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AnalogReset;
        private System.Windows.Forms.PictureBox AnalogColBox;
        private System.Windows.Forms.TextBox AnaNearCol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox AnaOr7Seg;
    }
}

