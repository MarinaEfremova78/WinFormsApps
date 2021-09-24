using System.Windows.Forms;

namespace BallsCommon
{
    public class PointBall : Ball
    {
        public PointBall(Form form, int x, int y) : base(form)
        {
            centreX = x - radius / 2;
            centreY = y - radius / 2;
        }
    }
}
