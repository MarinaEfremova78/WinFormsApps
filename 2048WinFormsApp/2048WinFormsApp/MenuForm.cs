using System;
using System.Windows.Forms;

namespace _2048WinFormsApp
{
    public partial class MenuForm : Form
    {
        private User newUser;
        public MenuForm(User user)
        {
            InitializeComponent();
            newUser = user;
        }

        private void gameRulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Используйте клавиши Вправо, Влево, Вверх, Вниз, чтобы передвигать и складывать ячейки с одинаковыми числами. Наберите лучший счёт и установите новый рекорд!", "Правила игры");
        }

        private void startGameButton_Click(object sender, EventArgs e)
        {
            var userAnswer = CheckName(userNameTextBox);
            if (userAnswer != userNameTextBox.Text)
            {
                MessageBox.Show(userAnswer, "Что-то пошло не так...");
                return;
            }
            newUser.Name = userNameTextBox.Text;
            Close();
        }

        private string CheckName(TextBox userNameTextBox)
        {
            if (userNameTextBox.Text == string.Empty)
            {
                return "Введите имя игрока!";
            }
            return userNameTextBox.Text;
        }

        private void MenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (newUser.Name == "Новый игрок")
            {
                Application.Exit();
            }
        }

        private void recordsButton_Click(object sender, EventArgs e)
        {
            var usersResults = new ShowAllUsersResults();
            usersResults.ShowDialog(this);
        }
    }
}
