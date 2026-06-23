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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            btn_PageBack = new DevExpress.XtraEditors.SimpleButton();
            crt_Rank = new DevExpress.XtraCharts.ChartControl();
            btn_Init = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)crt_Rank).BeginInit();
            ((System.ComponentModel.ISupportInitialize)xyDiagram1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)series1).BeginInit();
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
            // crt_Rank
            // 
            crt_Rank.AppearanceNameSerializable = "Light";
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            crt_Rank.Diagram = xyDiagram1;
            crt_Rank.Legend.DXFont = new DevExpress.Drawing.DXFont("Pretendard", 8F);
            crt_Rank.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            crt_Rank.Location = new Point(16, 47);
            crt_Rank.Name = "crt_Rank";
            crt_Rank.PaletteBaseColorNumber = 5;
            crt_Rank.PaletteName = "Equity";
            series1.Name = "Series 1";
            series1.SeriesID = 0;
            crt_Rank.SeriesSerializable = new DevExpress.XtraCharts.Series[]
    {
    series1
    };
            crt_Rank.Size = new Size(697, 396);
            crt_Rank.TabIndex = 11;
            // 
            // btn_Init
            // 
            btn_Init.Appearance.BackColor = Color.FromArgb(192, 0, 0);
            btn_Init.Appearance.Font = new Font("Pretendard", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btn_Init.Appearance.Options.UseBackColor = true;
            btn_Init.Appearance.Options.UseFont = true;
            btn_Init.Location = new Point(636, 14);
            btn_Init.Name = "btn_Init";
            btn_Init.Size = new Size(77, 27);
            btn_Init.TabIndex = 12;
            btn_Init.Text = "초기화";
            btn_Init.Click += btn_Init_Click;
            // 
            // Uc_RankScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_Init);
            Controls.Add(crt_Rank);
            Controls.Add(btn_PageBack);
            Name = "Uc_RankScreen";
            Size = new Size(730, 460);
            VisibleChanged += Uc_RankScreen_VisibleChanged;
            ((System.ComponentModel.ISupportInitialize)xyDiagram1).EndInit();
            ((System.ComponentModel.ISupportInitialize)series1).EndInit();
            ((System.ComponentModel.ISupportInitialize)crt_Rank).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btn_PageBack;
        private DevExpress.XtraCharts.ChartControl crt_Rank;
        private DevExpress.XtraEditors.SimpleButton btn_Init;
    }
}
