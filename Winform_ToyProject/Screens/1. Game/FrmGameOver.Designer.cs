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
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            SuspendLayout();
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Pretendard SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl1.Location = new Point(25, 51);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(172, 41);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "SCORE : ";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Pretendard SemiBold", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl2.Location = new Point(39, 98);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(158, 41);
            labelControl2.TabIndex = 1;
            labelControl2.Text = "RANK : ";
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
            // simpleButton2
            // 
            simpleButton2.Appearance.Font = new Font("Pretendard SemiBold", 14.25F, FontStyle.Bold);
            simpleButton2.Appearance.Options.UseFont = true;
            simpleButton2.Location = new Point(63, 161);
            simpleButton2.Name = "simpleButton2";
            simpleButton2.Size = new Size(135, 42);
            simpleButton2.TabIndex = 4;
            simpleButton2.Text = "계속하기";
            // 
            // simpleButton1
            // 
            simpleButton1.Appearance.Font = new Font("Pretendard SemiBold", 14.25F, FontStyle.Bold);
            simpleButton1.Appearance.Options.UseFont = true;
            simpleButton1.Location = new Point(63, 218);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new Size(135, 42);
            simpleButton1.TabIndex = 3;
            simpleButton1.Text = "메인화면";
            // 
            // FrmGameOver
            // 
            Appearance.BackColor = Color.White;
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(265, 287);
            Controls.Add(simpleButton2);
            Controls.Add(simpleButton1);
            Controls.Add(labelControl3);
            Controls.Add(labelControl2);
            Controls.Add(labelControl1);
            IconOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("FrmGameOver.IconOptions.SvgImage");
            Name = "FrmGameOver";
            StartPosition = FormStartPosition.CenterParent;
            Text = "GameOver";
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}