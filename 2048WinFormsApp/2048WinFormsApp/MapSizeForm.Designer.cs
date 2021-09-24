
namespace _2048WinFormsApp
{
    partial class MapSizeForm
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
            this.label = new System.Windows.Forms.Label();
            this.size5Button = new System.Windows.Forms.Button();
            this.size6Button = new System.Windows.Forms.Button();
            this.size7Button = new System.Windows.Forms.Button();
            this.size8Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.Location = new System.Drawing.Point(88, 50);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(226, 29);
            this.label.TabIndex = 0;
            this.label.Text = "Введите размер поля";
            // 
            // size5Button
            // 
            this.size5Button.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.size5Button.Location = new System.Drawing.Point(60, 111);
            this.size5Button.Name = "size5Button";
            this.size5Button.Size = new System.Drawing.Size(121, 99);
            this.size5Button.TabIndex = 1;
            this.size5Button.Text = "5x5";
            this.size5Button.UseVisualStyleBackColor = true;
            this.size5Button.Click += new System.EventHandler(this.size5Button_Click);
            // 
            // size6Button
            // 
            this.size6Button.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.size6Button.Location = new System.Drawing.Point(215, 111);
            this.size6Button.Name = "size6Button";
            this.size6Button.Size = new System.Drawing.Size(121, 99);
            this.size6Button.TabIndex = 2;
            this.size6Button.Text = "6x6";
            this.size6Button.UseVisualStyleBackColor = true;
            this.size6Button.Click += new System.EventHandler(this.size6Button_Click);
            // 
            // size7Button
            // 
            this.size7Button.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.size7Button.Location = new System.Drawing.Point(60, 245);
            this.size7Button.Name = "size7Button";
            this.size7Button.Size = new System.Drawing.Size(121, 99);
            this.size7Button.TabIndex = 3;
            this.size7Button.Text = "7x7";
            this.size7Button.UseVisualStyleBackColor = true;
            this.size7Button.Click += new System.EventHandler(this.size7Button_Click);
            // 
            // size8Button
            // 
            this.size8Button.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.size8Button.Location = new System.Drawing.Point(215, 245);
            this.size8Button.Name = "size8Button";
            this.size8Button.Size = new System.Drawing.Size(121, 99);
            this.size8Button.TabIndex = 4;
            this.size8Button.Text = "8x8";
            this.size8Button.UseVisualStyleBackColor = true;
            this.size8Button.Click += new System.EventHandler(this.size8Button_Click);
            // 
            // MapSizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 402);
            this.Controls.Add(this.size8Button);
            this.Controls.Add(this.size7Button);
            this.Controls.Add(this.size6Button);
            this.Controls.Add(this.size5Button);
            this.Controls.Add(this.label);
            this.Name = "MapSizeForm";
            this.Text = "MapSizeForm";
            this.Load += new System.EventHandler(this.MapSizeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button size5Button;
        private System.Windows.Forms.Button size6Button;
        private System.Windows.Forms.Button size7Button;
        private System.Windows.Forms.Button size8Button;
    }
}