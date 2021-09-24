using GeniyIdiot.Common;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GeniyIdiotWinFormsApp
{
    public partial class GetCurrentUserName : Form
    {
        private User newUser;
        public GetCurrentUserName(User user)
        {
            InitializeComponent();
            newUser = user;
        }

        private void GetCurrentUserName_Load(object sender, EventArgs e)
        {

        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            var newUserName = IsValid();
            if (newUserName != userNameTextBox.Text)
            {
                MessageBox.Show(newUserName, "Неверный формат!");
                userNameTextBox.Clear();
                userNameTextBox.Focus();
                return;
            }
            else if (newUserName == "Админ")
            {
                addNewQuestionButton.Enabled = true;
                return;
            }
            else
            {
                newUser.Name = newUserName;                
                userNameTextBox.Clear();
                userNameTextBox.Focus();
                this.Close();
            }           
        }
        private string IsValid()
        {
            var output = User.CheckName(userNameTextBox.Text);
            if (output != userNameTextBox.Text)
            {
                return output;
            }
            else
            {
                return userNameTextBox.Text;
            }
        }

        private void addNewQuestionButton_Click(object sender, EventArgs e)
        {
            var addNewQuestionForm = new addNewQuestionForm();
            addNewQuestionForm.ShowDialog();
            userNameTextBox.Clear();
            userNameTextBox.Focus();
        }

        private void seeAllUsersResultsButton_Click(object sender, EventArgs e)
        {
            var getAllUsersResultsForm = new GetAllUsersResultsForm();
            getAllUsersResultsForm.ShowDialog();
        }
    }
}
