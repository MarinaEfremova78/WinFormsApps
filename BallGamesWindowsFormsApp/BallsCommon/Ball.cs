using System;
using System.Drawing;
using System.Windows.Forms;

namespace BallsCommon
{
    public class Ball
    {
        private Form form;
        protected int vx = 1;
        protected int vy = 1;
        protected int centreX = 10;
        protected int centreY = 10;
        protected int radius = 25;
        protected Brush color = Brushes.Red;
        private Timer timer;
        protected int middleLine;
        public Ball(Form form)
        {
            timer = new Timer();
            timer.Interval = 20;
            timer.Tick += Timer_Tick;
            this.form = form;
            middleLine = form.ClientSize.Width / 2 + radius;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            Move();
        }
        public void Start()
        {
            timer.Start();
        }
        public void Stop()
        {
            timer.Stop();
        }
        public bool IsMoving()
        {
            return timer.Enabled;
        }
        protected virtual void Show()
        {
            Draw(color);
        }
        protected virtual void Go()
        {
            centreX += vx;
            centreY += vy;
        }

        public bool OnForm()
        {
            return centreX >= LeftSide() && centreX <= RightSide() && centreY >= TopSide() && centreY <= BottomSide();
        }
        public bool OnRightHalfForm()
        {
            
            return centreX >= LeftSide() && centreX <= middleLine && centreY >= TopSide() && centreY <= BottomSide();
        }
        public bool OnLeftHalfForm()
        {
            return centreX >= middleLine && centreX <= RightSide() && centreY >= TopSide() && centreY <= BottomSide();
        }
        public int LeftSide()
        {
            return radius;
        }
        public int RightSide()
        {
            return form.ClientSize.Width - radius;
        }
        public int TopSide()
        {
            return radius;
        }
        public int BottomSide()
        {
            return form.ClientSize.Height - radius;
        }
        public bool Exists(int pointX, int pointY)
        {
            var dx = pointX - centreX;
            var dy = pointY - centreY;

            return dx * dx + dy * dy <= radius * radius;
        }
        private void Clear()
        {
            var brush = new SolidBrush(form.BackColor);
            Draw(brush);
        }
        private void Draw(Brush brush)
        {
            var graphics = form.CreateGraphics();
            var rectangle = new Rectangle(centreX - radius, centreY - radius, 2 * radius, 2 * radius);
            graphics.FillEllipse(brush, rectangle);
        }
        public void Move()
        {
            Clear();
            Go();
            Show();
        }
    }
}
