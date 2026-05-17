namespace Winform_ToyProject.Screens
{
    partial class Uc_GameScreen
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
            btn_PageBack = new DevExpress.XtraEditors.SimpleButton();
            pnl_Heart1 = new Panel();
            pnl_Heart2 = new Panel();
            pnl_Heart3 = new Panel();
            btn_GameStart = new DevExpress.XtraEditors.SimpleButton();
            lbl_Coment = new DevExpress.XtraEditors.LabelControl();
            SuspendLayout();
            // 
            // btn_PageBack
            // 
            btn_PageBack.Location = new Point(3, 3);
            btn_PageBack.Name = "btn_PageBack";
            btn_PageBack.Size = new Size(50, 38);
            btn_PageBack.TabIndex = 9;
            btn_PageBack.Text = "<-";
            // 
            // pnl_Heart1
            // 
            pnl_Heart1.BackgroundImage = Properties.Resources.heart;
            pnl_Heart1.BackgroundImageLayout = ImageLayout.Stretch;
            pnl_Heart1.Location = new Point(572, 40);
            pnl_Heart1.Name = "pnl_Heart1";
            pnl_Heart1.Size = new Size(42, 37);
            pnl_Heart1.TabIndex = 10;
            // 
            // pnl_Heart2
            // 
            pnl_Heart2.BackgroundImage = Properties.Resources.heart;
            pnl_Heart2.BackgroundImageLayout = ImageLayout.Stretch;
            pnl_Heart2.Location = new Point(620, 40);
            pnl_Heart2.Name = "pnl_Heart2";
            pnl_Heart2.Size = new Size(42, 37);
            pnl_Heart2.TabIndex = 11;
            // 
            // pnl_Heart3
            // 
            pnl_Heart3.BackgroundImage = Properties.Resources.heart;
            pnl_Heart3.BackgroundImageLayout = ImageLayout.Stretch;
            pnl_Heart3.Location = new Point(668, 40);
            pnl_Heart3.Name = "pnl_Heart3";
            pnl_Heart3.Size = new Size(42, 37);
            pnl_Heart3.TabIndex = 12;
            // 
            // btn_GameStart
            // 
            btn_GameStart.Appearance.Font = new Font("Segoe UI", 12F);
            btn_GameStart.Appearance.Options.UseFont = true;
            btn_GameStart.Location = new Point(391, 286);
            btn_GameStart.Name = "btn_GameStart";
            btn_GameStart.Size = new Size(142, 56);
            btn_GameStart.TabIndex = 13;
            btn_GameStart.Text = "Game Start";
            btn_GameStart.Click += btn_GameStart_Click;
            // 
            // lbl_Count
            // 
            lbl_Coment.Appearance.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Coment.Appearance.Options.UseFont = true;
            lbl_Coment.Appearance.Options.UseTextOptions = true;
            lbl_Coment.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            lbl_Coment.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            lbl_Coment.Location = new Point(411, 348);
            lbl_Coment.Name = "lbl_Count";
            lbl_Coment.Size = new Size(105, 46);
            lbl_Coment.TabIndex = 14;
            lbl_Coment.Text = "[]";
            // 
            // Uc_GameScreen
            // 
            Appearance.BackColor = Color.FromArgb(238, 238, 238);
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbl_Coment);
            Controls.Add(btn_GameStart);
            Controls.Add(pnl_Heart3);
            Controls.Add(pnl_Heart2);
            Controls.Add(pnl_Heart1);
            Controls.Add(btn_PageBack);
            Name = "Uc_GameScreen";
            Size = new Size(918, 460);
            ResumeLayout(false);
        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btn_PageBack;
        private Panel pnl_Heart1;
        private Panel pnl_Heart2;
        private Panel pnl_Heart3;
        private DevExpress.XtraEditors.SimpleButton btn_GameStart;
        private DevExpress.XtraEditors.LabelControl lbl_Coment;
    }
}
