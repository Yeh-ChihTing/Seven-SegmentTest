
namespace Seven_SegmentTest
{
    partial class Mybox
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.DrawBox = new System.Windows.Forms.PictureBox();
            this.MyNumber = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DrawBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DrawBox
            // 
            this.DrawBox.BackColor = System.Drawing.Color.Transparent;
            this.DrawBox.Location = new System.Drawing.Point(3, 3);
            this.DrawBox.Name = "DrawBox";
            this.DrawBox.Size = new System.Drawing.Size(144, 144);
            this.DrawBox.TabIndex = 0;
            this.DrawBox.TabStop = false;
            this.DrawBox.Visible = false;
            this.DrawBox.Click += new System.EventHandler(this.Drawbox_Click);
            this.DrawBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Drawbox_MouseDown);
            this.DrawBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Drawbox_MouseMove);
            // 
            // MyNumber
            // 
            this.MyNumber.AutoSize = true;
            this.MyNumber.Location = new System.Drawing.Point(3, 0);
            this.MyNumber.Name = "MyNumber";
            this.MyNumber.Size = new System.Drawing.Size(38, 15);
            this.MyNumber.TabIndex = 1;
            this.MyNumber.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Mybox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MyNumber);
            this.Controls.Add(this.DrawBox);
            this.Name = "Mybox";
            this.SizeChanged += new System.EventHandler(this.MyBox_SizeChanged);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MyBox_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MyBox_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MyBox_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MyBox_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.DrawBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label MyNumber;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.PictureBox DrawBox;
    }
}
