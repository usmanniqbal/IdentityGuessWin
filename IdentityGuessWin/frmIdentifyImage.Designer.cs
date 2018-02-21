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
            this.btnJapanese = new System.Windows.Forms.Button();
            this.btnChinese = new System.Windows.Forms.Button();
            this.btnKorean = new System.Windows.Forms.Button();
            this.btnThai = new System.Windows.Forms.Button();
            this.tim = new System.Windows.Forms.Timer(this.components);
            this.pic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // btnJapanese
            // 
            this.btnJapanese.Location = new System.Drawing.Point(-1, -1);
            this.btnJapanese.Name = "btnJapanese";
            this.btnJapanese.Size = new System.Drawing.Size(75, 63);
            this.btnJapanese.TabIndex = 0;
            this.btnJapanese.Text = "Japanese";
            this.btnJapanese.UseVisualStyleBackColor = true;
            this.btnJapanese.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnChinese
            // 
            this.btnChinese.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChinese.Location = new System.Drawing.Point(513, -1);
            this.btnChinese.Name = "btnChinese";
            this.btnChinese.Size = new System.Drawing.Size(75, 63);
            this.btnChinese.TabIndex = 1;
            this.btnChinese.Text = "Chinese";
            this.btnChinese.UseVisualStyleBackColor = true;
            this.btnChinese.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnKorean
            // 
            this.btnKorean.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnKorean.Location = new System.Drawing.Point(-1, 366);
            this.btnKorean.Name = "btnKorean";
            this.btnKorean.Size = new System.Drawing.Size(75, 63);
            this.btnKorean.TabIndex = 2;
            this.btnKorean.Text = "Korean";
            this.btnKorean.UseVisualStyleBackColor = true;
            this.btnKorean.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnThai
            // 
            this.btnThai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThai.Location = new System.Drawing.Point(513, 366);
            this.btnThai.Name = "btnThai";
            this.btnThai.Size = new System.Drawing.Size(75, 63);
            this.btnThai.TabIndex = 3;
            this.btnThai.Text = "Thai";
            this.btnThai.UseVisualStyleBackColor = true;
            this.btnThai.Click += new System.EventHandler(this.btn_Click);
            // 
            // tim
            // 
            this.tim.Enabled = true;
            this.tim.Tick += new System.EventHandler(this.tim_Tick);
            // 
            // pic
            // 
            this.pic.Image = global::IdentityGuessWin.Properties.Resources.japanese1;
            this.pic.Location = new System.Drawing.Point(223, -1);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(141, 119);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic.TabIndex = 4;
            this.pic.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total Points";
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints.Location = new System.Drawing.Point(80, 393);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(27, 29);
            this.lblPoints.TabIndex = 5;
            this.lblPoints.Text = "0";
            // 
            // frmIdentifyImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(587, 428);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.btnThai);
            this.Controls.Add(this.btnKorean);
            this.Controls.Add(this.btnChinese);
            this.Controls.Add(this.btnJapanese);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmIdentifyImage";
            this.Text = "Identify Image";
            this.Load += new System.EventHandler(this.frmIdentifyImage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnJapanese;
        private System.Windows.Forms.Button btnChinese;
        private System.Windows.Forms.Button btnKorean;
        private System.Windows.Forms.Button btnThai;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Timer tim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPoints;
    }
}

