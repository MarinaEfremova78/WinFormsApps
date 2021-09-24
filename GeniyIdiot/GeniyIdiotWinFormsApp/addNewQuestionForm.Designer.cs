
namespace GeniyIdiotWinFormsApp
{
    partial class addNewQuestionForm
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
            this.newQuestionRequestLabel = new System.Windows.Forms.Label();
            this.newQuestionTextBox = new System.Windows.Forms.TextBox();
            this.newAnswerRequestLabel = new System.Windows.Forms.Label();
            this.newAnswerTextBox = new System.Windows.Forms.TextBox();
            this.addNewQuestionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newQuestionRequestLabel
            // 
            this.newQuestionRequestLabel.AutoSize = true;
            this.newQuestionRequestLabel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newQuestionRequestLabel.Location = new System.Drawing.Point(51, 39);
            this.newQuestionRequestLabel.Name = "newQuestionRequestLabel";
            this.newQuestionRequestLabel.Size = new System.Drawing.Size(288, 28);
            this.newQuestionRequestLabel.TabIndex = 0;
            this.newQuestionRequestLabel.Text = "Введите новый вопрос";
            // 
            // newQuestionTextBox
            // 
            this.newQuestionTextBox.Location = new System.Drawing.Point(54, 105);
            this.newQuestionTextBox.Name = "newQuestionTextBox";
            this.newQuestionTextBox.Size = new System.Drawing.Size(332, 22);
            this.newQuestionTextBox.TabIndex = 2;
            // 
            // newAnswerRequestLabel
            // 
            this.newAnswerRequestLabel.AutoSize = true;
            this.newAnswerRequestLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newAnswerRequestLabel.Location = new System.Drawing.Point(54, 185);
            this.newAnswerRequestLabel.Name = "newAnswerRequestLabel";
            this.newAnswerRequestLabel.Size = new System.Drawing.Size(341, 23);
            this.newAnswerRequestLabel.TabIndex = 3;
            this.newAnswerRequestLabel.Text = "Введите ответ на новый вопрос";
            // 
            // newAnswerTextBox
            // 
            this.newAnswerTextBox.Location = new System.Drawing.Point(54, 254);
            this.newAnswerTextBox.Name = "newAnswerTextBox";
            this.newAnswerTextBox.Size = new System.Drawing.Size(332, 22);
            this.newAnswerTextBox.TabIndex = 4;
            // 
            // addNewQuestionButton
            // 
            this.addNewQuestionButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.addNewQuestionButton.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addNewQuestionButton.Location = new System.Drawing.Point(130, 327);
            this.addNewQuestionButton.Name = "addNewQuestionButton";
            this.addNewQuestionButton.Size = new System.Drawing.Size(183, 113);
            this.addNewQuestionButton.TabIndex = 5;
            this.addNewQuestionButton.Text = "Добавить";
            this.addNewQuestionButton.UseVisualStyleBackColor = false;
            this.addNewQuestionButton.Click += new System.EventHandler(this.addNewQuestionButton_Click);
            // 
            // addNewQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 487);
            this.Controls.Add(this.addNewQuestionButton);
            this.Controls.Add(this.newAnswerTextBox);
            this.Controls.Add(this.newAnswerRequestLabel);
            this.Controls.Add(this.newQuestionTextBox);
            this.Controls.Add(this.newQuestionRequestLabel);
            this.Name = "addNewQuestionForm";
            this.Text = "addNewQuestionForm";
            this.Load += new System.EventHandler(this.addNewQuestionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label newQuestionRequestLabel;
        private System.Windows.Forms.TextBox newQuestionTextBox;
        private System.Windows.Forms.Label newAnswerRequestLabel;
        private System.Windows.Forms.TextBox newAnswerTextBox;
        private System.Windows.Forms.Button addNewQuestionButton;
    }
}