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
    public partial class GetAllUsersResultsForm : Form
    {
        public GetAllUsersResultsForm()
        {
            InitializeComponent();
        }

        private void GetAllUsersResultsForm_Load(object sender, EventArgs e)
        {
            var allUsers = UserResultsStorage.GetAll();
            List<User> allusers = new List<User>();
            foreach (var user in allUsers)
            {
                allusers.Add(user);
            }
            for (int i = 0; i < allusers.Count; i++)
            {
                allUsersResultsDataGridView.Rows.Add();
                allUsersResultsDataGridView["name", i].Value = allusers[i].Name;
                allUsersResultsDataGridView["countRightAnswers", i].Value = allusers[i].CountRightAnswers;
                allUsersResultsDataGridView["Diagnosis", i].Value = allusers[i].Diagnosis;
            }
        }
    }
}
