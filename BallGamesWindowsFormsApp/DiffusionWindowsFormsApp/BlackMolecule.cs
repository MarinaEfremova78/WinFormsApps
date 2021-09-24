using BallsCommon;
using System.Drawing;
using System.Windows.Forms;

namespace DiffusionWindowsFormsApp
{
    public class BlackMolecule : BilliardsBall
    {
        public BlackMolecule(Form form) : base(form)
        {
            color = Brushes.Black;
            centreX = random.Next(middleLine, RightSide());
        }
    }
}
