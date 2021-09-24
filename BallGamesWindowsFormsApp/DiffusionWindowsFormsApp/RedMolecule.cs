using BallsCommon;
using System.Drawing;
using System.Windows.Forms;

namespace DiffusionWindowsFormsApp
{
    public class RedMolecule : BilliardsBall
    {
        public RedMolecule(Form form) : base(form)
        {
            centreX = random.Next(LeftSide(), middleLine);
        }
    }
}
