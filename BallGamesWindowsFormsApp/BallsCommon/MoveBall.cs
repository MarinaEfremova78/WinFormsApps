

using System.Windows.Forms;

namespace BallsCommon
{
    public class MoveBall : RandomPointBall
    {
        public MoveBall(Form form) : base(form)
        {
            vx = GenerateRandomProjection();
            vy = GenerateRandomProjection();
        }
        private int GenerateRandomProjection()
        {
            var randomDouble = random.NextDouble();
            var sign = 1;
            if (randomDouble < 0.5)
            {
                sign = -1;
            }
            return random.Next(2, 11) * sign;
        }
    }
}
