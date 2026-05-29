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
            pnl_Heart1 = new Panel();
            pnl_Heart2 = new Panel();
            pnl_Heart3 = new Panel();
            btn_GameStart = new DevExpress.XtraEditors.SimpleButton();
            lbl_Coment = new DevExpress.XtraEditors.LabelControl();
            btn_Pause = new DevExpress.XtraEditors.SimpleButton();
            btn_PageBack = new DevExpress.XtraEditors.SimpleButton();
            lbl_Test = new Label();
            pnl_Piano = new DevExpress.XtraEditors.PanelControl();
            uc_Piano1 = new Winform_ToyProject.Control.Uc_Piano();
            ((System.ComponentModel.ISupportInitialize)pnl_Piano).BeginInit();
            pnl_Piano.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_Heart1
            // 
            pnl_Heart1.BackgroundImage = Properties.Resources.heart;
            pnl_Heart1.BackgroundImageLayout = ImageLayout.Stretch;
            pnl_Heart1.Location = new Point(484, 42);
            pnl_Heart1.Name = "pnl_Heart1";
            pnl_Heart1.Size = new Size(42, 38);
            pnl_Heart1.TabIndex = 10;
            // 
            // pnl_Heart2
            // 
            pnl_Heart2.BackgroundImage = Properties.Resources.heart;
            pnl_Heart2.BackgroundImageLayout = ImageLayout.Stretch;
            pnl_Heart2.Location = new Point(532, 42);
            pnl_Heart2.Name = "pnl_Heart2";
            pnl_Heart2.Size = new Size(42, 38);
            pnl_Heart2.TabIndex = 11;
            // 
            // pnl_Heart3
            // 
            pnl_Heart3.BackgroundImage = Properties.Resources.heart;
            pnl_Heart3.BackgroundImageLayout = ImageLayout.Stretch;
            pnl_Heart3.Location = new Point(580, 42);
            pnl_Heart3.Name = "pnl_Heart3";
            pnl_Heart3.Size = new Size(42, 38);
            pnl_Heart3.TabIndex = 12;
            // 
            // btn_GameStart
            // 
            btn_GameStart.AllowFocus = false;
            btn_GameStart.Appearance.Font = new Font("Segoe UI", 12F);
            btn_GameStart.Appearance.Options.UseFont = true;
            btn_GameStart.Location = new Point(304, 325);
            btn_GameStart.Name = "btn_GameStart";
            btn_GameStart.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            btn_GameStart.Size = new Size(142, 56);
            btn_GameStart.TabIndex = 13;
            btn_GameStart.Text = "Game Start";
            btn_GameStart.Click += btn_GameStart_Click;
            // 
            // lbl_Coment
            // 
            lbl_Coment.Appearance.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Coment.Appearance.Options.UseFont = true;
            lbl_Coment.Appearance.Options.UseTextOptions = true;
            lbl_Coment.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            lbl_Coment.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            lbl_Coment.Location = new Point(323, 365);
            lbl_Coment.Name = "lbl_Coment";
            lbl_Coment.Size = new Size(105, 46);
            lbl_Coment.TabIndex = 14;
            lbl_Coment.Text = "[coment]";
            lbl_Coment.Visible = false;
            // 
            // btn_Pause
            // 
            btn_Pause.AllowFocus = false;
            btn_Pause.Appearance.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Pause.Appearance.Options.UseFont = true;
            btn_Pause.Appearance.Options.UseTextOptions = true;
            btn_Pause.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            btn_Pause.Location = new Point(682, 3);
            btn_Pause.Name = "btn_Pause";
            btn_Pause.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            btn_Pause.Size = new Size(45, 45);
            btn_Pause.TabIndex = 15;
            btn_Pause.Text = "||";
            // 
            // btn_PageBack
            // 
            btn_PageBack.AllowFocus = false;
            btn_PageBack.Location = new Point(3, 3);
            btn_PageBack.Name = "btn_PageBack";
            btn_PageBack.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            btn_PageBack.Size = new Size(45, 45);
            btn_PageBack.TabIndex = 9;
            btn_PageBack.Text = "<-";
            btn_PageBack.Click += btn_PageBack_Click;
            // 
            // lbl_Test
            // 
            lbl_Test.AutoSize = true;
            lbl_Test.Location = new Point(85, 64);
            lbl_Test.Name = "lbl_Test";
            lbl_Test.Size = new Size(114, 15);
            lbl_Test.TabIndex = 16;
            lbl_Test.Text = "Developer Test Label";
            lbl_Test.TextAlign = ContentAlignment.BottomRight;
            // 
            // pnl_Piano
            // 
            pnl_Piano.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            pnl_Piano.Controls.Add(uc_Piano1);
            pnl_Piano.Enabled = false;
            pnl_Piano.Location = new Point(112, 95);
            pnl_Piano.Name = "pnl_Piano";
            pnl_Piano.Size = new Size(521, 224);
            pnl_Piano.TabIndex = 17;
            // 
            // uc_Piano1
            // 
            uc_Piano1.Appearance.BackColor = Color.Transparent;
            uc_Piano1.Appearance.Options.UseBackColor = true;
            uc_Piano1.Dock = DockStyle.Fill;
            uc_Piano1.Location = new Point(0, 0);
            uc_Piano1.Name = "uc_Piano1";
            uc_Piano1.Size = new Size(521, 224);
            uc_Piano1.TabIndex = 0;
            // 
            // Uc_GameScreen
            // 
            Appearance.BackColor = Color.FromArgb(238, 238, 238);
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnl_Piano);
            Controls.Add(lbl_Test);
            Controls.Add(btn_Pause);
            Controls.Add(btn_GameStart);
            Controls.Add(pnl_Heart3);
            Controls.Add(pnl_Heart2);
            Controls.Add(pnl_Heart1);
            Controls.Add(btn_PageBack);
            Controls.Add(lbl_Coment);
            Name = "Uc_GameScreen";
            Size = new Size(730, 460);
            VisibleChanged += Uc_GameScreen_VisibleChanged;
            ((System.ComponentModel.ISupportInitialize)pnl_Piano).EndInit();
            pnl_Piano.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel pnl_Heart1;
        private Panel pnl_Heart2;
        private Panel pnl_Heart3;
        private DevExpress.XtraEditors.SimpleButton btn_GameStart;
        private DevExpress.XtraEditors.LabelControl lbl_Coment;
        private DevExpress.XtraEditors.SimpleButton btn_Pause;
        private DevExpress.XtraEditors.SimpleButton btn_PageBack;
        private Label lbl_Test;
        private DevExpress.XtraEditors.PanelControl pnl_Piano;
        private Control.Uc_Piano uc_Piano1;
    }
}
