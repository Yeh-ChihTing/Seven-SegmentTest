using System;
using System.Collections.Generic;
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

        private Mybox box = new();

        private bool StarChooseCol = false;

        //int cntCol = 0;

        private Mat img = new();
        private Image Get7Pic;

        private bool sevensegadd = false;
        private int SegPointCnt = 0;

        private bool FirstColSel = true;

       // private bool FirstAdd = true;

        //private int cntNumOfSevenSeg = 0;


        private List<sevensegBox> SevenCList = new ();

        private List<List<sevensegBox>> AllSegList = new();

        // private List<string> AnsList = new();
        private Image CameraImg { get; set; }


        private void MainScene_Load(object sender, EventArgs e)
        {
            PerScreen.SelectedIndex = 0;
           //Mybox box = new Mybox();
           // SevenSegPic.Controls.Add(box);

            //box.Size = new System.Drawing.Size(80, 80);

            panel1.Controls.Add(SevenSegPic);


            /// <summary>
            /// カメラ画面取得
            /// </summary>
            VideoCapture vc = new();


           
            /// <summary>
            /// カメラの稼働処理
            /// </summary>
            try
            {

                _=Task.Run(() =>
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
            if (box.NowAdd7seg == false)
            {
                //box.NowAdd7seg = true;
            }

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


                this.Cursor = Cursors.Hand;
                SegOnCol.BackColor = Color.FromArgb(color.R, color.G, color.B);
               

                //cntCol = 0;
               
               

            }
        }

   
        private void SevenSegPic_MouseDown(object sender, MouseEventArgs e)
        {
            //string cnt = digitTex.Text;
            int maxSeg = Convert.ToInt32(digitTex.Text) * 8;
            
            if (StarChooseCol)
            {
                 StarChooseCol = false;
                this.Cursor = Cursors.Default;
                ShowCol.Items.Add(SegOnCol.BackColor);
                if (FirstColSel)
                {
                    ShowCol.SelectedIndex = 0;
                    FirstColSel = false;
                }
            }


           
            

            if (sevensegadd == true)
            {
              

                if (SegPointCnt < maxSeg)
                {
                                     
                    sevensegBox box = new();
                    //panel1.Controls[0].Controls.Add(box);
                    SevenSegPic.Controls.Add(box);
                    box.Height = 4;// SevenSegPic.Height / 80;
                    box.Width = 8;// SevenSegPic.Width / 80;
                    box.Location = e.Location;
                    //MyNumber.Text = Add7SegCnt.ToString();
                    SegPointCnt++;
                    SevenCList.Add(box);

                    if (SegPointCnt == maxSeg)
                    {
                        List<sevensegBox> Sbox = new();
                        for (int i = 0; i < SevenCList.Count; i++)
                        {
                            Sbox.Add(SevenCList[i]);
                        }
                        
                        //cntNumOfSevenSeg++;
                        SegPointCnt = 0;
                        AllSegList.Add(Sbox);
                        //SevenCList.Clear();

                        SevenCList.Clear();

                        sevensegadd = false;
                    }


                }
            
            }

        }

        private void Set7ToBack_Click(object sender, EventArgs e)
        {
            //Get7Pic = SevenSegPic.Image;

            //Bitmap BackImage = (Bitmap)Get7Pic.Clone();
            //int r, g, b;
            //if (SevenCList.Count == 8)
            //{
               
            //    for (int i = 0; i < 8; i++)                   
            //    {
                   
            //        r = BackImage.GetPixel(SevenCList[i].Location.X, SevenCList[i].Location.Y).R;
            //        g = BackImage.GetPixel(SevenCList[i].Location.X, SevenCList[i].Location.Y).G;
            //        b = BackImage.GetPixel(SevenCList[i].Location.X, SevenCList[i].Location.Y).B;
            //         Color col = Color.FromArgb(255,r,g,b);
            //        SevenCList[i].setCol(col);
            //    }



            //    CheackCol.BackColor = SevenCList[0].MyCol;
            //    //label1.Text = CheackCol.BackColor.ToString();
            //}

            //for (int i = 0; i < Convert.ToInt32(digitTex.Text) * 8; i++)
            //{

            //    r = BackImage.GetPixel(SevenCList[i].Location.X, SevenCList[i].Location.Y).R;
            //    g = BackImage.GetPixel(SevenCList[i].Location.X, SevenCList[i].Location.Y).G;
            //    b = BackImage.GetPixel(SevenCList[i].Location.X, SevenCList[i].Location.Y).B;
            //    Color col = Color.FromArgb(255, r, g, b);
            //    SevenCList[i].setCol(col);
            //}


        }

        private void ClearAllSeg_Click(object sender, EventArgs e)
        {
            //Convert.ToInt32(digitTex.Text) = 0;


            SevenSegPic.Controls.Clear();
            

           // SevenCList.Clear();
            SegPointCnt = 0;

            AllSegList.Clear();

            FirstColSel = true;

            DialogResult result=MessageBox.Show("色もリセットします？","", MessageBoxButtons.YesNo);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {

                ShowCol.Items.Clear();
                ShowCol.Text = "";
                ShowCol.BackColor = default;
            }
        }

       
        private void Get7Seg_Click(object sender, EventArgs e)
        {

            Check7Seg();

        }

        private bool IsNear(Color aObj, Color bObj)
        {
            int ColLike = Convert.ToInt32(ColNearTex.Text);

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
            string Show7Seg = "";
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
                

                string[] GetColStr = ShowCol.Items[cnt].ToString().Split(',', ']');
                int[] GetCol = new int[3];
                for (int i = 0; i < 3; i++)
                {
                    string[] GetC = GetColStr[i + 1].Split('=', ']');
                    GetCol[i] = Convert.ToInt32(GetC[1]);
                }
                Color SegCol = Color.FromArgb(255, GetCol[0], GetCol[1], GetCol[2]);


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
            SevenSegPic.Image = CameraImg;
        }
    }
}
