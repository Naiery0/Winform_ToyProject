namespace Winform_ToyProject.Screens
{
    partial class Uc_MainScreen
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
            btn_Playback = new DevExpress.XtraEditors.SimpleButton();
            btn_PlayPiano = new DevExpress.XtraEditors.SimpleButton();
            btn_Rank = new DevExpress.XtraEditors.SimpleButton();
            btn_GamePlay = new DevExpress.XtraEditors.SimpleButton();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            uc_Piano2 = new Winform_ToyProject.Control.Uc_Piano();
            btn_Setting = new DevExpress.XtraEditors.SimpleButton();
            btn_Exit = new DevExpress.XtraEditors.SimpleButton();
            VolumeBar = new DevExpress.XtraEditors.RangeTrackBarControl();
            ((System.ComponentModel.ISupportInitialize)VolumeBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)VolumeBar.Properties).BeginInit();
            SuspendLayout();
            // 
            // btn_Playback
            // 
            btn_Playback.Appearance.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Playback.Appearance.Options.UseFont = true;
            btn_Playback.Location = new Point(42, 227);
            btn_Playback.Name = "btn_Playback";
            btn_Playback.Size = new Size(106, 40);
            btn_Playback.TabIndex = 11;
            btn_Playback.Text = "Playback";
            btn_Playback.Click += ChangePage;
            // 
            // btn_PlayPiano
            // 
            btn_PlayPiano.Appearance.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_PlayPiano.Appearance.Options.UseFont = true;
            btn_PlayPiano.Location = new Point(42, 181);
            btn_PlayPiano.Name = "btn_PlayPiano";
            btn_PlayPiano.Size = new Size(106, 40);
            btn_PlayPiano.TabIndex = 10;
            btn_PlayPiano.Text = "Play Piano";
            btn_PlayPiano.Click += ChangePage;
            // 
            // btn_Rank
            // 
            btn_Rank.Appearance.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Rank.Appearance.Options.UseFont = true;
            btn_Rank.Location = new Point(42, 135);
            btn_Rank.Name = "btn_Rank";
            btn_Rank.Size = new Size(106, 40);
            btn_Rank.TabIndex = 9;
            btn_Rank.Text = "Rank";
            btn_Rank.Click += ChangePage;
            // 
            // btn_GamePlay
            // 
            btn_GamePlay.Appearance.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_GamePlay.Appearance.Options.UseFont = true;
            btn_GamePlay.Location = new Point(42, 89);
            btn_GamePlay.Name = "btn_GamePlay";
            btn_GamePlay.Size = new Size(106, 40);
            btn_GamePlay.TabIndex = 8;
            btn_GamePlay.Text = "Game Play";
            btn_GamePlay.Click += ChangePage;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Appearance.Options.UseTextOptions = true;
            labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            labelControl1.Location = new Point(22, 26);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(143, 47);
            labelControl1.TabIndex = 7;
            labelControl1.Text = "Toy Project";
            // 
            // uc_Piano2
            // 
            uc_Piano2.Appearance.BackColor = Color.Transparent;
            uc_Piano2.Appearance.Options.UseBackColor = true;
            uc_Piano2.Location = new Point(190, 89);
            uc_Piano2.Name = "uc_Piano2";
            uc_Piano2.Size = new Size(521, 235);
            uc_Piano2.TabIndex = 6;
            // 
            // btn_Setting
            // 
            btn_Setting.Appearance.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Setting.Appearance.Options.UseFont = true;
            btn_Setting.Location = new Point(42, 304);
            btn_Setting.Name = "btn_Setting";
            btn_Setting.Size = new Size(106, 40);
            btn_Setting.TabIndex = 12;
            btn_Setting.Text = "Setting";
            btn_Setting.Click += ChangePage;
            // 
            // btn_Exit
            // 
            btn_Exit.Appearance.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Exit.Appearance.Options.UseFont = true;
            btn_Exit.Location = new Point(42, 350);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(106, 40);
            btn_Exit.TabIndex = 13;
            btn_Exit.Text = "Exit";
            btn_Exit.Click += ChangePage;
            // 
            // VolumeBar
            // 
            VolumeBar.EditValue = new DevExpress.XtraEditors.Repository.TrackBarRange(0, 0);
            VolumeBar.Location = new Point(190, 345);
            VolumeBar.Name = "VolumeBar";
            VolumeBar.Properties.Appearance.BackColor = Color.Transparent;
            VolumeBar.Properties.Appearance.Options.UseBackColor = true;
            VolumeBar.Properties.LabelAppearance.Options.UseTextOptions = true;
            VolumeBar.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            VolumeBar.Properties.Maximum = 100;
            VolumeBar.Properties.TickStyle = TickStyle.None;
            VolumeBar.Size = new Size(222, 45);
            VolumeBar.TabIndex = 14;
            // 
            // Uc_MainScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(VolumeBar);
            Controls.Add(btn_Exit);
            Controls.Add(btn_Setting);
            Controls.Add(btn_Playback);
            Controls.Add(btn_PlayPiano);
            Controls.Add(btn_Rank);
            Controls.Add(btn_GamePlay);
            Controls.Add(labelControl1);
            Controls.Add(uc_Piano2);
            Name = "Uc_MainScreen";
            Size = new Size(730, 460);
            ((System.ComponentModel.ISupportInitialize)VolumeBar.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)VolumeBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_Playback;
        private DevExpress.XtraEditors.SimpleButton btn_PlayPiano;
        private DevExpress.XtraEditors.SimpleButton btn_Rank;
        private DevExpress.XtraEditors.SimpleButton btn_GamePlay;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private Control.Uc_Piano uc_Piano2;
        private DevExpress.XtraEditors.SimpleButton btn_Setting;
        private DevExpress.XtraEditors.SimpleButton btn_Exit;
        private DevExpress.XtraEditors.RangeTrackBarControl VolumeBar;
    }
}
