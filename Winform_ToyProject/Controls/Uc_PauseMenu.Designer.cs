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
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            SuspendLayout();
            // 
            // simpleButton1
            // 
            simpleButton1.Appearance.Font = new Font("Pretendard SemiBold", 14.25F, FontStyle.Bold);
            simpleButton1.Appearance.Options.UseFont = true;
            simpleButton1.Location = new Point(43, 115);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new Size(146, 51);
            simpleButton1.TabIndex = 0;
            simpleButton1.Text = "메인화면";
            // 
            // simpleButton2
            // 
            simpleButton2.Appearance.Font = new Font("Pretendard SemiBold", 14.25F, FontStyle.Bold);
            simpleButton2.Appearance.Options.UseFont = true;
            simpleButton2.Location = new Point(43, 47);
            simpleButton2.Name = "simpleButton2";
            simpleButton2.Size = new Size(146, 51);
            simpleButton2.TabIndex = 1;
            simpleButton2.Text = "계속하기";
            // 
            // Uc_GamePauseMenu
            // 
            Appearance.BackColor = Color.Transparent;
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(simpleButton2);
            Controls.Add(simpleButton1);
            Name = "Uc_GamePauseMenu";
            Size = new Size(230, 215);
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}
