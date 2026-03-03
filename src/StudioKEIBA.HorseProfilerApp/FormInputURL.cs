namespace StudioKEIBA.HorseProfilerApp
{
    public partial class FormInputURL : Form
    {
        /// <summary>
        /// 入力されたURL
        /// </summary>
        public string URL { get; private set; } = string.Empty;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public FormInputURL()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
        }

        /// <summary>
        /// [取得]ボタン クリックイベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _buttonExecute_Click(object sender, EventArgs e)
        {
            //TODO 入力されたURLの妥当性検証
            URL = _textBoxURL.Text;
            Close();
        }

        /// <summary>
        /// [キャンセル]ボタン クリックイベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
