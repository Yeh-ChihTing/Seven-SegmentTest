using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seven_SegmentTest
{
    public partial class Mybox : UserControl
    {
        /// <summary>
        ///　public変数
        /// </summary>

        /// <summary>
        ///　粋番号
        /// </summary>
        public int MyNum = 1;

        /// <summary>
        ///　BoxのRed参照値
        /// </summary>
        public int Red = 30;
        /// <summary>
        ///　BoxのGreen参照値
        /// </summary>
        public int Green = 30;
        /// <summary>
        ///　BoxのBlue参照値
        /// </summary>
        public int Blue = 30;
        /// <summary>
        ///　Boxの正常パーセント参照値
        /// </summary>
        public int MySPercent = 80;

        /// <summary>
        /// 枠線
        /// </summary>
        public Color _borderColor = Color.Blue;
        public Color BorderColor
        {
            get { return this._borderColor; }
            set
            {
                this._borderColor = value;

            }
        }

        /// <summary>
        /// 検査モード
        /// </summary>
        public enum BoxMode
        {
            Samontape = 0,
            LampOn = 1,
            LampOff = 2
        }

        /// <summary>
        /// 検査モード宣言
        /// </summary>
        public BoxMode MyBoxMode;

        /// <summary>
        /// 色合い使用チェックボックス
        /// </summary>
        public bool BoxChecked = false;

        /// <summary>
        /// 色合い使用色　最小は255の赤に設定
        /// </summary>　
        public Color UsedCol = Color.FromArgb(255, 0, 0);

        /// <summary>
        /// private
        /// </summary>

        /// <summary>
        ///　親フォームの横幅値を取得用
        /// </summary>
        private int PWeight = 0;
        /// <summary>
        ///　親フォームの縦幅値を取得用
        /// </summary>
        private int PHeight = 0;

        /// <summary>
        ///　マウスクリックした初期位置
        /// </summary>
        private Point OriginPoint;

        /// <summary>
        ///　初期サイズ
        /// </summary>
        private Size OriginSize;

        /// <summary>
        ///　コンソールとボックス相対位置
        /// </summary>
        public enum ResizeDirection
        {
            None = 0,
            Top = 1,
            Left = 2,
            Bottom = 4,
            Right = 8,
            All = 15
        }


        public enum SevensegPoint
        {
            one,
            two,
            three,
            fore,
            five,
            six,
            seven,
            eight
        }

        public List<sevensegBox> SboxList = new List<sevensegBox>();
        public int Add7SegCnt = 0;
        public int New7Max = 8;

        public bool NowAdd7seg{get;set;}

   
        // 標準のカーソル
        private Cursor defaultCursor;
        //サイズ変更の時位置の移動をブラック用
        private bool ReSize = false;

        public Mybox()
        {
            InitializeComponent();
            // ダブルバッファリングを有効
            SetStyle(ControlStyles.DoubleBuffer, true);

            //グループボックスの描画をオーナードローにする
            SetStyle(ControlStyles.UserPaint, true);

            //this.BackColor = Color.Transparent;

            //粋番号を表示する
            MyNumber.Text = MyNum.ToString();

            //DrawBoxの位置を初期化します
            DrawBox.Location = new Point(this.Location.X + 5, this.Location.Y + 5);
            DrawBox.Width = this.Width - 10;
            DrawBox.Height = this.Height - 10;
            DrawBox.Controls.Add(MyNumber);
            MyBoxMode = BoxMode.Samontape;
            MyNumber.ForeColor = Color.LightSalmon;
            defaultCursor = this.Cursor;
            NowAdd7seg = false;

        }


        //描画命令
        protected override void OnPaint(PaintEventArgs e)
        {
            //DrawBox.SendToBack();

            int right = this.ClientRectangle.Right - 3;
            int bottom = this.ClientRectangle.Bottom - 3;

            Pen pen = new Pen(this._borderColor, 3);

            // 四角を描画
            Graphics g = this.CreateGraphics();
            g.DrawLine(pen, 0, 0, right, 0); // 上辺
            g.DrawLine(pen, 0, 0, 0, bottom); // 左辺
            g.DrawLine(pen, right, 0, right, bottom); // 右辺
            g.DrawLine(pen, 0, bottom, right, bottom); // 下辺


            //Pen p = new Pen(Color.FromArgb(255, Color.Blue), 5);
            ////四角を描画する
            //e.Graphics.DrawRectangle(p, new Rectangle(0, 0, this.Width-1, this.Height-1));
            //p.Dispose();

        }

        //コントロールのサイズ変化の時
        protected override void OnSizeChanged(EventArgs e)
        {
            // 描画をクリア
            this.Refresh();

            base.OnSizeChanged(e);
        }

        //マウスダウン
        private void MyBox_MouseDown(object sender, MouseEventArgs e)
        {
            //マウス左クリック
            if (e.Button == MouseButtons.Left)
            {
                OriginPoint = e.Location;
                PWeight = this.Parent.Width;
                PHeight = this.Parent.Height;
                OriginSize = this.Size;
                this.Capture = true;

                if (NowAdd7seg == true)
                {
                    if (Add7SegCnt < New7Max)
                    {
                        sevensegBox box = new sevensegBox();
                        this.Controls.Add(box);
                        box.Height = this.Height / 30;
                        box.Width = this.Width / 30;
                        box.Location = e.Location;
                        MyNumber.Text = Add7SegCnt.ToString();
                        Add7SegCnt++;
                        SboxList.Add(box);
                    }
                    else
                    {
                        NowAdd7seg = false;
                    }

                }
            }
        }

        //Box移動とサイズ変更用
        private void MyBox_MouseMove(object sender, MouseEventArgs e)
        {


            ResizeDirection cursorPos = ResizeDirection.None;

            //上の判定ボックス生成
            Rectangle topRect = new Rectangle(0, -5, this.Width, 10);
            //当たり判定
            if (topRect.Contains(e.Location))
            {
                cursorPos |= ResizeDirection.Top;
            }



            // 左の判定ボックス生成
            Rectangle leftRect = new Rectangle(-5, 0, 10, this.Height);
            //当たり判定
            if (leftRect.Contains(e.Location))
            {
                cursorPos |= ResizeDirection.Left;
            }


            // 下の判定ボックス生成
            Rectangle bottomRect = new Rectangle(0, this.Height - 10, this.Width, this.Height);
            //当たり判定
            if (bottomRect.Contains(e.Location))
            {
                cursorPos |= ResizeDirection.Bottom;
            }

            // 右の判定ボックス生成
            Rectangle rightRect = new Rectangle(this.Width - 10, 0, this.Width, this.Height);
            //当たり判定
            if (rightRect.Contains(e.Location))
            {
                cursorPos |= ResizeDirection.Right;
            }

            // カーソルを変更
            //左上
            if ((cursorPos & ResizeDirection.Top) == ResizeDirection.Top
            && (cursorPos & ResizeDirection.Left) == ResizeDirection.Left)
            {
                this.Cursor = Cursors.SizeNWSE;
            }
            //右上
            else if ((cursorPos & ResizeDirection.Top) == ResizeDirection.Top
                && (cursorPos & ResizeDirection.Right) == ResizeDirection.Right)
            {
                this.Cursor = Cursors.SizeNESW;
            }

            //左下
            else if ((cursorPos & ResizeDirection.Bottom) == ResizeDirection.Bottom
                && (cursorPos & ResizeDirection.Left) == ResizeDirection.Left)
            {
                this.Cursor = Cursors.SizeNESW;
            }
            //右下
            else if ((cursorPos & ResizeDirection.Bottom) == ResizeDirection.Bottom
                && (cursorPos & ResizeDirection.Right) == ResizeDirection.Right)
            {
                this.Cursor = Cursors.SizeNWSE;
            }

            // 上
            else if ((cursorPos & ResizeDirection.Top) == ResizeDirection.Top)
            {
                this.Cursor = Cursors.SizeNS;
            }
            //　下
            else if ((cursorPos & ResizeDirection.Bottom) == ResizeDirection.Bottom)
            {
                this.Cursor = Cursors.SizeNS;
            }
            // 左
            else if ((cursorPos & ResizeDirection.Left) == ResizeDirection.Left)
            {
                this.Cursor = Cursors.SizeWE;
            }
            //　右
            else if ((cursorPos & ResizeDirection.Right) == ResizeDirection.Right)
            {
                this.Cursor = Cursors.SizeWE;
            }

            //最初のカーソル戻す
            else
            {
                this.Cursor = Cursors.SizeAll;
            }

            //マウスクリック(左)　サイズ変更
            if (e.Button == MouseButtons.Left)
            {
                //クリックした時のマウス位置取得
                int diffX = e.X - OriginPoint.X;
                int diffY = e.Y - OriginPoint.Y;

                //左上
                if ((cursorPos & ResizeDirection.Top) == ResizeDirection.Top
            && (cursorPos & ResizeDirection.Left) == ResizeDirection.Left)
                {
                    //this.Cursor = Cursors.SizeNWSE;
                    //左
                    int w = this.Width;
                    this.Width -= diffX;
                    this.Left += w - this.Width;
                    //上
                    int h = this.Height;
                    this.Height -= diffY;
                    this.Top += h - this.Height;
                    ReSize = true;
                }
                //右上
                else if ((cursorPos & ResizeDirection.Top) == ResizeDirection.Top
                    && (cursorPos & ResizeDirection.Right) == ResizeDirection.Right)
                {
                    //this.Cursor = Cursors.SizeNESW;
                    //右
                    this.Width = OriginSize.Width + diffX;
                    ReSize = true;
                    //上
                    int h = this.Height;
                    this.Height -= diffY;
                    this.Top += h - this.Height;
                    ReSize = true;
                }

                //左下
                else if ((cursorPos & ResizeDirection.Bottom) == ResizeDirection.Bottom
                    && (cursorPos & ResizeDirection.Left) == ResizeDirection.Left)
                {
                    //this.Cursor = Cursors.SizeNESW;
                    //左
                    int w = this.Width;
                    this.Width -= diffX;
                    this.Left += w - this.Width;
                    ReSize = true;
                    //下
                    this.Height = OriginSize.Height + diffY;
                    ReSize = true;
                }
                //右下
                else if ((cursorPos & ResizeDirection.Bottom) == ResizeDirection.Bottom
                    && (cursorPos & ResizeDirection.Right) == ResizeDirection.Right)
                {
                    //this.Cursor = Cursors.SizeNWSE;
                    //右
                    this.Height = OriginSize.Height + diffY;
                    //下
                    this.Width = OriginSize.Width + diffX;
                    ReSize = true;
                }

                // 上
                else if (cursorPos == ResizeDirection.Top)
                {
                    //this.Cursor = Cursors.SizeNS;
                    int h = this.Height;
                    this.Height -= diffY;
                    this.Top += h - this.Height;
                    ReSize = true;

                }
                //　下
                else if (cursorPos == ResizeDirection.Bottom)
                {
                    //this.Cursor = Cursors.SizeNS;
                    this.Height = OriginSize.Height + diffY;
                    ReSize = true;
                }
                // 左
                else if (cursorPos == ResizeDirection.Left)
                {
                    //this.Cursor = Cursors.SizeWE;
                    int w = this.Width;
                    this.Width -= diffX;
                    this.Left += w - this.Width;
                    ReSize = true;
                }
                //　右
                else if (cursorPos == ResizeDirection.Right)
                {
                    //this.Cursor = Cursors.SizeWE;
                    this.Width = OriginSize.Width + diffX;
                    ReSize = true;

                }

                else
                {
                    //サイズ変更していないなら移動許可します
                    if (!ReSize)
                    {
                        this.Cursor = Cursors.SizeAll;

                        //移動
                        if (this.Location.X + this.Width <= PWeight && this.Location.X >= 0 &&
                            this.Location.Y >= 0 && this.Location.Y <= PHeight)
                        {
                            Point mp = new Point(e.X - OriginPoint.X + this.Location.X, e.Y - OriginPoint.Y + this.Location.Y);
                            this.Location = mp;
                        }

                        //横方向限界超える処理
                        if (this.Location.X + this.Width > this.Parent.Width)
                        {
                            this.Location = new Point(PWeight - this.Width, this.Location.Y);
                        }
                        if (this.Location.X < 0)
                        {
                            this.Location = new Point(0, this.Location.Y);
                        }

                        //縦方向限界超える処理
                        if (this.Location.Y + this.Height > this.Parent.Height)
                        {
                            this.Location = new Point(this.Location.X, PHeight - this.Height);
                        }
                        if (this.Location.Y < 0)
                        {
                            this.Location = new Point(this.Location.X, 0);
                        }

                    }
                }

            }
        }


        //タイマー
        private void timer1_Tick(object sender, EventArgs e)
        {
            //背景色を常にColor.Transparent
            this.BackColor = Color.Transparent;

            //DrawBoxの表示と非表示時のMyNumberレベル状態の切り替え
            if (DrawBox.Visible)
            {
                if (DrawBox.Controls.Count == 0)
                {
                    this.Controls.Remove(MyNumber);
                    DrawBox.Controls.Add(MyNumber);
                }
            }
            else
            {
                if (DrawBox.Controls.Count == 1)
                {
                    DrawBox.Controls.Clear();
                    this.Controls.Add(MyNumber);
                }
            }
        }

        //サイズ変更用ボックスにマウスダウン
        private void BottonRight_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                OriginPoint = e.Location;
            
            }
        }

        //サイズ変更した時フォントサイズ変更
        private void MyBox_SizeChanged(object sender, EventArgs e)
        {

            if ((int)(this.Width / 10) > 1)
            {
                MyNumber.Font = new Font(MyNumber.Font.FontFamily, (int)(this.Width / 10));
            }
            else
            {
                MyNumber.Font = new Font(MyNumber.Font.FontFamily, 1);
            }

            //ボックスサイズ表示
            //string a ="Pw:"+this.Parent.Width+"PH:"+this.Parent.Height+ 
            //    "       Width:" + this.Width + "Height:" + this.Height;
            //this.Parent.Parent.Parent.Text = a;

        }

        //粋線色設定
        public void SetColor(Color col)
        {
            BorderColor = col;
        }


        public void ChangeColor(Color col)
        {
            _borderColor = col;
            this.Invalidate();
        }

        //マウスダウンの時Box位置記録
        private void Drawbox_MouseDown(object sender, MouseEventArgs e)
        {
          
            if (e.Button == MouseButtons.Left)
            {
                OriginPoint = e.Location;
                PWeight = this.Parent.Width;
                PHeight = this.Parent.Height;

                if (NowAdd7seg == true)
                {
                    if (Add7SegCnt < New7Max)
                    {
                        sevensegBox box = new sevensegBox();
                        this.Controls.Add(box);
                        box.Location = e.Location;
                        MyNumber.Text = (Add7SegCnt+1).ToString();
                        Add7SegCnt++;
                        SboxList.Add(box);
                    }
                    else
                    {
                        NowAdd7seg = false;
                    }

                }

            }
        }

        //Box移動用
        private void Drawbox_MouseMove(object sender, MouseEventArgs e)
        {

            this.Cursor = defaultCursor;
        }

        //マウスアップ
        private void MyBox_MouseUp(object sender, MouseEventArgs e)
        {
            this.Capture = false;
            ReSize = false;
        }

        //マウスクリックした時にメインシーンのNOWBOX番号を変更(ボックス本体)
        private void MyBox_MouseClick(object sender, MouseEventArgs e)
        {
            //メインシーン宣言
            MainScene main = (MainScene)this.Parent.Parent.Parent;


            ////連続チェック中にはしない
            //if (!main.LoopCheckLock)
            //{
            //    main.NowBox = MyNum;
            //    int num = main.NowBox;
            //    main.ClickBoxNum.Text = num.ToString();
            //}
        }

        //マウスクリックした時にメインシーンのNOWBOX番号を変更(DRAWBOX)
        private void Drawbox_Click(object sender, EventArgs e)
        {
            ////メインシーン宣言
            //MainScene main = (MainScene)this.Parent.Parent.Parent;

            ////連続チェック中にはしない
            //if (!main.LoopCheckLock)
            //{
            //    main.NowBox = MyNum;
            //    int num = main.NowBox;
            //    main.ClickBoxNum.Text = num.ToString();
            //}

        }
    }
}
