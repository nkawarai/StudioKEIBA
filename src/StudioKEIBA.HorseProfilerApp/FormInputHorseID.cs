using StudioKEIBA.Netkeiba;

namespace StudioKEIBA.HorseProfilerApp
{
    public partial class FormInputHorseID : Form
    {
        /// <summary>
        /// 入力されたURL
        /// </summary>
        public IHorseURL? URL { get; private set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public FormInputHorseID()
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
            try
            {
                var horseID = ValueObjectFactory.CreateHorseID(_textBoxURL.Text);
                URL = ValueObjectFactory.CreateHorseURL(horseID);
                Close();
            }
            catch
            {
                Message.ShowInformationMessage(this, "入力されたnetkeiba競走馬IDが正しくありません。");
            }
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
