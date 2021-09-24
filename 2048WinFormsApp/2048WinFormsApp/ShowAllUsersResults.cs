using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _2048WinFormsApp
{
    public partial class ShowAllUsersResults : Form
    {
        public ShowAllUsersResults()
        {
            InitializeComponent();
        }

        private void ShowAllUsersResults_Load(object sender, EventArgs e)
        {
            var allUsers = resultsStorage.GetAll();
            List<User> allusers = new List<User>();
            foreach (var user in allUsers)
            {
                allusers.Add(user);
            }
            for (int i = 0; i < allusers.Count; i++)
            {
                dataGridView.Rows.Add();
                dataGridView["name", i].Value = allusers[i].Name;
                dataGridView["score", i].Value = allusers[i].Score;
            }
        }
    }
}
