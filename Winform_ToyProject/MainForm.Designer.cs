using Winform_ToyProject.Control;

namespace Winform_ToyProject
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            uc_Piano1 = new Uc_Piano();
            SuspendLayout();
            // 
            // uc_Piano1
            // 
            uc_Piano1.Appearance.BackColor = Color.Transparent;
            uc_Piano1.Appearance.Options.UseBackColor = true;
            uc_Piano1.Location = new Point(149, 12);
            uc_Piano1.Name = "uc_Piano1";
            uc_Piano1.Size = new Size(668, 426);
            uc_Piano1.TabIndex = 0;
            // 
            // MainForm
            // 
            Appearance.Options.UseFont = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 551);
            Controls.Add(uc_Piano1);
            Font = new Font("Segoe UI", 9F);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Uc_Piano uc_Piano1;
    }
}
