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
                var profile = await agent.GetHorseProfile(url);

                //UIに反映
                _labelHorseName.Text = $"    {profile.HorseName}";
            }
            catch (Exception ex)
            {
                Message.ShowErrorMessage(this, $"予期せぬエラーが発生しました。\n\n{ex}");
                Log.Error(ex.ToString());
            }
        }
    }
}
