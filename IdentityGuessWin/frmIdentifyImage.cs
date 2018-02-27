using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdentityGuessWin
{
    public partial class frmIdentifyImage : Form
    {
        const int timerTick = 3000; const int moveInc = 30; const int winPoints = 20; const int lossPoints = -5; const int totalRound = 10;
        Random random = new Random();
        Dictionary<Image, Label> imageList = new Dictionary<Image, Label>();
        int currentRound; int lastIndex = -1;
        bool enableTimer;

        public frmIdentifyImage()
        {
            InitializeComponent();
        }

        private void frmIdentifyImage_Load(object sender, EventArgs e)
        {
            lblChinese.BackgroundImageLayout = ImageLayout.Stretch;
            lblJapanese.BackgroundImageLayout = ImageLayout.Stretch;
            lblKorean.BackgroundImageLayout = ImageLayout.Stretch;
            lblThai.BackgroundImageLayout = ImageLayout.Stretch;

            //load images into dictionary
            this.imageList.Add(Properties.Resources.japanese1, lblJapanese);
            this.imageList.Add(Properties.Resources.japanese2, lblJapanese);
            this.imageList.Add(Properties.Resources.japanese3, lblJapanese);
            this.imageList.Add(Properties.Resources.korean1, lblKorean);
            this.imageList.Add(Properties.Resources.korean2, lblKorean);
            this.imageList.Add(Properties.Resources.korean3, lblKorean);
            this.imageList.Add(Properties.Resources.chinese1, lblChinese);
            this.imageList.Add(Properties.Resources.chinese2, lblChinese);
            this.imageList.Add(Properties.Resources.chinese3, lblChinese);
            this.imageList.Add(Properties.Resources.thai1, lblThai);
            this.imageList.Add(Properties.Resources.thai2, lblThai);
            this.imageList.Add(Properties.Resources.thai3, lblThai);

            //Set timer interval in accordance to form height so that pic movement takes 3 seconds
            tim.Interval = Convert.ToInt32(Convert.ToDouble(timerTick) / (Convert.ToDouble(this.Height + (pic.Height * 2)) / Convert.ToDouble(moveInc)));
            enableTimer = true;
            tim.Enabled = true;
        }

        private void tim_Tick(object sender, EventArgs e)
        {
            if (enableTimer)
            {
                pic.Top += moveInc;
                if (pic.Bottom > this.Bottom || pic.Image == null)
                {
                    pic.Top = 0 - pic.Height;
                    pic.Left = (this.Width / 2) - (pic.Width / 2);
                    int randIndex = lastIndex;
                    //to avoid same random index as last picture.
                    while (randIndex == lastIndex)
                    {
                        randIndex = random.Next(0, this.imageList.Count);
                    }
                    lastIndex = randIndex;
                    pic.Image = this.imageList.ElementAt(randIndex).Key;
                    currentRound++;
                    if (currentRound > totalRound)
                    {
                        currentRound = 0;
                        tim.Enabled = false;
                        if (MessageBox.Show(string.Format("Your total score: {0}. Play Again?", lblPoints.Text), "Game Over", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            lblPoints.Text = "0";
                            tim.Enabled = true;
                            pic.Image = null;
                        }
                        else
                        {
                            this.Close();
                        }
                    }
                }

            }
        }

        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            //Disable picture movement on mouse click.
            if (e.Button == MouseButtons.Left)
            {
                enableTimer = false;
                pic.DoDragDrop(sender, DragDropEffects.Move);
            }
        }

        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            //Re-enable timer and set picture blank so that it restarts from top.
            if (e.Button == MouseButtons.Left)
            {
                pic.Image = null;
                enableTimer = true;
            }
        }

        private void lbl_DragLeave(object sender, EventArgs e)
        {
            //Upon draging it will check if the answer is right or wrong.
            Control ctl = sender as Control;
            Image selectedImage = pic.Image;
            if (selectedImage != null)
            {
                Label rightLabel = this.imageList[selectedImage];

                if (ctl == rightLabel)
                {
                    lblPoints.Text = (Convert.ToInt32(lblPoints.Text) + winPoints).ToString();
                }
                else
                {
                    lblPoints.Text = (Convert.ToInt32(lblPoints.Text) + lossPoints).ToString();
                }

                pic.Image = null;

                // image fading in concurrently in order to avoid primary thread blocking. 
                Task.Run(() =>
                {
                    for (float i = 0F; i < 1F; i += .10F)
                    {
                        rightLabel.BackgroundImage = changeOpacity(selectedImage, i);
                        Thread.Sleep(100);
                    }

                    rightLabel.BackgroundImage = null;

                    enableTimer = true;
                });
            }
        }

        private Bitmap changeOpacity(Image img, float opacityvalue)
        {
            Bitmap result = null;
            if (img != null)
            {
                result = new Bitmap(img.Width, img.Height); // Determining Width and Height of Source Image
                using (Graphics graphics = Graphics.FromImage(result))
                {
                    ColorMatrix colorMatrix = new ColorMatrix { Matrix33 = opacityvalue };
                    using (ImageAttributes imgAttribute = new ImageAttributes())
                    {
                        imgAttribute.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                        graphics.DrawImage(img, new Rectangle(0, 0, result.Width, result.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, imgAttribute);
                    }
                }
            }
            return result;
        }
    }
}
