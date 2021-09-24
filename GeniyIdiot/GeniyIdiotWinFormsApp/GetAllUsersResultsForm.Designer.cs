
namespace GeniyIdiotWinFormsApp
{
    partial class GetAllUsersResultsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.allUsersResultsDataGridView = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countRightAnswers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnosis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.allUsersResultsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // allUsersResultsDataGridView
            // 
            this.allUsersResultsDataGridView.AllowUserToAddRows = false;
            this.allUsersResultsDataGridView.AllowUserToDeleteRows = false;
            this.allUsersResultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allUsersResultsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.countRightAnswers,
            this.diagnosis});
            this.allUsersResultsDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.allUsersResultsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.allUsersResultsDataGridView.Name = "allUsersResultsDataGridView";
            this.allUsersResultsDataGridView.ReadOnly = true;
            this.allUsersResultsDataGridView.RowHeadersWidth = 51;
            this.allUsersResultsDataGridView.RowTemplate.Height = 24;
            this.allUsersResultsDataGridView.Size = new System.Drawing.Size(800, 452);
            this.allUsersResultsDataGridView.TabIndex = 0;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "Имя, Фамилия, Отчество";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // countRightAnswers
            // 
            this.countRightAnswers.HeaderText = "Количество правильных ответов";
            this.countRightAnswers.MinimumWidth = 6;
            this.countRightAnswers.Name = "countRightAnswers";
            this.countRightAnswers.ReadOnly = true;
            this.countRightAnswers.Width = 125;
            // 
            // diagnosis
            // 
            this.diagnosis.HeaderText = "Диагноз";
            this.diagnosis.MinimumWidth = 6;
            this.diagnosis.Name = "diagnosis";
            this.diagnosis.ReadOnly = true;
            this.diagnosis.Width = 125;
            // 
            // GetAllUsersResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.allUsersResultsDataGridView);
            this.Name = "GetAllUsersResultsForm";
            this.Text = "GetAllUsersResultsForm";
            this.Load += new System.EventHandler(this.GetAllUsersResultsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.allUsersResultsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView allUsersResultsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn countRightAnswers;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagnosis;
    }
}