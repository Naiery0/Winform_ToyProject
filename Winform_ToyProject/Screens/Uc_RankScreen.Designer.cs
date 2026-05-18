namespace Winform_ToyProject.Screens
{
    partial class Uc_RankScreen
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
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            btn_PageBack = new DevExpress.XtraEditors.SimpleButton();
            SuspendLayout();
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Appearance.Options.UseTextOptions = true;
            labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl1.Location = new Point(388, 207);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(143, 47);
            labelControl1.TabIndex = 9;
            labelControl1.Text = "Uc Rank";
            // 
            // btn_PageBack
            // 
            btn_PageBack.Location = new Point(3, 3);
            btn_PageBack.Name = "btn_PageBack";
            btn_PageBack.Size = new Size(50, 38);
            btn_PageBack.TabIndex = 10;
            btn_PageBack.Text = "<-";
            // 
            // Uc_RankScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_PageBack);
            Controls.Add(labelControl1);
            Name = "Uc_RankScreen";
            Size = new Size(730, 460);
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_PageBack;
    }
}
