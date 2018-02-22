using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace IdentityGuessWin
{
    public partial class frmIdentifyImage : Form
    {
        const int timerTick = 3000; //milliseconds
        const int moveInc = 30;
        const int winPoints = 20;
        const int lossPoints = -5;
        Random random = new Random();
        Dictionary<Image, string> imageList = new Dictionary<Image, string>();

        public frmIdentifyImage()
        {
            InitializeComponent();
        }

        private void frmIdentifyImage_Load(object sender, EventArgs e)
        {
            //load images into dictionary
            this.imageList.Add(Properties.Resources.japanese1, "Japanese");
            this.imageList.Add(Properties.Resources.japanese2, "Japanese");
            this.imageList.Add(Properties.Resources.japanese3, "Japanese");

            this.imageList.Add(Properties.Resources.korean1, "Korean");
            this.imageList.Add(Properties.Resources.korean2, "Korean");
            this.imageList.Add(Properties.Resources.korean3, "Korean");

            this.imageList.Add(Properties.Resources.chinese1, "Chinese");
            this.imageList.Add(Properties.Resources.chinese2, "Chinese");
            this.imageList.Add(Properties.Resources.chinese3, "Chinese");

            this.imageList.Add(Properties.Resources.thai1, "Thai");
            this.imageList.Add(Properties.Resources.thai2, "Thai");
            this.imageList.Add(Properties.Resources.thai3, "Thai");

            //Set timer interval in accordance to form height so that pic movement takes 3 seconds
            tim.Interval = Convert.ToInt32(Convert.ToDouble(timerTick) / (Convert.ToDouble(this.Height + (pic.Height * 2)) / Convert.ToDouble(moveInc)));
            tim.Enabled = true;
        }

        private void tim_Tick(object sender, EventArgs e)
        {
            pic.Top += moveInc;

            if (pic.Bottom > this.Bottom || pic.Image == null)
            {
                pic.Top = 0 - pic.Height;
                pic.Left = (this.Width / 2) - (pic.Width / 2);
                int randIndex = random.Next(0, this.imageList.Count);
                pic.Image = this.imageList.ElementAt(randIndex).Key;
            }
        }

        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            //Disable picture movement on mouse click.
            if (e.Button == MouseButtons.Left)
            {
                tim.Enabled = false;
                var dropEffect = pic.DoDragDrop(sender, DragDropEffects.Move);
            }
        }

        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            //Re-enable timer and set picture blank so that it restarts from top.
            if (e.Button == MouseButtons.Left)
            {
                pic.Image = null;
                tim.Enabled = true;
            }
        }

        private void lbl_DragLeave(object sender, EventArgs e)
        {
            //Upon draging it will check if the answer is right or wrong.

            Control ctl = sender as Control;

            if (ctl.Text == this.imageList[pic.Image])
            {
                lblPoints.Text = (Convert.ToInt32(lblPoints.Text) + winPoints).ToString();
            }
            else
            {
                lblPoints.Text = (Convert.ToInt32(lblPoints.Text) + lossPoints).ToString();
            }

            pic.Image = null;
            tim.Enabled = true;
        }
    }
}
