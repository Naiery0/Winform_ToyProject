namespace Winform_ToyProject.Controls
{
    partial class FrmPauseMenu
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
            btn_Continue = new DevExpress.XtraEditors.SimpleButton();
            btn_Exit = new DevExpress.XtraEditors.SimpleButton();
            SuspendLayout();
            // 
            // btn_Continue
            // 
            btn_Continue.Appearance.Font = new Font("Pretendard SemiBold", 14.25F, FontStyle.Bold);
            btn_Continue.Appearance.Options.UseFont = true;
            btn_Continue.Location = new Point(52, 59);
            btn_Continue.Name = "btn_Continue";
            btn_Continue.Size = new Size(146, 51);
            btn_Continue.TabIndex = 3;
            btn_Continue.Text = "계속하기";
            btn_Continue.Click += this.btn_Continue_Click;
            // 
            // btn_Exit
            // 
            btn_Exit.Appearance.BackColor = Color.FromArgb(64, 64, 64);
            btn_Exit.Appearance.Font = new Font("Pretendard SemiBold", 14.25F, FontStyle.Bold);
            btn_Exit.Appearance.Options.UseBackColor = true;
            btn_Exit.Appearance.Options.UseFont = true;
            btn_Exit.Location = new Point(52, 127);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(146, 51);
            btn_Exit.TabIndex = 2;
            btn_Exit.Text = "메인화면";
            btn_Exit.Click += btn_Exit_Click;
            // 
            // FrmPauseMenu
            // 
            Appearance.BackColor = Color.Transparent;
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(250, 237);
            Controls.Add(btn_Continue);
            Controls.Add(btn_Exit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPauseMenu";
            Text = "FrmPauseMenu";
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_Continue;
        private DevExpress.XtraEditors.SimpleButton btn_Exit;
    }
}