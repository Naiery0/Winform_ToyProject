namespace Winform_ToyProject.Screens._1._Game
{
    partial class FrmGameOver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGameOver));
            lbl_Score = new DevExpress.XtraEditors.LabelControl();
            lbl_Rank = new DevExpress.XtraEditors.LabelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            btn_Retry = new DevExpress.XtraEditors.SimpleButton();
            btn_Exit = new DevExpress.XtraEditors.SimpleButton();
            SuspendLayout();
            // 
            // lbl_Score
            // 
            lbl_Score.Appearance.Font = new Font("Pretendard SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lbl_Score.Appearance.Options.UseFont = true;
            lbl_Score.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            lbl_Score.Location = new Point(25, 51);
            lbl_Score.Name = "lbl_Score";
            lbl_Score.Size = new Size(213, 41);
            lbl_Score.TabIndex = 0;
            lbl_Score.Text = "SCORE : ";
            // 
            // lbl_Rank
            // 
            lbl_Rank.Appearance.Font = new Font("Pretendard SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lbl_Rank.Appearance.Options.UseFont = true;
            lbl_Rank.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            lbl_Rank.Location = new Point(39, 98);
            lbl_Rank.Name = "lbl_Rank";
            lbl_Rank.Size = new Size(199, 41);
            lbl_Rank.TabIndex = 1;
            lbl_Rank.Text = "RANK : ";
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new Font("Pretendard SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            labelControl3.Appearance.ForeColor = Color.MidnightBlue;
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Appearance.Options.UseForeColor = true;
            labelControl3.Appearance.Options.UseTextOptions = true;
            labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl3.Dock = DockStyle.Top;
            labelControl3.Location = new Point(0, 0);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(265, 45);
            labelControl3.TabIndex = 2;
            labelControl3.Text = "GAME OVER!";
            // 
            // btn_Retry
            // 
            btn_Retry.Appearance.Font = new Font("Pretendard SemiBold", 14.25F, FontStyle.Bold);
            btn_Retry.Appearance.Options.UseFont = true;
            btn_Retry.Location = new Point(63, 178);
            btn_Retry.Name = "btn_Retry";
            btn_Retry.Size = new Size(135, 34);
            btn_Retry.TabIndex = 4;
            btn_Retry.Text = "다시하기";
            btn_Retry.Click += btn_Retry_Click;
            // 
            // btn_Exit
            // 
            btn_Exit.Appearance.BackColor = Color.FromArgb(64, 64, 64);
            btn_Exit.Appearance.Font = new Font("Pretendard SemiBold", 14.25F, FontStyle.Bold);
            btn_Exit.Appearance.Options.UseBackColor = true;
            btn_Exit.Appearance.Options.UseFont = true;
            btn_Exit.Location = new Point(63, 222);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(135, 34);
            btn_Exit.TabIndex = 3;
            btn_Exit.Text = "메인화면";
            btn_Exit.Click += btn_Exit_Click;
            // 
            // FrmGameOver
            // 
            Appearance.BackColor = Color.White;
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(265, 287);
            ControlBox = false;
            Controls.Add(btn_Retry);
            Controls.Add(btn_Exit);
            Controls.Add(labelControl3);
            Controls.Add(lbl_Rank);
            Controls.Add(lbl_Score);
            IconOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("FrmGameOver.IconOptions.SvgImage");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "FrmGameOver";
            StartPosition = FormStartPosition.CenterParent;
            Text = "GameOver";
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lbl_Score;
        private DevExpress.XtraEditors.LabelControl lbl_Rank;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btn_Retry;
        private DevExpress.XtraEditors.SimpleButton btn_Exit;
    }
}