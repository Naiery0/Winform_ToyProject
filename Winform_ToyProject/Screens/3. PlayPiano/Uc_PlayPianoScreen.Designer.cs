namespace Winform_ToyProject.Screens
{
    partial class Uc_PlayPianoScreen
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
            uc_Piano1 = new Winform_ToyProject.Control.Uc_Piano();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            tbc_Octave = new DevExpress.XtraEditors.TrackBarControl();
            tbc_Volume = new DevExpress.XtraEditors.TrackBarControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            btn_Record = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)tbc_Octave).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbc_Octave.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbc_Volume).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbc_Volume.Properties).BeginInit();
            SuspendLayout();
            // 
            // btn_PageBack
            // 
            btn_PageBack.Location = new Point(3, 3);
            btn_PageBack.Name = "btn_PageBack";
            btn_PageBack.Size = new Size(50, 38);
            btn_PageBack.TabIndex = 10;
            btn_PageBack.Text = "<-";
            // 
            // uc_Piano1
            // 
            uc_Piano1.Appearance.BackColor = Color.Transparent;
            uc_Piano1.Appearance.Options.UseBackColor = true;
            uc_Piano1.Location = new Point(107, 114);
            uc_Piano1.Name = "uc_Piano1";
            uc_Piano1.Size = new Size(519, 260);
            uc_Piano1.TabIndex = 11;
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Pretendard", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new Point(107, 33);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(98, 70);
            labelControl1.TabIndex = 12;
            labelControl1.Text = "흑건:  2  3    4 5 6\r\n백건: q w e r t y u i \r\n\r\n흑건:  s  d    g  h  j  \r\n백건: z x c v b n m ,";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Pretendard", 9F);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new Point(560, 78);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(67, 14);
            labelControl2.TabIndex = 13;
            labelControl2.Text = "-, +: Volume";
            // 
            // tbc_Octave
            // 
            tbc_Octave.EditValue = 4;
            tbc_Octave.Location = new Point(633, 256);
            tbc_Octave.Name = "tbc_Octave";
            tbc_Octave.Properties.LabelAppearance.Options.UseTextOptions = true;
            tbc_Octave.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            tbc_Octave.Properties.Maximum = 7;
            tbc_Octave.Properties.Minimum = 1;
            tbc_Octave.Properties.Orientation = Orientation.Vertical;
            tbc_Octave.Properties.TickStyle = TickStyle.Both;
            tbc_Octave.Size = new Size(45, 104);
            tbc_Octave.TabIndex = 14;
            tbc_Octave.Value = 4;
            tbc_Octave.ValueChanged += tbc_Octave_ValueChanged;
            // 
            // tbc_Volume
            // 
            tbc_Volume.EditValue = 100;
            tbc_Volume.Location = new Point(632, 114);
            tbc_Volume.Name = "tbc_Volume";
            tbc_Volume.Properties.LabelAppearance.Options.UseTextOptions = true;
            tbc_Volume.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            tbc_Volume.Properties.Maximum = 127;
            tbc_Volume.Properties.Orientation = Orientation.Vertical;
            tbc_Volume.Properties.TickStyle = TickStyle.Both;
            tbc_Volume.Size = new Size(45, 104);
            tbc_Volume.TabIndex = 15;
            tbc_Volume.Value = 100;
            tbc_Volume.ValueChanged += tbc_Volume_ValueChanged;
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new Font("Pretendard", 9F);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Location = new Point(634, 216);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(42, 14);
            labelControl3.TabIndex = 16;
            labelControl3.Text = "Volume";
            // 
            // labelControl4
            // 
            labelControl4.Appearance.Font = new Font("Pretendard", 9F);
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.Location = new Point(636, 358);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(38, 14);
            labelControl4.TabIndex = 17;
            labelControl4.Text = "Octave";
            // 
            // labelControl5
            // 
            labelControl5.Appearance.Font = new Font("Pretendard", 9F);
            labelControl5.Appearance.Options.UseFont = true;
            labelControl5.Location = new Point(562, 92);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new Size(61, 14);
            labelControl5.TabIndex = 18;
            labelControl5.Text = "{,  }: Octave";
            // 
            // btn_Record
            // 
            btn_Record.Appearance.BackColor = Color.White;
            btn_Record.Appearance.Font = new Font("Pretendard", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Record.Appearance.Options.UseBackColor = true;
            btn_Record.Appearance.Options.UseFont = true;
            btn_Record.Location = new Point(333, 389);
            btn_Record.Name = "btn_Record";
            btn_Record.Size = new Size(86, 33);
            btn_Record.TabIndex = 19;
            btn_Record.Text = "Record ●";
            btn_Record.Click += btn_Record_Click;
            // 
            // Uc_PlayPianoScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_Record);
            Controls.Add(labelControl5);
            Controls.Add(labelControl4);
            Controls.Add(labelControl3);
            Controls.Add(tbc_Volume);
            Controls.Add(tbc_Octave);
            Controls.Add(labelControl2);
            Controls.Add(labelControl1);
            Controls.Add(uc_Piano1);
            Controls.Add(btn_PageBack);
            Name = "Uc_PlayPianoScreen";
            Size = new Size(730, 460);
            KeyDown += Uc_PlayPianoScreen_KeyDown;
            KeyUp += Uc_PlayPianoScreen_KeyUp;
            ((System.ComponentModel.ISupportInitialize)tbc_Octave.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbc_Octave).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbc_Volume.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbc_Volume).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btn_PageBack;
        private Control.Uc_Piano uc_Piano1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TrackBarControl tbc_Octave;
        private DevExpress.XtraEditors.TrackBarControl tbc_Volume;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btn_Record;
    }
}
