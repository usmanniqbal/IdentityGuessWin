using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdentityGuessWin
{
    public partial class frmIdentifyImage : Form
    {
        const int timerTick = 3; //seconds
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

            pic.Top = 0 - pic.Height;
        }

        private void tim_Tick(object sender, EventArgs e)
        {
            pic.Top += moveInc;

            if(pic.Bottom > this.Bottom)
            {
                pic.Top = 0 - pic.Height;
                int randIndex = random.Next(0, this.imageList.Count);
                pic.Image = this.imageList.ElementAt(randIndex).Key;
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Control ctl = sender as Control;

            if(ctl.Text == this.imageList[pic.Image])
            {
                lblPoints.Text = (Convert.ToInt32(lblPoints.Text) + winPoints).ToString();
            }
            else
            {
                lblPoints.Text = (Convert.ToInt32(lblPoints.Text) + lossPoints).ToString();
            }
        }
    }
}
