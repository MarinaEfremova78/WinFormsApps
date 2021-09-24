using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DiffusionWindowsFormsApp
{
    public partial class DiffusionForm : Form
    {
        List<RedMolecule> redBalls = new List<RedMolecule>();
        List<BlackMolecule> blackBalls = new List<BlackMolecule>();
        private int redBallsCount = 10;
        private int blackBallsCount = 10;
        private int redBallsOnLeft;
        private int redBallsOnRight;
        private int blackBallsOnLeft;
        private int blackBallsOnRight;

        public DiffusionForm()
        {
            InitializeComponent();
        }

        private void DiffusionForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < redBallsCount; i++)
            {
                var redMolecule = new RedMolecule(this);

                redBalls.Add(redMolecule);
                redMolecule.Start();

            }
            for (int i = 0; i < blackBallsCount; i++)
            {
                var blackMolecule = new BlackMolecule(this);
                blackBalls.Add(blackMolecule);
                blackMolecule.Start();
            }
            diffusionTimer.Start();
        }

        private void DiffusionForm_MouseClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < redBalls.Count; i++)
            {
                if (redBalls[i].IsMoving())
                {
                    redBalls[i].Stop();
                }
                else
                {
                    redBalls[i].Start();
                }
            }
            for (int i = 0; i < blackBalls.Count; i++)
            {
                if (blackBalls[i].IsMoving())
                {
                    blackBalls[i].Stop();
                }
                else
                {
                    blackBalls[i].Start();
                }
            }
        }

        private void diffusionTimer_Tick(object sender, EventArgs e)
        {
            CheckForEqualNumber();
        }

        private void CheckForEqualNumber()
        {
            redBallsOnLeft = 0;
            redBallsOnRight = 0;
            blackBallsOnLeft = 0;
            blackBallsOnRight = 0;
            for (int i = 0; i < redBalls.Count; i++)
            {
                if (redBalls[i].OnLeftHalfForm())
                {
                    redBallsOnLeft++;
                }
                if (blackBalls[i].OnLeftHalfForm())
                {
                    blackBallsOnLeft++;
                }
                if (redBalls[i].OnRightHalfForm())
                {
                    redBallsOnRight++;
                }
                if (blackBalls[i].OnRightHalfForm())
                {
                    blackBallsOnRight++;
                }
            }
            if (EqualAmount())
            {
                for (int i = 0; i < redBalls.Count; i++)
                {
                    redBalls[i].Stop();
                }
                for (int i = 0; i < blackBalls.Count; i++)
                {
                    blackBalls[i].Stop();
                }
            }
        }

        public bool EqualAmount()
        {
            return blackBallsOnLeft == blackBalls.Count / 2 && blackBallsOnRight == blackBalls.Count / 2 && redBallsOnLeft == redBalls.Count / 2 && redBallsOnRight == redBalls.Count / 2;
        }
    }
}
