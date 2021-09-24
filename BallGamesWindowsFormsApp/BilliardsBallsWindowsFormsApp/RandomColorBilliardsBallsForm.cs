using System;
using System.Windows.Forms;

namespace BilliardsBallsWindowsFormsApp
{
    public partial class RandomColorBilliardsBallsForm : Form
    {
        public RandomColorBilliardsBallsForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                var ball = new RandomBilliardsBall(this);
                ball.OnHit += Ball_OnHit;
                ball.Start();
            }
        }

        private void Ball_OnHit(object sender, HitEventArgs e)
        {
            switch(e.Side)
            {
                case Side.Left:
                    leftLabel.Text = (Convert.ToInt32(leftLabel.Text) + 1).ToString();
                        break;
                case Side.Right:
                    rightLabel.Text = (Convert.ToInt32(rightLabel.Text) + 1).ToString();
                    break;
                case Side.Top:
                    topLabel.Text = (Convert.ToInt32(topLabel.Text) + 1).ToString();
                    break;
                case Side.Bottom:
                    bottomLabel.Text = (Convert.ToInt32(bottomLabel.Text) + 1).ToString();
                    break;
            }
        }
    }
}
