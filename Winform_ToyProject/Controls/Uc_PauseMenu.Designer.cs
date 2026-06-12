namespace Winform_ToyProject.Screens._1._Game
{
    partial class Uc_PauseMenu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_Exit = new DevExpress.XtraEditors.SimpleButton();
            btn_Continue = new DevExpress.XtraEditors.SimpleButton();
            SuspendLayout();
            // 
            // btn_Exit
            // 
            btn_Exit.Appearance.BackColor = Color.FromArgb(64, 64, 64);
            btn_Exit.Appearance.Font = new Font("Pretendard SemiBold", 14.25F, FontStyle.Bold);
            btn_Exit.Appearance.Options.UseBackColor = true;
            btn_Exit.Appearance.Options.UseFont = true;
            btn_Exit.Location = new Point(43, 115);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(146, 51);
            btn_Exit.TabIndex = 0;
            btn_Exit.Text = "메인화면";
            btn_Exit.Click += btn_Exit_Click;
            // 
            // btn_Continue
            // 
            btn_Continue.Appearance.Font = new Font("Pretendard SemiBold", 14.25F, FontStyle.Bold);
            btn_Continue.Appearance.Options.UseFont = true;
            btn_Continue.Location = new Point(43, 47);
            btn_Continue.Name = "btn_Continue";
            btn_Continue.Size = new Size(146, 51);
            btn_Continue.TabIndex = 1;
            btn_Continue.Text = "계속하기";
            btn_Continue.Click += btn_Continue_Click;
            // 
            // Uc_PauseMenu
            // 
            Appearance.BackColor = Color.Transparent;
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_Continue);
            Controls.Add(btn_Exit);
            Name = "Uc_PauseMenu";
            Size = new Size(230, 215);
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_Exit;
        private DevExpress.XtraEditors.SimpleButton btn_Continue;
    }
}
