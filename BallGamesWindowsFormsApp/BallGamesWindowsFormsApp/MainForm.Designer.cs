
namespace BallGamesWindowsFormsApp
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
            this.stopBallsButton = new System.Windows.Forms.Button();
            this.manyBallsButton = new System.Windows.Forms.Button();
            this.countBallsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // stopBallsButton
            // 
            this.stopBallsButton.Location = new System.Drawing.Point(939, 22);
            this.stopBallsButton.Name = "stopBallsButton";
            this.stopBallsButton.Size = new System.Drawing.Size(127, 46);
            this.stopBallsButton.TabIndex = 2;
            this.stopBallsButton.Text = "Оставновить все мячики";
            this.stopBallsButton.UseVisualStyleBackColor = true;
            this.stopBallsButton.Click += new System.EventHandler(this.stopBallsButton_Click);
            // 
            // manyBallsButton
            // 
            this.manyBallsButton.Location = new System.Drawing.Point(709, 22);
            this.manyBallsButton.Name = "manyBallsButton";
            this.manyBallsButton.Size = new System.Drawing.Size(210, 46);
            this.manyBallsButton.TabIndex = 3;
            this.manyBallsButton.Text = "Много мячиков";
            this.manyBallsButton.UseVisualStyleBackColor = true;
            this.manyBallsButton.Click += new System.EventHandler(this.manyBallsButton_Click);
            // 
            // countBallsLabel
            // 
            this.countBallsLabel.AutoSize = true;
            this.countBallsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countBallsLabel.Location = new System.Drawing.Point(613, 24);
            this.countBallsLabel.Name = "countBallsLabel";
            this.countBallsLabel.Size = new System.Drawing.Size(32, 32);
            this.countBallsLabel.TabIndex = 4;
            this.countBallsLabel.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1092, 671);
            this.Controls.Add(this.countBallsLabel);
            this.Controls.Add(this.manyBallsButton);
            this.Controls.Add(this.stopBallsButton);
            this.Name = "MainForm";
            this.Text = "Мячики";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button stopBallsButton;
        private System.Windows.Forms.Button manyBallsButton;
        private System.Windows.Forms.Label countBallsLabel;
    }
}

