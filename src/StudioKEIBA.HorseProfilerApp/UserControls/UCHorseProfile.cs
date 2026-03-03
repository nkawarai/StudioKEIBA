namespace StudioKEIBA.HorseProfilerApp.UserControls
{
    public partial class UCHorseProfile : UserControl
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public UCHorseProfile()
        {
            InitializeComponent();
        }

        /// <summary>
        /// [競走馬情報を取得]ボタンクリックイベントハンドラ 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _buttonGetHorseProfile_Click(object sender, EventArgs e)
        {
            string url = string.Empty;
            using (var form = new FormInputURL())
            {
                form.ShowDialog();
                url = form.URL;
            }
            if (string.IsNullOrWhiteSpace(url)) return;
        }
    }
}
