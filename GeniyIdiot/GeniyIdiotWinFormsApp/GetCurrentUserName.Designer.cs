
namespace GeniyIdiotWinFormsApp
{
    partial class GetCurrentUserName
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
            this.userNameRequestLabel = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.addNewQuestionButton = new System.Windows.Forms.Button();
            this.seeAllUsersResultsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userNameRequestLabel
            // 
            this.userNameRequestLabel.AutoSize = true;
            this.userNameRequestLabel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userNameRequestLabel.Location = new System.Drawing.Point(76, 84);
            this.userNameRequestLabel.Name = "userNameRequestLabel";
            this.userNameRequestLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.userNameRequestLabel.Size = new System.Drawing.Size(500, 34);
            this.userNameRequestLabel.TabIndex = 0;
            this.userNameRequestLabel.Text = "Введите фамилию, имя, отчество";
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("Segoe Script", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nextButton.Location = new System.Drawing.Point(234, 233);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(213, 112);
            this.nextButton.TabIndex = 1;
            this.nextButton.Text = "Далее";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(145, 182);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(388, 22);
            this.userNameTextBox.TabIndex = 2;
            // 
            // addNewQuestionButton
            // 
            this.addNewQuestionButton.Enabled = false;
            this.addNewQuestionButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addNewQuestionButton.Location = new System.Drawing.Point(145, 384);
            this.addNewQuestionButton.Name = "addNewQuestionButton";
            this.addNewQuestionButton.Size = new System.Drawing.Size(178, 101);
            this.addNewQuestionButton.TabIndex = 3;
            this.addNewQuestionButton.Text = "Добавить новый вопрос";
            this.addNewQuestionButton.UseVisualStyleBackColor = true;
            this.addNewQuestionButton.Click += new System.EventHandler(this.addNewQuestionButton_Click);
            // 
            // seeAllUsersResultsButton
            // 
            this.seeAllUsersResultsButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.seeAllUsersResultsButton.Location = new System.Drawing.Point(355, 384);
            this.seeAllUsersResultsButton.Name = "seeAllUsersResultsButton";
            this.seeAllUsersResultsButton.Size = new System.Drawing.Size(178, 101);
            this.seeAllUsersResultsButton.TabIndex = 4;
            this.seeAllUsersResultsButton.Text = "Посмотреть результаты других пользователей";
            this.seeAllUsersResultsButton.UseVisualStyleBackColor = true;
            this.seeAllUsersResultsButton.Click += new System.EventHandler(this.seeAllUsersResultsButton_Click);
            // 
            // GetCurrentUserName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 512);
            this.Controls.Add(this.seeAllUsersResultsButton);
            this.Controls.Add(this.addNewQuestionButton);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.userNameRequestLabel);
            this.Name = "GetCurrentUserName";
            this.Text = "Гений Идиот";
            this.Load += new System.EventHandler(this.GetCurrentUserName_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userNameRequestLabel;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Button addNewQuestionButton;
        private System.Windows.Forms.Button seeAllUsersResultsButton;
    }
}