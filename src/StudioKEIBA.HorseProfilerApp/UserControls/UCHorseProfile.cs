using Serilog;
using StudioKEIBA.Netkeiba;

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
        async private void _buttonGetHorseProfile_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                IHorseURL? url;
                using (var form = new FormInputHorseID())
                {
                    form.ShowDialog();
                    url = form.URL;
                }
                if (url == null) return;

                var agent = AgentFactory.CreateHorseScraperAgent();
                var horseName = await agent.GetHorseName(url);
                Thread.Sleep(1000);

                var pedigree = await agent.GetPedigree(url);
                Thread.Sleep(1000);

                _labelHorseName.Text = $"  {horseName}";
                _labelPedigree.Text = $"父:{pedigree.Father.HorseName}  母父:{pedigree.MotherFather.HorseName}";

            }
            catch (Exception ex)
            {
                Message.ShowErrorMessage(this, $"予期せぬエラーが発生しました。\n\n{ex}");
                Log.Error(ex.ToString());
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        /// <summary>
        /// Loadイベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _ucHorseProfileLoaded(object sender, EventArgs e)
        {
            _labelHorseName.Text = "競走馬情報を取得してください";
            _labelPedigree.Text = string.Empty;
        }
    }
}
