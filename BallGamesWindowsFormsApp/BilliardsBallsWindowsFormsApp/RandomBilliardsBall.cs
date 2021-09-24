using BallsCommon;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BilliardsBallsWindowsFormsApp
{
    public class RandomBilliardsBall : BilliardsBall
    {
        public event EventHandler<HitEventArgs> OnHit;
        public RandomBilliardsBall(Form form) : base(form)
        {
        }
        protected override void Go()
        {
            base.Go();
            if (centreX <= LeftSide())
            {
                OnHit.Invoke(this, new HitEventArgs(Side.Left));
                ChangeColor();
            }
            if (centreX >= RightSide())
            {
                OnHit.Invoke(this, new HitEventArgs(Side.Right));
                ChangeColor();
            }
            if (centreY <= TopSide())
            {
                OnHit.Invoke(this, new HitEventArgs(Side.Top));
                ChangeColor();
            }
            if (centreY >= BottomSide())
            {
                OnHit.Invoke(this, new HitEventArgs(Side.Bottom));
                ChangeColor();
            }   
        }

        private void ChangeColor()
        {
            Color randomColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            color = new SolidBrush(randomColor);
        }
    }
}
