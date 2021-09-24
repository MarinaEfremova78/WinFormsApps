using System;
using System.Windows.Forms;

namespace BallsCommon
{
    public class RandomPointBall : Ball
    {
        protected static Random random = new Random();
        public RandomPointBall(Form form) : base(form)
        {
            centreX = random.Next(LeftSide(), RightSide());
            centreY = random.Next(TopSide(), BottomSide());
        }
    }
}
