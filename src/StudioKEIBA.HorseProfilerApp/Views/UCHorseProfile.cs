using Serilog;
using StudioKEIBA.HorseProfilerApp.Services;

namespace StudioKEIBA.HorseProfilerApp.Views
{
    internal partial class UCHorseProfile : UserControl
    {
        private IAppServices _appServices;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public UCHorseProfile(IAppServices appServices)
        {
            InitializeComponent();
            _appServices = appServices;
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
                string horseID;
                using (var form = new FormInputHorseID(_appServices.HorseProfilingService))
                {
                    form.ShowDialog();
                    horseID = form.UserInput;
                }
                if (string.IsNullOrWhiteSpace(horseID)) return;

                var profile = await _appServices.HorseProfilingService.MakeProfile(horseID);

                _labelHorseName.Text = $"  {profile.Name}";
                _labelPedigree.Text = $"父:{profile.Pedigree.Father.HorseName}  母父:{profile.Pedigree.MotherFather.HorseName}";

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
