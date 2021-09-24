using GeniyIdiot.Common;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GeniyIdiotWinFormsApp
{
    public partial class MainForm : Form
    {
        private User currentUser;
        private Game game;
        private int tick;
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            currentUser = new User("Неизвестно");
            game = new Game(currentUser);
            var getCurrentUserName = new GetCurrentUserName(currentUser);
            getCurrentUserName.ShowDialog();
            ShowNextQuestion();
        }

        private void ShowNextQuestion()
        {
            var currentQuestion = game.PopRandomQuestion();
            questionTextLabel.Text = currentQuestion.Text;

            questionNumberLabel.Text = game.GetQuestionNumberInfo();
            userAnswerTextBox.Clear();
            userAnswerTextBox.Focus();
            oneQuestionTimer.Start();
            tick = 10;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            var userAnswer = GetUserAnswer();
            int userAnswerNumber;
            if (userAnswer != "OK")
            {
                MessageBox.Show(userAnswer, "Неверный формат!");
                userAnswerTextBox.Clear();
                userAnswerTextBox.Focus();
                return;
            }
            else
            {
                userAnswerNumber = Convert.ToInt32(userAnswerTextBox.Text);
                oneQuestionTimer.Stop();
            }

            if (tick > 0)
            {
                game.AcceptAnswer(userAnswerNumber);
            }
            if (game.End())
            {
                var diagnosis = game.CalculateDiagnose();
                MessageBox.Show(diagnosis, "Поздравляем!");
                UserResultsStorage.Append(currentUser);
                restartButton.Visible = true;
                return;
            }
            ShowNextQuestion();
        }
        private string GetUserAnswer()
        {
            try
            {
                var input = Convert.ToInt32(userAnswerTextBox.Text);
                return "OK";
            }
            catch (FormatException)
            {
                return "Пожалуйста, введите число!";
            }
            catch (OverflowException)
            {
                return "Пожалуйста, введите число меньше 10^9";
            }
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void oneQuestionTimer_Tick(object sender, EventArgs e)
        {
            oneQuestionTimerLabel.Text = tick.ToString();
            tick--;
            if(tick == 0)
            {
                oneQuestionTimerLabel.Text = "Время вышло!";
                oneQuestionTimer.Stop();                
            }
        }
    }
}
