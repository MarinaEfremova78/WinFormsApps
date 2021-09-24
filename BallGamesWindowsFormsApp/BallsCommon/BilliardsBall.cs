using System.Windows.Forms;

namespace BallsCommon
{
    public class BilliardsBall : MoveBall
    {
        public BilliardsBall(Form form) : base(form)
        {
        }
        protected override void Go()
        {
            base.Go();
            if (centreX <= LeftSide())
            {
                vx = -vx;
            }
            if (centreX >= RightSide())
            {
                vx = -vx;
            }
            if (centreY <= TopSide())
            {
                vy = -vy;
            }
            if (centreY >= BottomSide())
            {
                vy = -vy;
            }
        }

    }
}
