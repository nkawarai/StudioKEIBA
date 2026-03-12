namespace StudioKEIBA.HorseProfilerApp.Views
{
    using Services;

    internal partial class FormMain : Form
    {
        private IAppServices _appServices;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public FormMain(IAppServices appServices)
        {
            InitializeComponent();
            _appServices = appServices;

            var ucHorseProfile = new UCHorseProfile(appServices);
            _displayUserControl(ucHorseProfile);
        }

        /// <summary>
        /// 指定したユーザーコントロールをメインパネルに表示する
        /// </summary>
        /// <param name="uc"></param>
        private void _displayUserControl(UserControl uc)
        {
            _mainPanel.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            _mainPanel.Controls.Add(uc);
        }
    }
}
