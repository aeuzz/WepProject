namespace FlappyBird
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pipeTop = new PictureBox();
            pipeBottom = new PictureBox();
            flappyBird = new PictureBox();
            ground = new PictureBox();
            scoreText = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pipeTop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeBottom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)flappyBird).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ground).BeginInit();
            SuspendLayout();
            // 
            // pipeTop
            // 
            pipeTop.Image = (Image)resources.GetObject("pipeTop.Image");
            pipeTop.Location = new Point(580, -148);
            pipeTop.Name = "pipeTop";
            pipeTop.Size = new Size(102, 366);
            pipeTop.SizeMode = PictureBoxSizeMode.StretchImage;
            pipeTop.TabIndex = 0;
            pipeTop.TabStop = false;
            pipeTop.Click += pipeTop_Click;
            // 
            // pipeBottom
            // 
            pipeBottom.Image = (Image)resources.GetObject("pipeBottom.Image");
            pipeBottom.Location = new Point(434, 452);
            pipeBottom.Name = "pipeBottom";
            pipeBottom.Size = new Size(103, 332);
            pipeBottom.SizeMode = PictureBoxSizeMode.StretchImage;
            pipeBottom.TabIndex = 1;
            pipeBottom.TabStop = false;
            pipeBottom.Click += pipeBottom_Click;
            // 
            // flappyBird
            // 
            flappyBird.Image = (Image)resources.GetObject("flappyBird.Image");
            flappyBird.Location = new Point(34, 224);
            flappyBird.Name = "flappyBird";
            flappyBird.Size = new Size(77, 62);
            flappyBird.SizeMode = PictureBoxSizeMode.StretchImage;
            flappyBird.TabIndex = 2;
            flappyBird.TabStop = false;
            flappyBird.Click += pictureBox3_Click;
            // 
            // ground
            // 
            ground.Image = (Image)resources.GetObject("ground.Image");
            ground.Location = new Point(-33, 609);
            ground.Name = "ground";
            ground.Size = new Size(768, 104);
            ground.SizeMode = PictureBoxSizeMode.StretchImage;
            ground.TabIndex = 3;
            ground.TabStop = false;
            // 
            // scoreText
            // 
            scoreText.AutoSize = true;
            scoreText.BackColor = Color.FromArgb(223, 216, 148);
            scoreText.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            scoreText.Location = new Point(34, 636);
            scoreText.Name = "scoreText";
            scoreText.Size = new Size(128, 41);
            scoreText.TabIndex = 4;
            scoreText.Text = "Score: 0";
            scoreText.Click += scoreText_Click;
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 20;
            gameTimer.Tick += gameTimerEvent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(729, 699);
            Controls.Add(scoreText);
            Controls.Add(ground);
            Controls.Add(flappyBird);
            Controls.Add(pipeBottom);
            Controls.Add(pipeTop);
            Name = "Form1";
            Text = " ";
            KeyDown += gamekeyisdown;
            KeyUp += gamekeyisup;
            ((System.ComponentModel.ISupportInitialize)pipeTop).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeBottom).EndInit();
            ((System.ComponentModel.ISupportInitialize)flappyBird).EndInit();
            ((System.ComponentModel.ISupportInitialize)ground).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pipeTop;
        private PictureBox pipeBottom;
        private PictureBox flappyBird;
        private PictureBox ground;
        private Label scoreText;
        private System.Windows.Forms.Timer gameTimer;
    }
}
