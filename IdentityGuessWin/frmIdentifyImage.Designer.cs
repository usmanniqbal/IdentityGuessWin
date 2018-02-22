namespace IdentityGuessWin
{
    partial class frmIdentifyImage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tim = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.lblJapanese = new System.Windows.Forms.Label();
            this.lblChinese = new System.Windows.Forms.Label();
            this.lblKorean = new System.Windows.Forms.Label();
            this.lblThai = new System.Windows.Forms.Label();
            this.pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // tim
            // 
            this.tim.Tick += new System.EventHandler(this.tim_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total Points";
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints.Location = new System.Drawing.Point(106, 393);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(27, 29);
            this.lblPoints.TabIndex = 5;
            this.lblPoints.Text = "0";
            // 
            // lblJapanese
            // 
            this.lblJapanese.AllowDrop = true;
            this.lblJapanese.BackColor = System.Drawing.Color.CadetBlue;
            this.lblJapanese.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJapanese.Location = new System.Drawing.Point(0, 0);
            this.lblJapanese.Name = "lblJapanese";
            this.lblJapanese.Size = new System.Drawing.Size(100, 81);
            this.lblJapanese.TabIndex = 7;
            this.lblJapanese.Text = "Japanese";
            this.lblJapanese.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblJapanese.DragLeave += new System.EventHandler(this.lbl_DragLeave);
            // 
            // lblChinese
            // 
            this.lblChinese.AllowDrop = true;
            this.lblChinese.BackColor = System.Drawing.Color.CadetBlue;
            this.lblChinese.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChinese.Location = new System.Drawing.Point(488, 0);
            this.lblChinese.Name = "lblChinese";
            this.lblChinese.Size = new System.Drawing.Size(100, 81);
            this.lblChinese.TabIndex = 8;
            this.lblChinese.Text = "Chinese";
            this.lblChinese.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblChinese.DragLeave += new System.EventHandler(this.lbl_DragLeave);
            // 
            // lblKorean
            // 
            this.lblKorean.AllowDrop = true;
            this.lblKorean.BackColor = System.Drawing.Color.CadetBlue;
            this.lblKorean.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKorean.Location = new System.Drawing.Point(0, 348);
            this.lblKorean.Name = "lblKorean";
            this.lblKorean.Size = new System.Drawing.Size(100, 81);
            this.lblKorean.TabIndex = 8;
            this.lblKorean.Text = "Korean";
            this.lblKorean.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblKorean.DragLeave += new System.EventHandler(this.lbl_DragLeave);
            // 
            // lblThai
            // 
            this.lblThai.AllowDrop = true;
            this.lblThai.BackColor = System.Drawing.Color.CadetBlue;
            this.lblThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThai.Location = new System.Drawing.Point(488, 348);
            this.lblThai.Name = "lblThai";
            this.lblThai.Size = new System.Drawing.Size(100, 81);
            this.lblThai.TabIndex = 8;
            this.lblThai.Text = "Thai";
            this.lblThai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblThai.DragLeave += new System.EventHandler(this.lbl_DragLeave);
            // 
            // pic
            // 
            this.pic.Location = new System.Drawing.Point(223, -1);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(104, 96);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic.TabIndex = 4;
            this.pic.TabStop = false;
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_MouseUp);
            // 
            // frmIdentifyImage
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(587, 428);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.lblKorean);
            this.Controls.Add(this.lblThai);
            this.Controls.Add(this.lblChinese);
            this.Controls.Add(this.lblJapanese);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmIdentifyImage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Identify Image";
            this.Load += new System.EventHandler(this.frmIdentifyImage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Label lblJapanese;
        private System.Windows.Forms.Label lblChinese;
        private System.Windows.Forms.Label lblKorean;
        private System.Windows.Forms.Label lblThai;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Timer tim;
    }
}

