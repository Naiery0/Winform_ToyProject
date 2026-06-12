namespace Winform_ToyProject.Screens._1._Game
{
    partial class FrmGameReady
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGameReady));
            tbx_Name = new DevExpress.XtraEditors.TextEdit();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            btn_Exit = new DevExpress.XtraEditors.SimpleButton();
            btn_Start = new DevExpress.XtraEditors.SimpleButton();
            lbl_Feedback = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)tbx_Name.Properties).BeginInit();
            SuspendLayout();
            // 
            // tbx_Name
            // 
            tbx_Name.EditValue = "";
            tbx_Name.Location = new Point(43, 111);
            tbx_Name.Name = "tbx_Name";
            tbx_Name.Properties.Appearance.BackColor = Color.White;
            tbx_Name.Properties.Appearance.Font = new Font("Pretendard SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            tbx_Name.Properties.Appearance.ForeColor = Color.DimGray;
            tbx_Name.Properties.Appearance.Options.UseBackColor = true;
            tbx_Name.Properties.Appearance.Options.UseFont = true;
            tbx_Name.Properties.Appearance.Options.UseForeColor = true;
            tbx_Name.Properties.Appearance.Options.UseTextOptions = true;
            tbx_Name.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            tbx_Name.Size = new Size(181, 26);
            tbx_Name.TabIndex = 1;
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Pretendard SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new Point(38, 72);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(194, 19);
            labelControl2.TabIndex = 2;
            labelControl2.Text = "플레이어 이름을 입력해주세요.";
            // 
            // btn_Exit
            // 
            btn_Exit.Appearance.BackColor = Color.FromArgb(64, 64, 64);
            btn_Exit.Appearance.Font = new Font("Pretendard SemiBold", 12F, FontStyle.Bold);
            btn_Exit.Appearance.Options.UseBackColor = true;
            btn_Exit.Appearance.Options.UseFont = true;
            btn_Exit.Location = new Point(87, 219);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(93, 34);
            btn_Exit.TabIndex = 3;
            btn_Exit.Text = "메인화면";
            btn_Exit.Click += btn_Exit_Click;
            // 
            // btn_Start
            // 
            btn_Start.Appearance.Font = new Font("Pretendard SemiBold", 12F, FontStyle.Bold);
            btn_Start.Appearance.Options.UseFont = true;
            btn_Start.Location = new Point(87, 179);
            btn_Start.Name = "btn_Start";
            btn_Start.Size = new Size(93, 34);
            btn_Start.TabIndex = 4;
            btn_Start.Text = "시작하기";
            btn_Start.Click += btn_Start_Click;
            // 
            // lbl_Feedback
            // 
            lbl_Feedback.Appearance.Font = new Font("Pretendard", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lbl_Feedback.Appearance.ForeColor = Color.Red;
            lbl_Feedback.Appearance.Options.UseFont = true;
            lbl_Feedback.Appearance.Options.UseForeColor = true;
            lbl_Feedback.Location = new Point(43, 138);
            lbl_Feedback.Name = "lbl_Feedback";
            lbl_Feedback.Size = new Size(0, 13);
            lbl_Feedback.TabIndex = 5;
            // 
            // FrmGameReady
            // 
            Appearance.BackColor = Color.White;
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(271, 293);
            ControlBox = false;
            Controls.Add(lbl_Feedback);
            Controls.Add(btn_Start);
            Controls.Add(btn_Exit);
            Controls.Add(labelControl2);
            Controls.Add(tbx_Name);
            Font = new Font("Segoe UI", 9F);
            IconOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("FrmGameReady.IconOptions.SvgImage");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "FrmGameReady";
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Game Ready";
            ((System.ComponentModel.ISupportInitialize)tbx_Name.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.TextEdit tbx_Name;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btn_Exit;
        private DevExpress.XtraEditors.SimpleButton btn_Start;
        private DevExpress.XtraEditors.LabelControl lbl_Feedback;
    }
}