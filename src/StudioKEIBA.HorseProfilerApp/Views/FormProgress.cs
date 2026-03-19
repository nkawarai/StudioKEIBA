namespace StudioKEIBA.HorseProfilerApp.Views
{
    using Services;

    public partial class FormProgress : Form, IProgressDialog
    {
        private CancellationTokenSource _cts = new CancellationTokenSource();
        public CancellationToken CancellationToken => _cts.Token;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public FormProgress()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        /// <summary>
        /// 進捗メッセージを更新する
        /// </summary>
        /// <param name="message"></param>
        public void UpdateMessage(string message)
        {
            _labelProgress.Text = message;
            Application.DoEvents();
        }

        /// <summary>
        /// 進捗率を更新する
        /// </summary>
        /// <param name="percent"></param>
        public void UpdateProgressPercent(int percent)
        {
            _progressBar.Value = percent;
            Application.DoEvents();
        }

        /// <summary>
        /// 進捗画面を閉じる
        /// </summary>
        public void CloseDialog()
        {
            Close();
            Application.DoEvents();
        }

        /// <summary>
        /// キャンセルボタンクリックイベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _buttonCancel_Click(object sender, EventArgs e)
        {
            _cts.Cancel();
        }
    }
}
