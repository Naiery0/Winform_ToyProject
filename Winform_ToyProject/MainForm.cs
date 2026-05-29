using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using Winform_ToyProject.Screens;

namespace Winform_ToyProject
{
    public partial class MainForm : XtraForm
    {
        #region instance
        private static MainForm? instance;
        public static MainForm Instance
        {
            get
            {
                if (instance == null)
                    instance = new MainForm();
                return instance;
            }
        }
        #endregion

        protected MainForm()
        {
            InitializeComponent();

            xtraTabControl.TabPages.Clear();

            InitView(new Uc_MainScreen());
            InitView(new Uc_GameScreen());
            InitView(new Uc_RankScreen());
            InitView(new Uc_PlayPianoScreen());
            InitView(new Uc_PlaybackScreen());
            InitView(new Uc_SettingScreen());

            xtraTabControl.SelectedTabPageIndex = 0;
        }

        private void InitView(XtraUserControl Uc)
        {
            XtraTabPage page = new XtraTabPage();
            Uc.Dock = DockStyle.Fill;

            page.Controls.Add(Uc);
            xtraTabControl.TabPages.Add(page);
        }

        public void TabChange(int index) => xtraTabControl.SelectedTabPageIndex = index;
    }
}
