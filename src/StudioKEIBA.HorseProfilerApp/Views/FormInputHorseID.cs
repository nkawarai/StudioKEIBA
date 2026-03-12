using StudioKEIBA.HorseProfilerApp.Services;

namespace StudioKEIBA.HorseProfilerApp.Views
{
    internal partial class FormInputHorseID : Form
    {
        private IHorseProfilingService _service;

        /// <summary>
        /// 入力されたID
        /// </summary>
        public string UserInput { get; private set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public FormInputHorseID(IHorseProfilingService service)
        {
            InitializeComponent();
            UserInput = string.Empty;
            _service = service;
            StartPosition = FormStartPosition.CenterParent;
        }

        /// <summary>
        /// [取得]ボタン クリックイベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _buttonExecute_Click(object sender, EventArgs e)
        {
            try
            {
                if (_service.Validate(_textBoxHorseID.Text))
                {
                    UserInput = _textBoxHorseID.Text;
                    Close();
                    return;
                }

                //不正値だった場合
                Message.ShowInformationMessage(this, "入力されたnetkeiba競走馬IDが正しくありません。");
            }
            catch (Exception ex)
            {
                Message.ShowErrorMessage(this, $"予期せぬエラーが発生しました。\n\n{ex}");
            }
        }
    }
}
