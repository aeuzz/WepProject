namespace FlappyBird
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        int pipeSpeed = 8;
        int gravity = 15;
        int score = 0;
        bool gameOver = false;  // we use this for the restart button

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pipeTop_Click(object sender, EventArgs e)
        {

        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappyBird.Top += gravity;
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            scoreText.Text = "Score: " + score;

            // make the pipes moves to the left
            if (pipeBottom.Left < -150)
            {
                pipeBottom.Left = 800;
                score++;
            }
            if (pipeTop.Left < -180)
            {
                pipeTop.Left = 950;
                score++;
            }

            if (flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
                flappyBird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                flappyBird.Bounds.IntersectsWith(ground.Bounds) ||
                flappyBird.Top < -25
               )

            {
                endGame();
            }


            if (score > 5)
            {
                pipeSpeed = 15; // Increment speed
            }
            if (score > 10)
            {
                pipeSpeed = 18; // Increment speed
            }
            if (score > 15)
            {
                pipeSpeed = 21; // Increment speed
            }



        }
        // these 2 methods for the space key to make the bird goes up when i press space
        private void gamekeyisdown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Space)
            {
                // if the space key is pressed the gravity will be set to -15
                gravity = -15;

            }
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                // if the space key is released the gravity will be set to 15

                gravity = 15;

            }

            if (e.KeyCode == Keys.R && gameOver)
            {
                RestartGame();
            }
        }
        private void endGame()
        {
            gameTimer.Stop();
            scoreText.Text += " Game Over ! Press R to retry";
            gameOver = true;
        }

        private void RestartGame()
        {
            gameOver = false;

            flappyBird.Location = new Point(34, 224);
            pipeTop.Left = 800;
            pipeBottom.Left = 950;

            score = 0;
            pipeSpeed = 8;
            scoreText.Text = " Score: 0 ";
            gameTimer.Start();


        }

        private void pipeBottom_Click(object sender, EventArgs e)
        {

        }

        private void scoreText_Click(object sender, EventArgs e)
        {

        }
    }
}
