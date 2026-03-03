namespace StudioKEIBA.HorseProfilerApp
{
    using UserControls;

    public partial class FormMain : Form
    {
        private UserControl _ucHorseProfile = new UCHorseProfile();

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
            _displayUserControl(_ucHorseProfile);
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
