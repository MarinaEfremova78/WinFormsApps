using BallsCommon;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BallGamesWindowsFormsApp
{
    public partial class MainForm : Form
    {
        List<Ball> balls;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < balls.Count; i++)
            {                
                if (balls[i].IsMoving() && balls[i].Exists(e.X, e.Y))
                {
                    balls[i].Stop();
                    countBallsLabel.Text = (Convert.ToInt32(countBallsLabel.Text) + 1).ToString();
                }
            }
        }

        private void stopBallsButton_Click(object sender, EventArgs e)
        {
            var countBalls = 0;
            for (int i = 0; i < balls.Count; i++)
            {
                balls[i].Stop();
                if (balls[i].OnForm())
                {
                    countBalls++;
                }
            }
            MessageBox.Show("Вы поймали " + countBalls + " мячиков");
        }
        private void manyBallsButton_Click(object sender, EventArgs e)
        {
            balls = new List<Ball>();
            for (int i = 0; i < 10; i++)
            {
                var moveBall = new MoveBall(this);
                balls.Add(moveBall);
                moveBall.Start();

                var ball = new RandomSizeAndPointBall(this);
                balls.Add(ball);
                ball.Start();
            }
        }
    }
}
