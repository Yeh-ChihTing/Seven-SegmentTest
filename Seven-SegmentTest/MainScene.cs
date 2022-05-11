using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;



namespace Seven_SegmentTest
{
    public partial class MainScene : Form
    {
        public MainScene()
        {
            InitializeComponent();
        }

        private Mat img = new();
        private Image Get7Pic { get; set; }

        /// <summary>
        /// 7セグ用関数
        /// </summary>
        //private Mybox box = new();

        private bool StarChooseCol = false;

        private bool sevensegadd = false;

       // private int SegPointCnt = 0;

        private bool FirstColSel = true;

        private List<sevensegBox> SevenCList = new ();

        private List<List<sevensegBox>> AllSegList = new();

        private Image CameraImg { get; set; }

        /// <summary>
        /// 7セグ用変数End
        /// </summary>

        /// <summary> 
        /// アナログ用関数
        /// </summary>

        private bool StartAnalogSet = false;

        private List<AnalogBox> AllAnaBox =new();

        private bool SetAnalogCol = false;

        //private int CntStandPos = 0;
        private int StandPosMax = 3;



        Int32 LINE = 200;     // 線の長さ
        Int32 LINE2 = 0;
        const Int32 P_DOT = 5;      // 点Pの円の半径
        const Int32 Q_DOT = 5;      // 点Qの円の半径
        const Int32 O_DOT = 5;      // 点Oの円の半径


        //Bitmap m_Bmp;
        //Graphics m_Graphic;
        //Font m_Font;
        System.Drawing.Point m_P;     // 点Pの座標（PictureBoxの中心）
        System.Drawing.Point m_Q;     // 点Qの座標
        System.Drawing.Point m_O;     // 点Oの座標
        System.Drawing.Point m_O2;

        private bool StartSetPoint = false;
        private List<int> PointList = new List<int>();
        private int MaxPoint { get; set; }
        //private int CntPoint { get; set; }
        private List<AnalogBox> CheckPointList = new List<AnalogBox>();
        private List<int> CheckPointAngle = new List<int>();

       // private int CntPoint { get; set; }

        private int AnaAnswer { get; set; }

        private double GetGamma = 0.0f;



        /// <summary> 
        /// アナログ用関数End
        /// </summary>

        private void MainScene_Load(object sender, EventArgs e)
        {
            PerScreen.SelectedIndex = 0;
           //Mybox box = new Mybox();
           // SevenSegPic1.Controls.Add(box);

            //box.Size = new System.Drawing.Size(80, 80);

            //panel1.Controls.Add(SevenSegPic1);


            // TrackBarの設定
            //trackBar1.Minimum = 0;
            //trackBar1.Maximum = 360;
            //trackBar1.Value = 0;

            // 点P・Qの座標を設定
            m_P = new System.Drawing.Point((SevenSegPic.Size.Width / 2), (SevenSegPic.Size.Height / 2));
            m_Q = new System.Drawing.Point((SevenSegPic.Size.Width / 2 + LINE), (SevenSegPic.Size.Height / 2));
            m_O = new System.Drawing.Point();
            m_O2 = new System.Drawing.Point();

            //CntPoint = 0;
            // PictureBoxと同じサイズのビットマップを生成
            //m_Bmp = new Bitmap(SevenSegPic1.Size.Width, SevenSegPic1.Size.Height);
            //SevenSegPic1.Image = m_Bmp;
            //m_Graphic = Graphics.FromImage(m_Bmp);
            //m_Font = new Font("MS UI Gothic", 10);

            // PictureBox描画処理
            GetOPos(0);

            /// <summary>
            /// カメラ画面取得
            /// </summary>
            VideoCapture vc = new();

            if (!Directory.Exists("SaveData"))
            {
                Directory.CreateDirectory("SaveData");
            }

            /// <summary>
            /// カメラの稼働処理
            /// </summary>
            try
            {

                _ = Task.Run(() =>
                  {

                      //WEBカメラモード

                      //使用するカメラを取得
                      vc = new VideoCapture(0);

                      //取得カメラをオープン
                      vc.Open(0);

                      //表示できないなら
                      if (!vc.ConvertRgb)
                      {
                          MessageBox.Show("このカメラは使用できない");
                      }


                      if (vc.ConvertRgb)
                      {
                          //カメラ画像表示ループ
                          while (true)
                          {
                              //取得した画像をMATに変換
                              img = vc.RetrieveMat();

                              if (GammaOn.Checked)
                              {
                                  byte[] lut = new byte[256];
                                  for (int i = 0; i < lut.Length; i++)
                                  {
                                      lut[i] = (byte)(Math.Pow(i / 255.0, 1.0 / GetGamma) * 255.0);
                                  }
                                  Cv2.LUT(img, lut, img);
                              }

                              //変換したMatをbitmapに変換そしてカメライメージとして表示
                              CameraImg = img.ToBitmap();

                          }
                      } 

                  });

            }
            catch
            {

            }

        }

        private void Add7seg_Click(object sender, EventArgs e)
        {

            if (sevensegadd == false)
            {
                sevensegadd = true;
               // Convert.ToInt32(digitTex.Text)++;
            }
        }

        private void Set7SegCol_Click(object sender, EventArgs e)
        {
            StarChooseCol = true;
            //SevenCList = new List<sevensegBox>();
        }

        private void SevenSegPic_MouseMove(object sender, MouseEventArgs e)
        {

            //指定色ボックス検査色
            if (StarChooseCol)
            {
                Get7Pic = SevenSegPic.Image;

                Color color = ((Bitmap)Get7Pic).GetPixel(e.X, e.Y);


               // this.Cursor = Cursors.Hand;
                SegOnCol.BackColor = Color.FromArgb(color.R, color.G, color.B);
               

                //cntCol = 0;        

            }

            if (SetAnalogCol)
            {
                Color color = ((Bitmap)SevenSegPic.Image).GetPixel(e.X, e.Y);


                //this.Cursor = Cursors.Hand;
                AnalogColBox.BackColor = Color.FromArgb(color.R, color.G, color.B);

            }

            //if (SevenSegPic != null)
            //{
            //    Color colorb = ((Bitmap)SevenSegPic.Image).GetPixel(e.X, e.Y);

            //    label1.Text = colorb.ToString();
            //}
        }


        private void SevenSegPic_MouseDown(object sender, MouseEventArgs e)
        {
            //string cnt = digitTex.Text;

            //7セグ用
            int maxSeg = Convert.ToInt32(digitTex.Text) * 8;

            if (StarChooseCol)
            {              
               // this.Cursor = Cursors.Default;
                ShowCol.Items.Add(SegOnCol.BackColor);

                StarChooseCol = false;
                if (FirstColSel)
                {
                    ShowCol.SelectedIndex = 0;
                    FirstColSel = false;
                }
            }

            if (SetAnalogCol)
            {
               // this.Cursor = Cursors.Default;

                //AnalogBox.DefaultBackColor=
                //label1.Text = AnalogColBox.BackColor.ToString();
                SetAnalogCol = false;

            }


            if (sevensegadd == true)
            {


                if (SevenCList.Count < maxSeg)
                {

                    sevensegBox box = new();
                    //panel1.Controls[0].Controls.Add(box);
                    SevenSegPic.Controls.Add(box);
                    box.Height = 4;// SevenSegPic1.Height / 80;
                    box.Width = 8;// SevenSegPic1.Width / 80;
                    box.Location = e.Location;
                    //MyNumber.Text = Add7SegCnt.ToString();
                    //SegPointCnt++;
                    SevenCList.Add(box);

                    if (SevenCList.Count == maxSeg)
                    {
                        List<sevensegBox> Sbox = new();
                        for (int i = 0; i < SevenCList.Count; i++)
                        {
                            Sbox.Add(SevenCList[i]);
                        }

                        //cntNumOfSevenSeg++;
                       // SegPointCnt = 0;
                        AllSegList.Add(Sbox);
                        //SevenCList.Clear();

                        SevenCList.Clear();

                        sevensegadd = false;
                    }


                }

            }
            //7セグ用End

            //アナログ用

            if (StartAnalogSet)
            {
                
             

                if (AllAnaBox.Count < StandPosMax)
                {
                    AnalogBox Abox = new();
                    SevenSegPic.Controls.Add(Abox);
                    Abox.Width = 4;
                    Abox.Height = 4;
                    Abox.Location = e.Location;
                    //CntStandPos++;
                    AllAnaBox.Add(Abox);

                    if (AllAnaBox.Count == StandPosMax)
                    {
                        StartAnalogSet = false;
                    }

                }


            }

            if (StartSetPoint)
            {
                if (CheckPointList.Count < MaxPoint)
                {
                    AnalogBox Abox = new();
                    SevenSegPic.Controls.Add(Abox);
                    Abox.Width = 4;
                    Abox.Height = 4;
                    Abox.Location = e.Location;
                    Abox.pictureBox1.BackColor = Color.Purple;
                    //CntPoint++;
                    CheckPointList.Add(Abox);

                    if (CheckPointList.Count == MaxPoint)
                    {
                        StartAnalogSet = false;
                    }
                }
                
            }
        }
        private void ClearAllSeg_Click(object sender, EventArgs e)
        {
            //Convert.ToInt32(digitTex.Text) = 0;

            int cnt = SevenSegPic.Controls.Count;

            for (int i = 0; i < cnt; i++)
            {
                SevenSegPic.Controls.RemoveByKey("sevensegBox");
            }
            //SevenSegPic1.Controls.Clear();
            
           // SevenCList.Clear();
            //SegPointCnt = 0;

            AllSegList.Clear();

            FirstColSel = true;

            if (ShowCol.Items.Count > 0)
            {

                DialogResult result = MessageBox.Show("色もリセットします？", "", MessageBoxButtons.YesNo);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {

                    ShowCol.Items.Clear();
                    ShowCol.Text = "";
                    ShowCol.BackColor = default;
                }
            }
        }

       
        private void Get7Seg_Click(object sender, EventArgs e)
        {

            Check7Seg();

        }

        private bool IsNear(Color aObj, Color bObj)
        {
            int ColLike = Convert.ToInt32(SegNearCol.Text);

            if (aObj.R <= bObj.R + ColLike && aObj.R >= bObj.R - ColLike&&
                aObj.G <= bObj.G + ColLike && aObj.G >= bObj.G - ColLike&&
                aObj.B <= bObj.B + ColLike && aObj.B >= bObj.B - ColLike)
            {
                return true;
            }

            return false;
           
        }

        private void Check7Seg()
        {
            if (AllSegList.Count != 0 && ShowCol.Items.Count != 0)
            {

                string Show7Seg;
                Get7Pic = SevenSegPic.Image;
                Bitmap BackImage = (Bitmap)Get7Pic.Clone();
                int r, g, b;

                ShowAns.Items.Clear();
                //AnsList.Clear();

                //if (SevenCList.Count >= Convert.ToInt32(digitTex.Text) * 8)
                //{


                // CheackCol.BackColor = SevenCList[0].MyCol;
                //label1.Text = CheackCol.BackColor.ToString();

                for (int cnt = 0; cnt < AllSegList.Count; cnt++)
                {
                    for (int i = 0; i < Convert.ToInt32(digitTex.Text) * 8; i++)
                    {
                        int w = AllSegList[cnt][i].Width;
                        int h = AllSegList[cnt][i].Height;

                        r = BackImage.GetPixel(AllSegList[cnt][i].Location.X + w, AllSegList[cnt][i].Location.Y + h).R;
                        g = BackImage.GetPixel(AllSegList[cnt][i].Location.X + w, AllSegList[cnt][i].Location.Y + h).G;
                        b = BackImage.GetPixel(AllSegList[cnt][i].Location.X + w, AllSegList[cnt][i].Location.Y + h).B;
                        Color col = Color.FromArgb(255, r, g, b);
                        AllSegList[cnt][i].setCol(col);
                    }
                }


                for (int cnt = 0; cnt < AllSegList.Count; cnt++)
                {
                    Show7Seg = "";

                    Color SegCol;

                    if (!AllOneCol.Checked)
                    {
                        string[] GetColStr = ShowCol.Items[cnt].ToString().Split(',', ']');

                        int[] GetCol = new int[3];

                        for (int i = 0; i < 3; i++)
                        {
                            string[] GetC = GetColStr[i + 1].Split('=', ']');

                            GetCol[i] = Convert.ToInt32(GetC[1]);
                        }
                        SegCol = Color.FromArgb(255, GetCol[0], GetCol[1], GetCol[2]);
                    }
                    else
                    {
                        string[] GetColStr = ShowCol.Items[0].ToString().Split(',', ']');

                        int[] GetCol = new int[3];

                        for (int i = 0; i < 3; i++)
                        {
                            string[] GetC = GetColStr[i + 1].Split('=', ']');

                            GetCol[i] = Convert.ToInt32(GetC[1]);
                        }

                        SegCol = Color.FromArgb(255, GetCol[0], GetCol[1], GetCol[2]);
                    }

                    for (int i = 0; i < Convert.ToInt32(digitTex.Text); i++)
                    {
                        int nowcnetseg = i * 8;

                        //0
                        if (
                                (!IsNear(AllSegList[cnt][nowcnetseg + 0].MyCol, SegCol)) &&
                                (!IsNear(AllSegList[cnt][nowcnetseg + 1].MyCol, SegCol)) &&
                                (!IsNear(AllSegList[cnt][nowcnetseg + 2].MyCol, SegCol)) &&
                                (IsNear(AllSegList[cnt][nowcnetseg + 3].MyCol, SegCol)) &&
                                (!IsNear(AllSegList[cnt][nowcnetseg + 4].MyCol, SegCol)) &&
                                (!IsNear(AllSegList[cnt][nowcnetseg + 5].MyCol, SegCol)) &&
                                (!IsNear(AllSegList[cnt][nowcnetseg + 6].MyCol, SegCol))
                                )
                        {
                            Show7Seg += "0";
                        }

                        //1
                        else if (
                          (IsNear(AllSegList[cnt][nowcnetseg + 0].MyCol, SegCol)) &&
                          (IsNear(AllSegList[cnt][nowcnetseg + 1].MyCol, SegCol)) &&
                          (IsNear(AllSegList[cnt][nowcnetseg + 2].MyCol, SegCol)) &&
                          (IsNear(AllSegList[cnt][nowcnetseg + 3].MyCol, SegCol)) &&
                          (IsNear(AllSegList[cnt][nowcnetseg + 4].MyCol, SegCol)) &&
                          (!IsNear(AllSegList[cnt][nowcnetseg + 5].MyCol, SegCol)) &&
                          (!IsNear(AllSegList[cnt][nowcnetseg + 6].MyCol, SegCol))
                          )
                        {
                            Show7Seg += "1";
                        }
                        //2
                        else if (
                          (IsNear(AllSegList[cnt][nowcnetseg + 0].MyCol, SegCol)) &&
                          (!IsNear(AllSegList[cnt][nowcnetseg + 1].MyCol, SegCol)) &&
                          (!IsNear(AllSegList[cnt][nowcnetseg + 2].MyCol, SegCol)) &&
                          (!IsNear(AllSegList[cnt][nowcnetseg + 3].MyCol, SegCol)) &&
                          (!IsNear(AllSegList[cnt][nowcnetseg + 4].MyCol, SegCol)) &&
                          (!IsNear(AllSegList[cnt][nowcnetseg + 5].MyCol, SegCol)) &&
                          (IsNear(AllSegList[cnt][nowcnetseg + 6].MyCol, SegCol))
                          )
                        {
                            Show7Seg += "2";
                        }
                        //3
                        else if (
                          (IsNear(AllSegList[cnt][nowcnetseg + 0].MyCol, SegCol)) &&
                          (IsNear(AllSegList[cnt][nowcnetseg + 1].MyCol, SegCol)) &&
                          (!IsNear(AllSegList[cnt][nowcnetseg + 2].MyCol, SegCol)) &&
                          (!IsNear(AllSegList[cnt][nowcnetseg + 3].MyCol, SegCol)) &&
                          (!IsNear(AllSegList[cnt][nowcnetseg + 4].MyCol, SegCol)) &&
                          (!IsNear(AllSegList[cnt][nowcnetseg + 5].MyCol, SegCol)) &&
                          (!IsNear(AllSegList[cnt][nowcnetseg + 6].MyCol, SegCol))
                          )
                        {
                            Show7Seg += "3";
                        }
                        //4
                        else if (
                          (!IsNear(AllSegList[cnt][nowcnetseg + 0].MyCol, SegCol)) &&
                          (IsNear(AllSegList[cnt][nowcnetseg + 1].MyCol, SegCol)) &&
                          (IsNear(AllSegList[cnt][nowcnetseg + 2].MyCol, SegCol)) &&
                          (!IsNear(AllSegList[cnt][nowcnetseg + 3].MyCol, SegCol)) &&
                          (IsNear(AllSegList[cnt][nowcnetseg + 4].MyCol, SegCol)) &&
                          (!IsNear(AllSegList[cnt][nowcnetseg + 5].MyCol, SegCol)) &&
                          (!IsNear(AllSegList[cnt][nowcnetseg + 6].MyCol, SegCol))
                          )
                        {
                            Show7Seg += "4";
                        }
                        //5
                        else if (
                          (!IsNear(AllSegList[cnt][nowcnetseg + 0].MyCol, SegCol)) &&
                          (IsNear(AllSegList[cnt][nowcnetseg + 1].MyCol, SegCol)) &&
                          (!IsNear(AllSegList[cnt][nowcnetseg + 2].MyCol, SegCol)) &&
                          (!IsNear(AllSegList[cnt][nowcnetseg + 3].MyCol, SegCol)) &&
                          (!IsNear(AllSegList[cnt][nowcnetseg + 4].MyCol, SegCol)) &&
                          (IsNear(AllSegList[cnt][nowcnetseg + 5].MyCol, SegCol)) &&
                          (!IsNear(AllSegList[cnt][nowcnetseg + 6].MyCol, SegCol))
                          )
                        {
                            Show7Seg += "5";
                        }
                        //6
                        else if (
                          (!IsNear(AllSegList[cnt][nowcnetseg + 0].MyCol, SegCol)) &&
                          (!IsNear(AllSegList[cnt][nowcnetseg + 1].MyCol, SegCol)) &&
                          (!IsNear(AllSegList[cnt][nowcnetseg + 2].MyCol, SegCol)) &&
                          (!IsNear(AllSegList[cnt][nowcnetseg + 3].MyCol, SegCol)) &&
                          (!IsNear(AllSegList[cnt][nowcnetseg + 4].MyCol, SegCol)) &&
                          (IsNear(AllSegList[cnt][nowcnetseg + 5].MyCol, SegCol)) &&
                          (!IsNear(AllSegList[cnt][nowcnetseg + 6].MyCol, SegCol))
                          )
                        {
                            Show7Seg += "6";
                        }
                        //7
                        else if (
                          (!IsNear(AllSegList[cnt][nowcnetseg + 0].MyCol, SegCol)) &&
                          (!IsNear(AllSegList[cnt][nowcnetseg + 2].MyCol, SegCol)) &&
                          (IsNear(AllSegList[cnt][nowcnetseg + 3].MyCol, SegCol)) &&
                          (IsNear(AllSegList[cnt][nowcnetseg + 1].MyCol, SegCol)) &&
                          (IsNear(AllSegList[cnt][nowcnetseg + 4].MyCol, SegCol)) &&
                          (!IsNear(AllSegList[cnt][nowcnetseg + 5].MyCol, SegCol)) &&
                          (!IsNear(AllSegList[cnt][nowcnetseg + 6].MyCol, SegCol))
                          )
                        {
                            Show7Seg += "7";
                        }
                        //8
                        else if (
                          (!IsNear(AllSegList[cnt][nowcnetseg + 0].MyCol, SegCol)) &&
                          (!IsNear(AllSegList[cnt][nowcnetseg + 1].MyCol, SegCol)) &&
                          (!IsNear(AllSegList[cnt][nowcnetseg + 2].MyCol, SegCol)) &&
                          (!IsNear(AllSegList[cnt][nowcnetseg + 3].MyCol, SegCol)) &&
                          (!IsNear(AllSegList[cnt][nowcnetseg + 4].MyCol, SegCol)) &&
                          (!IsNear(AllSegList[cnt][nowcnetseg + 5].MyCol, SegCol)) &&
                          (!IsNear(AllSegList[cnt][nowcnetseg + 6].MyCol, SegCol))
                          )
                        {
                            Show7Seg += "8";
                        }
                        //9
                        else if (
                          (!IsNear(AllSegList[cnt][nowcnetseg + 0].MyCol, SegCol)) &&
                          (IsNear(AllSegList[cnt][nowcnetseg + 1].MyCol, SegCol)) &&
                          (!IsNear(AllSegList[cnt][nowcnetseg + 2].MyCol, SegCol)) &&
                          (!IsNear(AllSegList[cnt][nowcnetseg + 3].MyCol, SegCol)) &&
                          (!IsNear(AllSegList[cnt][nowcnetseg + 4].MyCol, SegCol)) &&
                          (!IsNear(AllSegList[cnt][nowcnetseg + 5].MyCol, SegCol)) &&
                          (!IsNear(AllSegList[cnt][nowcnetseg + 6].MyCol, SegCol))
                          )
                        {
                            Show7Seg += "9";
                        }

                        //.
                        if (!IsNear(AllSegList[cnt][nowcnetseg + 7].MyCol, SegCol))
                        {
                            Show7Seg += ".";
                        }


                        //label1.Text = Show7Seg;
                    }
                    // }
                    //AnsList.Add(Show7Seg);
                    ShowAns.Items.Add(Show7Seg);

                    try
                    {
                        SaveDataOnCsv(Convert.ToDouble(Show7Seg), "7セグ:"+ (cnt+ 1).ToString());
                    }
                    catch
                    {

                    }
                    
                }

            }
        }

        private void LoopCheck_Tick(object sender, EventArgs e)
        {
            Check7Seg();
        }

        private void LoopOnOff_Click(object sender, EventArgs e)
        {
            if (!LoopCheck.Enabled)
            {
                LoopCheck.Enabled = true;
            }
            else
            {
                LoopCheck.Enabled = false;
            }
        }

    

        private void statusCheck_Tick(object sender, EventArgs e)
        {
            if (LoopCheck.Enabled)
            {
                LoopOnOff.BackColor = Color.CornflowerBlue;
            }
            else
            {
                LoopOnOff.BackColor = Color.Red;
            }

            if (ShowCol.Items.Count >= 1)
            {
                string[] GetColStr = ShowCol.SelectedItem.ToString().Split(',', ']');
                int[] GetCol = new int[3];
                for(int i = 0; i < 3; i++)
                {
                    string[] GetC = GetColStr[i+1].Split('=',']');
                    GetCol[i] = Convert.ToInt32(GetC[1]);
                }
                ShowCol.BackColor = Color.FromArgb(255, GetCol[0], GetCol[1], GetCol[2]);
            }

        }

        private void GetCam_Tick(object sender, EventArgs e)
        {
            if (CameraImg != null)
            {
                if (!AnaOr7Seg.Checked)
                {
                    SevenSegPic.Image = CameraImg;
                }
                else
                {
                    SevenSegPic.Image = IsNearWhite(CameraImg);
                }
            }

            GetGamma = ((float)GammaBar.Value) / 100;
            // スライドの値を取得
            //double dblAngle = (double)trackBar1.Value;

            //// PictureBox描画処理
            //DrawPictureBox(dblAngle);
        }

        private void SetAnalogPos_Click(object sender, EventArgs e)
        {
            if (!StartAnalogSet)
            {
                StartAnalogSet = true;
            }
        }

        private void AnalogCheck_Click(object sender, EventArgs e)
        {
            CheckAnaLog();
        }

        private void CheckAnaLog()
        {
            int w = AllAnaBox[0].Width / 2;
            int h = AllAnaBox[0].Height / 2;
            //int AB, AC, BC;
            //AB =(int) GetLong(AllAnaBox[0].Location, AllAnaBox[1].Location);
            //AC =(int) GetLong(AllAnaBox[0].Location, AllAnaBox[2].Location);
            //BC = (int)GetLong(AllAnaBox[1].Location, AllAnaBox[2].Location);

            System.Drawing.Point Pos1 = new System.Drawing.Point(AllAnaBox[0].Location.X + w, AllAnaBox[0].Location.Y + h);
            System.Drawing.Point Pos2 = new System.Drawing.Point(AllAnaBox[1].Location.X + w, AllAnaBox[1].Location.Y + h);
            System.Drawing.Point Pos3 = new System.Drawing.Point(AllAnaBox[2].Location.X + w, AllAnaBox[2].Location.Y + h);
            //System.Drawing.Point Pos4 = new System.Drawing.Point(AllAnaBox[3].Location.X + w, AllAnaBox[3].Location.Y + h);

            //int AD= (int)GetLong(Pos1, Pos4);

            //int AngleAB = (int)GetAngle(AllAnaBox[0].Location, AllAnaBox[1].Location);
            //int AngleAC = (int)GetAngle(AllAnaBox[0].Location, AllAnaBox[2].Location);


            int AnalogAngle;

            //AnalogAngle = 180 - AngleAB - AngleAC;

            AnalogAngle = (int) GetIsoscelesAngle(Pos1, Pos2, Pos3);
            //double angel = Math.Tan;
            //PointOneAngle = (180 - PointOneAngle - 90)*2;

            System.Drawing.Point pos = GetPos(Pos1, Pos2, 0);

            
            //int a = 0;


            // 点P・Qの座標を設定
            m_P = Pos1;
            m_Q = Pos2;
            m_O = new System.Drawing.Point();
            m_O2 = new System.Drawing.Point();

            LINE = ((int)Math.Sqrt((Math.Pow(m_Q.X - m_P.X, 2) + Math.Pow(m_Q.Y - m_P.Y, 2)))/20)*17;
            LINE2 = ((int)Math.Sqrt((Math.Pow(m_Q.X - m_P.X, 2) + Math.Pow(m_Q.Y - m_P.Y, 2))));
           

            int angel=(int)GetIAngel(Pos1, Pos2);

            int starPosAngle = angel + 180;

            Bitmap BackImage = new Bitmap(IsNearWhite(SevenSegPic.Image));

            for (int i = 0; i < AnalogAngle; i++)
            {
                GetOPos(starPosAngle+i);
                //Get7Pic = SevenSegPic.Image;
                
                
                int r, g, b;

                r = BackImage.GetPixel(m_O.X,m_O.Y).R;
                g = BackImage.GetPixel(m_O.X, m_O.Y).G;
                b = BackImage.GetPixel(m_O.X, m_O.Y).B;

                Color col = Color.FromArgb(255, r, g, b);

                //AnalogBox boxx = new();
                //SevenSegPic.Controls.Add(boxx);
                //boxx.Location = m_O;
                //boxx.BackColor = Color.Black;
                //boxx.Width = 3;
                //boxx.Height = 3;
                //boxx.pictureBox1.BackColor = Color.Blue;



                if (IsNearForAnalog(col, AnalogColBox.BackColor))
                {
                    //AnalogBox box = new();
                    //SevenSegPic.Controls.Add(box);
                    //box.Location = new System.Drawing.Point(m_O.X, m_O.Y);
                    //box.BackColor = Color.Black;
                    //box.Width = 10;
                    //box.Height = 10;
                    //box.pictureBox1.BackColor = Color.Purple;
                    break;

                }

            }

            //SevenSegPic.Controls.Add(box);
            //box.Location = m_O2;
            //box.BackColor = Color.Black;
            //box.Width = 10;
            //box.Height = 10;
            //box.pictureBox1.BackColor = Color.Purple;


            int Anaangel = 180 - (int)GetIsoscelesAngle(Pos1, Pos2, m_O2);

            //SevenSegPic.Controls.RemoveAt(3);

            

            CheckPointAngle.Clear();

            for (int i = 0; i < CheckPointList.Count; i++)
            {
               
                System.Drawing.Point Pos = new System.Drawing.Point(CheckPointList[i].Location.X + w, CheckPointList[i].Location.Y + h);
                int angle=180- (int)GetIsoscelesAngle(Pos1, Pos2, Pos);
                CheckPointAngle.Add(angle);

            }
            //PointList.Clear();
            //PointList.Add(25);
            //PointList.Add(50);
            //PointList.Add(75);
            if (PointList.Count == MaxPoint)
            {

                for (int i = 0; i < PointList.Count; i++)
                {
                    if (i == 0)
                    {
                        if (Anaangel <= CheckPointAngle[i] && Anaangel >= 0)
                        {
                            if (Anaangel + 2 >= CheckPointAngle[i] && Anaangel - 2 <= CheckPointAngle[i])
                            {
                                AnaAnswer = PointList[i];
                            }
                            else
                            {
                                AnaAnswer = (int)(((double)PointList[i] / (double)CheckPointAngle[i]) * Anaangel);
                            }
                        }
                    }

                    else
                    {
                        if (Anaangel <= CheckPointAngle[i] && Anaangel > CheckPointAngle[i - 1])
                        {
                            if (Anaangel + 2 >= CheckPointAngle[i] && Anaangel - 2 <= CheckPointAngle[i])
                            {
                                AnaAnswer = PointList[i];
                            }
                            else
                            {
                                int range = PointList[i] - PointList[i - 1];
                                double Onefor = (double)range / (double)(CheckPointAngle[i] - CheckPointAngle[i - 1]);
                                double plusAngle = (double)(Anaangel - CheckPointAngle[i - 1]);
                                AnaAnswer = (int)(Math.Floor(Onefor * plusAngle)) + PointList[i - 1];
                            }

                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("ポイント設置を完成してください。");
            }

            label2.Text = AnaAnswer.ToString();

            SaveDataOnCsv(AnaAnswer, "アナログ");

        }

        private double GetLong(System.Drawing.Point a, System.Drawing.Point b)
        {
            double ans;

            ans = Math.Sqrt(Math.Pow(a.X - b.X,2) + Math.Pow(a.Y - b.Y,2));

            return ans;
           
        }

        private double GetAngle(System.Drawing.Point a,System.Drawing.Point b)
        {
            double w;
            double h;

            w =Math.Sqrt(Math.Pow(a.X - b.X,2));
            h = Math.Sqrt(Math.Pow(a.Y - b.Y,2));

            double ans = Math.Atan(w / h) * 180.0 / Math.PI;

            return ans;
        }

        // 二等辺三角形
        private double GetIsoscelesAngle(System.Drawing.Point a, System.Drawing.Point b, System.Drawing.Point c)
        {
            double ans;

            System.Drawing.Point Center = new System.Drawing.Point((b.X + c.X) / 2, (b.Y + c.Y) / 2);

            double w;
            double h;

            // w = Math.Sqrt(Math.Pow(a.X-Center.X,2)+ Math.Pow(a.Y - Center.Y, 2)); 
            w = GetLong(a, b);
            //h = Math.Sqrt(Math.Pow(b.X - Center.X, 2) + Math.Pow(b.Y - Center.Y, 2));
            h = GetLong(b, Center);
            //ans = (180-(Math.Atan(w / h) * 180.0 / Math.PI)-90)*2;
            ans = (Math.Acos(h / w) * 180.0 / Math.PI) * 2;

            return ans;
        }

        private double GetIAngel(System.Drawing.Point a, System.Drawing.Point b)
        {
            double ans;

            double w;
            double h;

            System.Drawing.Point Center = new System.Drawing.Point(b.X,a.Y);
            w = GetLong(a, b);
            h = GetLong(a, Center);

            ans = (Math.Acos(h / w) * 180.0 / Math.PI);

            return ans;

        }

        private void AnalogReset_Click(object sender, EventArgs e)
        {
            int cnt = SevenSegPic.Controls.Count;

            for (int i = 0; i < cnt; i++)
            {
                SevenSegPic.Controls.RemoveByKey("AnalogBox");
            }

            StartAnalogSet = false;

           // CntStandPos = 0;
            AllAnaBox.Clear();

            CheckPointList.Clear();

        }

        private void AnalogCol_Click(object sender, EventArgs e)
        {
            //SetAnalogCol = true;
            AnalogColBox.BackColor = Color.Black;

        }

        private bool IsNearForAnalog(Color aObj, Color bObj)
        {
            int ColLike = Convert.ToInt32(AnaNearCol.Text);

            if (aObj.R <= bObj.R + ColLike && aObj.R >= bObj.R - ColLike &&
                aObj.G <= bObj.G + ColLike && aObj.G >= bObj.G - ColLike &&
                aObj.B <= bObj.B + ColLike && aObj.B >= bObj.B - ColLike)
            {

                return true;

            }
            else
            {

                return false;

            }

        }

        private System.Drawing.Point GetPos(System.Drawing.Point a, System.Drawing.Point b,int angle)
        {
            System.Drawing.Point ans = new System.Drawing.Point();

            double LINE = GetLong(a, b);

            double dblRadian = (Math.PI * (double)2) * (angle / (double)360);
            ans.X = (Int32)(Math.Cos(dblRadian) * LINE) + a.X;
            ans.Y = (Int32)(Math.Sin(dblRadian) * LINE) + a.Y;

            return ans;
        }


        private void GetOPos(double dblAngle)
        {
            //LINE = (int)Math.Sqrt((Math.Pow(m_P.X - m_Q.X, 2) + Math.Pow(m_P.Y - m_Q.Y, 2)));

            //----< ポイント >-----------------------------------------------
            double dblRadian = (Math.PI * (double)2) * (dblAngle / (double)360);
            m_O.X = (Int32)(Math.Cos(dblRadian) * (double)LINE) + m_P.X;
            m_O.Y = (Int32)(Math.Sin(dblRadian) * (double)LINE) + m_P.Y;

            m_O2.X = (Int32)(Math.Cos(dblRadian) * (double)LINE2) + m_P.X;
            m_O2.Y = (Int32)(Math.Sin(dblRadian) * (double)LINE2) + m_P.Y;
            //---------------------------------------------------------------
        }

        private Bitmap IsNearWhite(Image Cmap)
        {
            Bitmap map = new Bitmap(Cmap);

            int w = map.Width;
            int h = map.Height;
            //int r, g, b;
            int Light = LightBar.Value;
            //int downsome = 12;

            //using (var src = BitmapConverter.ToMat(map))
            //using (var hsv = new Mat())
            //{

            //    Cv2.CvtColor(src, hsv, ColorConversionCodes.BGR2RGBA);

            //    var channels = Cv2.Split(hsv);

            //    map = BitmapConverter.ToBitmap(hsv);

            //}

            byte[,] data = new byte[w, h];
            byte[,] brightdata = new byte[w, h];


            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    data[i, j] = (byte)((map.GetPixel(i, j).R + map.GetPixel(i, j).G + map.GetPixel(i, j).B) / 3);

                    if (data[i, j] + Light >= 256)
                    {
                        brightdata[i, j] = 255;
                    }
                    else if (data[i, j] + Light < 0)
                    {
                        brightdata[i, j] = 0;
                    }
                    else
                    {
                        brightdata[i, j] = (byte)(data[i, j] + Light);
                    }

                    map.SetPixel(i, j, Color.FromArgb(brightdata[i, j], brightdata[i, j], brightdata[i, j]));

                }

            }


            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {

                    if (map.GetPixel(i, j).R >= 135 && map.GetPixel(i, j).G >= 135 && map.GetPixel(i, j).B >= 135)
                    {
                        map.SetPixel(i, j, Color.White);
                    }
                    //else if (map.GetPixel(i, j).R >= 100 && map.GetPixel(i, j).G >= 100 && map.GetPixel(i, j).B >= 100)
                    //{
                    //    map.SetPixel(i, j, Color.Gray);
                    //}
                    else
                    {
                        map.SetPixel(i, j, Color.Black);
                    }
                }
            }

            return map;

        }

        private void SetCheckPoint_Click(object sender, EventArgs e)
        {
            StartSetPoint = true;
            MaxPoint = PointListBox.Items.Count;// Convert.ToInt32(CheckPointNum.Text);
            //CntPoint = 0;
        }

        private void AddPoint_Click(object sender, EventArgs e)
        {
            PointListBox.Items.Add(PontAddTex.Text);
            PointList.Add(Convert.ToInt32(PontAddTex.Text));
            //CntPoint++;
            CheckPointNum.Text = PointListBox.Items.Count.ToString();
        }

        private void ClearPointBox_Click(object sender, EventArgs e)
        {
            PointListBox.Items.Clear();
            PointList.Clear();
            //CntPoint = 0;
            CheckPointNum.Text = PointListBox.Items.Count.ToString();
        }

        private void Gamma_Tick(object sender, EventArgs e)
        {
            ////自動ガンマ調整
            //if (StarGamamCheck)
            //{
            //    //カメラ画像
            //    Bitmap bmp = new Bitmap(img.ToBitmap());

            //    for (int i = 0; i < img.Width; i++)
            //    {
            //        //ピクセル単位でRGB値を取得
            //        for (int j = 0; j < img.Height; j++)
            //        {
            //            NowR.Add(bmp.GetPixel(i, j).R);
            //            NowG.Add(bmp.GetPixel(i, j).G);
            //            NowB.Add(bmp.GetPixel(i, j).B);
            //        }
            //    }


            //    //全画素平均RGB値を取得
            //    int AvgR = (int)NowR.Average();
            //    int AvgG = (int)NowG.Average();
            //    int AvgB = (int)NowB.Average();

            //    //RGB値の平均
            //    double Avg = (((double)AvgR + (double)AvgG + (double)AvgB) / 3.0) / 100.0;
            //    double GetAvg = Math.Round(Avg, 2, MidpointRounding.AwayFromZero);
            //}
        }

        private void SaveDataOnCsv(double ans,string ObjName=null)
        {
            //今日の日を取得
            DateTime dt = new DateTime();
            dt = DateTime.Now;

            //if (DataName.Text == "")
            //{
            //    DataName.Text = "監視データ";
            //}

            //データ名
            string Path = "SaveData/監視データ.csv";
            StreamWriter sw;

            //データ存在確認

            //存在してない
            if (!File.Exists(Path))
            {
                sw = new StreamWriter(Path, false, Encoding.GetEncoding("utf-8"));

                sw.WriteLine("時間" +
                    "," +
                    "装置名" +
                    "," +
                    "判定結果");

                string Print="";

                Print += DateTime.Now.ToString();
                //今の時間を書く
               // sw.WriteLine(DateTime.Now);

                if (ObjName != null)
                {
                    Print += ",";
                    Print += ObjName;
                    Print += ",";
                }
                else
                {
                    Print += ",";
                    Print += " ";
                    Print += ",";
                    //sw.WriteLine(" ");
                }
                Print += ans;

                sw.WriteLine(Print);

            }

            //既に保存データ存在の場合
            else
            {
                //ファイル開く
                sw = File.AppendText(Path);
                //現在時間を書く

                string Print = "";

                Print += DateTime.Now.ToString();
                //今の時間を書く
                // sw.WriteLine(DateTime.Now);

                if (ObjName != null)
                {
                    Print += ",";
                    Print += ObjName;
                    Print += ",";

                }
                else
                {
                    Print += ",";
                    Print += " ";
                    Print += ",";
                    //sw.WriteLine(" ");
                }
                Print += ans;

                sw.WriteLine(Print);

            }
            //保存終了
            sw.Close();
        }

        private void LightBar_Scroll(object sender, EventArgs e)
        {
            LightBarNum.Text = LightBar.Value.ToString(); ;
        }
    }
}
