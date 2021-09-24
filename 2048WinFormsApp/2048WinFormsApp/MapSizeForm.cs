using System;
using System.Windows.Forms;

namespace _2048WinFormsApp
{
    public partial class MapSizeForm : Form
    {
        private int newMapSize;
        public MapSizeForm()
        {
            InitializeComponent();
        }

        private void MapSizeForm_Load(object sender, EventArgs e)
        {

        }
        public int GetMapSize()
        {
            var mapSize = newMapSize;
            return mapSize;
        }
        private void size5Button_Click(object sender, EventArgs e)
        {
            newMapSize = 5;
            this.Close();
        }
        private void size6Button_Click(object sender, EventArgs e)
        {
            newMapSize = 6;
            this.Close();
        }

        private void size7Button_Click(object sender, EventArgs e)
        {
            newMapSize = 7;
            this.Close();
        }

        private void size8Button_Click(object sender, EventArgs e)
        {
            newMapSize = 8;
            this.Close();
        }
    }
}
