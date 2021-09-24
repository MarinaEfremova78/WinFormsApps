using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace _2048WinFormsApp
{
    public partial class MainForm : Form
    {
        private User user;
        private int mapSize = 4;
        private Label[,] labelsMap;
        private static Random random = new Random();
        private int score = 0;
        private int bestScore;
        public static string bestScorePath = @"bestresult.txt";
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            user = new User("Новый игрок");
            var menuForm = new MenuForm(user);
            menuForm.ShowDialog(this);
            InitMap(mapSize);
            GenerateNumber();
            bestScore = GetBestScore(bestScorePath);           
            ShowScore();
        }
        private void ShowScore()
        {
            scoreLabel.Text = score.ToString();
            bestScoreLabel.Text = bestScore.ToString();
        }
        public int GetBestScore(string path)
        {
            if (File.Exists(path))
            {
                var reader = new StreamReader(path);
                var bestScore = Convert.ToInt32(reader.ReadLine());
                reader.Close();
                return bestScore;
            }
            else
            {
                return 0;
            }
        }
        private void TryUpdateBestScore()
        {
            if(score > bestScore)
            {
                bestScore = score;
            }
        }       

        private void GenerateNumber()
        {
            string[] initialNumber = new string[2];
            initialNumber[0] = "2";
            initialNumber[1] = "4";
            while (true)
            {
                var randomInitialNumberIndex = random.Next(0, 2);
                var randomNumberLabel = random.Next(mapSize * mapSize);
                var indexRow = randomNumberLabel / mapSize;
                var indexColumn = randomNumberLabel % mapSize;
                if (labelsMap[indexRow, indexColumn].Text == string.Empty)
                {
                    labelsMap[indexRow, indexColumn].Text = initialNumber[randomInitialNumberIndex];
                    break;
                }
            }
        }
        private void InitMap(int mapSize)
        {
            labelsMap = new Label[mapSize, mapSize];
            this.ClientSize = new System.Drawing.Size(80 * mapSize, 95 * mapSize);
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    var newLabel = CreateLabel(i, j);
                    Controls.Add((Control)newLabel);
                    labelsMap[i, j] = (Label)newLabel;
                }
            }
        }

        private object CreateLabel(int indexRow, int indexColumn)
        {
            var label = new Label();
            label.BackColor = System.Drawing.Color.WhiteSmoke;
            label.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));
            label.Size = new Size(70, 70);
            label.TextAlign = ContentAlignment.MiddleCenter;
            int x = 10 + indexColumn * 76;
            int y = 70 + indexRow * 76;
            label.Location = new Point(x, y);
            label.TextChanged += Label_TextChanged;
            return label;
        }

        private void Label_TextChanged(object sender, EventArgs e)
        {
            var label = (Label)sender;
            GetLabelColor(label);
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Right && e.KeyCode != Keys.Left && e.KeyCode != Keys.Down && e.KeyCode != Keys.Up)
            {
                return;
            }
            bool isMerged = false;
            if (e.KeyCode == Keys.Right)
            {
                for (int i = 0; i < mapSize; i++)
                {
                    for (int j = mapSize - 1; j >= 0; j--)
                    {
                        if (labelsMap[i, j].Text != string.Empty)
                        {
                            for (int k = j - 1; k >= 0; k--)
                            {
                                if (labelsMap[i, k].Text != string.Empty)
                                {
                                    if (labelsMap[i, j].Text == labelsMap[i, k].Text)
                                    {
                                        var number = int.Parse(labelsMap[i, j].Text);
                                        labelsMap[i, j].Text = (number * 2).ToString();

                                        score += number * 2;
                                        isMerged = true;
                                        labelsMap[i, k].Text = string.Empty;

                                    }
                                    break;
                                }
                            }
                        }
                    }
                }
                for (int i = 0; i < mapSize; i++)
                {
                    for (int j = mapSize - 1; j >= 0; j--)
                    {
                        if (labelsMap[i, j].Text == string.Empty)
                        {
                            for (int k = j - 1; k >= 0; k--)
                            {
                                if (labelsMap[i, k].Text != string.Empty)
                                {
                                    labelsMap[i, j].Text = labelsMap[i, k].Text.ToString();

                                    labelsMap[i, k].Text = string.Empty;

                                    break;
                                }
                            }
                        }
                    }
                }

            }
            if (e.KeyCode == Keys.Left)
            {
                for (int i = 0; i < mapSize; i++)
                {
                    for (int j = 0; j < mapSize; j++)
                    {
                        if (labelsMap[i, j].Text != string.Empty)
                        {
                            for (int k = j + 1; k < mapSize; k++)
                            {
                                if (labelsMap[i, k].Text != string.Empty)
                                {
                                    if (labelsMap[i, j].Text == labelsMap[i, k].Text)
                                    {
                                        var number = int.Parse(labelsMap[i, j].Text);
                                        score += number * 2;
                                        isMerged = true;
                                        labelsMap[i, j].Text = (number * 2).ToString();

                                        labelsMap[i, k].Text = string.Empty;

                                    }
                                    break;
                                }
                            }
                        }
                    }
                }
                for (int i = 0; i < mapSize; i++)
                {
                    for (int j = 0; j < mapSize; j++)
                    {
                        if (labelsMap[i, j].Text == string.Empty)
                        {
                            for (int k = j + 1; k < mapSize; k++)
                            {
                                if (labelsMap[i, k].Text != string.Empty)
                                {
                                    labelsMap[i, j].Text = labelsMap[i, k].Text.ToString();

                                    labelsMap[i, k].Text = string.Empty;

                                    break;
                                }
                            }
                        }
                    }
                }
            }
            if (e.KeyCode == Keys.Down)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    for (int i = mapSize - 1; i >= 0; i--)
                    {
                        if (labelsMap[i, j].Text != string.Empty)
                        {
                            for (int k = i - 1; k >= 0; k--)
                            {
                                if (labelsMap[k, j].Text != string.Empty)
                                {
                                    if (labelsMap[i, j].Text == labelsMap[k, j].Text)
                                    {
                                        var number = int.Parse(labelsMap[i, j].Text);
                                        score += number * 2;
                                        isMerged = true;
                                        labelsMap[i, j].Text = (number * 2).ToString();

                                        labelsMap[k, j].Text = string.Empty;

                                    }

                                    break;
                                }
                            }
                        }
                    }
                }
                for (int j = 0; j < mapSize; j++)
                {
                    for (int i = mapSize - 1; i >= 0; i--)
                    {
                        if (labelsMap[i, j].Text == string.Empty)
                        {
                            for (int k = i - 1; k >= 0; k--)
                            {
                                if (labelsMap[k, j].Text != string.Empty)
                                {
                                    labelsMap[i, j].Text = labelsMap[k, j].Text.ToString();

                                    labelsMap[k, j].Text = string.Empty;

                                    break;
                                }
                            }
                        }
                    }
                }
            }
            if (e.KeyCode == Keys.Up)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    for (int i = 0; i < mapSize; i++)
                    {
                        if (labelsMap[i, j].Text != string.Empty)
                        {
                            for (int k = i + 1; k < mapSize; k++)
                            {
                                if (labelsMap[k, j].Text != string.Empty)
                                {
                                    if (labelsMap[i, j].Text == labelsMap[k, j].Text)
                                    {
                                        var number = int.Parse(labelsMap[i, j].Text);
                                        score += number * 2;
                                        isMerged = true;
                                        labelsMap[i, j].Text = (number * 2).ToString();

                                        labelsMap[k, j].Text = string.Empty;

                                    }

                                    break;
                                }
                            }
                        }
                    }
                }
                for (int j = 0; j < mapSize; j++)
                {
                    for (int i = 0; i < mapSize; i++)
                    {
                        if (labelsMap[i, j].Text == string.Empty)
                        {
                            for (int k = i + 1; k < mapSize; k++)
                            {
                                if (labelsMap[k, j].Text != string.Empty)
                                {
                                    labelsMap[i, j].Text = labelsMap[k, j].Text.ToString();

                                    labelsMap[k, j].Text = string.Empty;

                                    break;
                                }
                            }
                        }
                    }
                }
            }
            TryUpdateBestScore();
            ShowScore();
            if ((IsFullMap() && isMerged == false) || Exists2048())
            {
                MessageBox.Show("Конец игры", "Сообщение");
                return;
            }
            GenerateNumber();

        }
        private bool IsFullMap()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        private bool Exists2048()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (labelsMap[i, j].Text == "2048")
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        static Label GetLabelColor(Label label)
        {
            if (label.Text == string.Empty || label.Text == "2")
            {
                label.BackColor = System.Drawing.Color.WhiteSmoke;
            }
            if (label.Text == "4")
            {
                label.BackColor = System.Drawing.Color.LightGray;
                return label;
            }
            if (label.Text == "8")
            {
                label.BackColor = System.Drawing.Color.Lavender;
                return label;
            }
            if (label.Text == "16")
            {
                label.BackColor = System.Drawing.Color.LightBlue;
                return label;
            }
            if (label.Text == "32")
            {
                label.BackColor = System.Drawing.Color.LightCoral;
                return label;
            }
            if (label.Text == "64")
            {
                label.BackColor = System.Drawing.Color.OrangeRed;
                return label;
            }
            if (label.Text == "128")
            {
                label.BackColor = System.Drawing.Color.Crimson;
                return label;
            }
            if (label.Text == "256")
            {
                label.BackColor = System.Drawing.Color.IndianRed;
                return label;
            }
            if (label.Text == "512")
            {
                label.BackColor = System.Drawing.Color.Firebrick;
                return label;
            }
            if (label.Text == "1024")
            {
                label.BackColor = System.Drawing.Color.Green;
                return label;
            }
            if (label.Text == "2048")
            {
                label.BackColor = System.Drawing.Color.Maroon;
                return label;
            }
            return label;
        }

        private void RestartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        

        private void changeMapSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (score != 0)
            {
                MessageBox.Show("Чтобы изменить размер поля, начните новую игру", "Рестарт");
                return;
            }
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    labelsMap[i, j].Dispose();
                }
            }
            var mapSizeForm = new MapSizeForm();
            mapSizeForm.ShowDialog(this);
            mapSize = mapSizeForm.GetMapSize();           
            InitMap(mapSize);
            GenerateNumber();
            ShowScore();
            return;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (score != 0)
            {
                var writer = new StreamWriter(bestScorePath, false);
                writer.WriteLine(bestScore);
                writer.Close();
                user.Score = score;
                resultsStorage.Append(user);
            }
        }
    }
}
