using GeniyIdiot.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeniyIdiotWinFormsApp
{
    public partial class addNewQuestionForm : Form
    {
        private Question anotherQuestion;
        public addNewQuestionForm()
        {
            InitializeComponent();
        }

        private void addNewQuestionForm_Load(object sender, EventArgs e)
        {
            
        }

        private void addNewQuestionButton_Click(object sender, EventArgs e)
        {
            QuestionsStorage.Get();
            var newQuestion = CheckNewQuestion();
            if (newQuestion != newQuestionTextBox.Text)
            {
                MessageBox.Show(newQuestion, "Неверный формат вопроса!");
                return;
            }
            var newAnswer = GetNewAnswer();
            int newAnswerNumber;
            if (newAnswer != "OK")
            {
                MessageBox.Show(newAnswer, "Неверный формат ответа!");
                newAnswerTextBox.Clear();
                newAnswerTextBox.Focus();
                return;
            }
            else
            {
                newAnswerNumber = Convert.ToInt32(newAnswerTextBox.Text);
            }
            anotherQuestion = new Question(newQuestion, newAnswerNumber);
            QuestionsStorage.Append(anotherQuestion);
            this.Close();
        }
        private string CheckNewQuestion()
        {
            if (String.IsNullOrEmpty(newQuestionTextBox.Text) || (newQuestionTextBox.Text == " ") == true)
            {
                return "Пожалуйста, введите Ваш текст";
            }
            else
            {
                return newQuestionTextBox.Text;
            }
        }
        private string GetNewAnswer()
        {
            try
            {
                var input = Convert.ToInt32(newAnswerTextBox.Text);
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
    }
}
