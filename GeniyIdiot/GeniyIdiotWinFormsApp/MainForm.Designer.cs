
namespace GeniyIdiotWinFormsApp
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.questionNumberLabel = new System.Windows.Forms.Label();
            this.questionTextLabel = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.userAnswerTextBox = new System.Windows.Forms.TextBox();
            this.restartButton = new System.Windows.Forms.Button();
            this.oneQuestionTimer = new System.Windows.Forms.Timer(this.components);
            this.oneQuestionTimerLabel = new System.Windows.Forms.Label();
            this.SecondsLeftLabel1 = new System.Windows.Forms.Label();
            this.SecondsLeftLabel2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // questionNumberLabel
            // 
            this.questionNumberLabel.AutoSize = true;
            this.questionNumberLabel.Font = new System.Drawing.Font("Segoe Script", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.questionNumberLabel.Location = new System.Drawing.Point(351, 46);
            this.questionNumberLabel.Name = "questionNumberLabel";
            this.questionNumberLabel.Size = new System.Drawing.Size(174, 40);
            this.questionNumberLabel.TabIndex = 0;
            this.questionNumberLabel.Text = "Вопрос № 1";
            // 
            // questionTextLabel
            // 
            this.questionTextLabel.AutoSize = true;
            this.questionTextLabel.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.questionTextLabel.Location = new System.Drawing.Point(55, 114);
            this.questionTextLabel.Name = "questionTextLabel";
            this.questionTextLabel.Size = new System.Drawing.Size(167, 24);
            this.questionTextLabel.TabIndex = 1;
            this.questionTextLabel.Text = "Текст вопроса";
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nextButton.Location = new System.Drawing.Point(349, 263);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(185, 117);
            this.nextButton.TabIndex = 2;
            this.nextButton.Text = "Далее";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // userAnswerTextBox
            // 
            this.userAnswerTextBox.Location = new System.Drawing.Point(313, 195);
            this.userAnswerTextBox.Name = "userAnswerTextBox";
            this.userAnswerTextBox.Size = new System.Drawing.Size(261, 22);
            this.userAnswerTextBox.TabIndex = 3;
            this.userAnswerTextBox.UseWaitCursor = true;
            // 
            // restartButton
            // 
            this.restartButton.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.restartButton.Location = new System.Drawing.Point(614, 263);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(241, 118);
            this.restartButton.TabIndex = 4;
            this.restartButton.Text = "Пройти тест заново";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Visible = false;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // oneQuestionTimer
            // 
            this.oneQuestionTimer.Interval = 1000;
            this.oneQuestionTimer.Tick += new System.EventHandler(this.oneQuestionTimer_Tick);
            // 
            // oneQuestionTimerLabel
            // 
            this.oneQuestionTimerLabel.AutoSize = true;
            this.oneQuestionTimerLabel.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oneQuestionTimerLabel.Location = new System.Drawing.Point(16, 290);
            this.oneQuestionTimerLabel.Name = "oneQuestionTimerLabel";
            this.oneQuestionTimerLabel.Size = new System.Drawing.Size(54, 41);
            this.oneQuestionTimerLabel.TabIndex = 5;
            this.oneQuestionTimerLabel.Text = "10";
            // 
            // SecondsLeftLabel1
            // 
            this.SecondsLeftLabel1.AutoSize = true;
            this.SecondsLeftLabel1.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondsLeftLabel1.Location = new System.Drawing.Point(16, 240);
            this.SecondsLeftLabel1.Name = "SecondsLeftLabel1";
            this.SecondsLeftLabel1.Size = new System.Drawing.Size(145, 39);
            this.SecondsLeftLabel1.TabIndex = 6;
            this.SecondsLeftLabel1.Text = "Осталось";
            // 
            // SecondsLeftLabel2
            // 
            this.SecondsLeftLabel2.AutoSize = true;
            this.SecondsLeftLabel2.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondsLeftLabel2.Location = new System.Drawing.Point(12, 342);
            this.SecondsLeftLabel2.Name = "SecondsLeftLabel2";
            this.SecondsLeftLabel2.Size = new System.Drawing.Size(109, 39);
            this.SecondsLeftLabel2.TabIndex = 7;
            this.SecondsLeftLabel2.Text = "секунд";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 450);
            this.Controls.Add(this.SecondsLeftLabel2);
            this.Controls.Add(this.SecondsLeftLabel1);
            this.Controls.Add(this.oneQuestionTimerLabel);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.userAnswerTextBox);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.questionTextLabel);
            this.Controls.Add(this.questionNumberLabel);
            this.Name = "MainForm";
            this.Text = "Гений Идиот";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label questionNumberLabel;
        private System.Windows.Forms.Label questionTextLabel;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.TextBox userAnswerTextBox;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.Timer oneQuestionTimer;
        private System.Windows.Forms.Label oneQuestionTimerLabel;
        private System.Windows.Forms.Label SecondsLeftLabel1;
        private System.Windows.Forms.Label SecondsLeftLabel2;
    }
}

