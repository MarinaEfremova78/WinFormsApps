
namespace DiffusionWindowsFormsApp
{
    partial class DiffusionForm
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
            this.diffusionTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // diffusionTimer
            // 
            this.diffusionTimer.Tick += new System.EventHandler(this.diffusionTimer_Tick);
            // 
            // DiffusionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 357);
            this.Name = "DiffusionForm";
            this.Text = "Диффузия";
            this.Load += new System.EventHandler(this.DiffusionForm_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DiffusionForm_MouseClick);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer diffusionTimer;
    }
}

