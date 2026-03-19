using Serilog;
using StudioKEIBA.Horse;
using StudioKEIBA.HorseProfilerApp.Extensions;
using StudioKEIBA.HorseProfilerApp.Services;
using StudioKEIBA.HorseProfilerApp.Views.ViewModels;

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

            InitDataGridView();
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
                _dataGridViewHorseRaceResult.DataSource = profile.HorseRaceResults.ConvertToHorseRaceResultViewModels();
                _dataGridViewHorseRaceResult.Visible = true;
                _dataGridViewHorseRaceResult.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                //集計と結果表示
                _dataGridViewRaceCourseStats.SetRaceStatDataSource(profile.HorseRaceResults.ConvertToRaceCourseStatsVM());
                _dataGridViewCourseShapeStats.SetRaceStatDataSource(profile.HorseRaceResults.ConvertToCourseShapeStatsVM());
                _dataGridViewDistanceRotationStats.SetRaceStatDataSource(profile.HorseRaceResults.ConvertToDistanceRotationStatsVM());
                _dataGridViewSummaryStats.SetRaceStatDataSource(profile.HorseRaceResults.ConvertToSummaryStatsVM());
                _dataGridViewSeasonStats.SetRaceStatDataSource(profile.HorseRaceResults.ConvertToSeasonStatsVM());
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

        private void InitDataGridView()
        {
            InitHorseRaceResultDataGridView();
            _dataGridViewRaceCourseStats.InitForRaceStats("競馬場", nameof(IRaceStasViewModel.ItemName));
            _dataGridViewCourseShapeStats.InitForRaceStats("項目", nameof(IRaceStasViewModel.ItemName));
            _dataGridViewDistanceRotationStats.InitForRaceStats("ローテ", nameof(IRaceStasViewModel.ItemName));
            _dataGridViewSummaryStats.InitForRaceStats("項目", nameof(IRaceStasViewModel.ItemName));
            _dataGridViewSeasonStats.InitForRaceStats("時期", nameof(IRaceStasViewModel.ItemName));

            var emptyHorseRaceResults = new List<IHorseRaceResult>(); //UI初期化用の空データ
            _dataGridViewRaceCourseStats.SetRaceStatDataSource(emptyHorseRaceResults.ConvertToRaceCourseStatsVM());
            _dataGridViewCourseShapeStats.SetRaceStatDataSource(emptyHorseRaceResults.ConvertToCourseShapeStatsVM());
            _dataGridViewDistanceRotationStats.SetRaceStatDataSource(emptyHorseRaceResults.ConvertToDistanceRotationStatsVM());
            _dataGridViewSummaryStats.SetRaceStatDataSource(emptyHorseRaceResults.ConvertToSummaryStatsVM());
            _dataGridViewSeasonStats.SetRaceStatDataSource(emptyHorseRaceResults.ConvertToSeasonStatsVM());

        }

        /// <summary>
        /// 競走馬戦歴データテーブルを初期化する
        /// </summary>
        private void InitHorseRaceResultDataGridView()
        {
            _dataGridViewHorseRaceResult.AutoGenerateColumns = false;
            _dataGridViewHorseRaceResult.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _dataGridViewHorseRaceResult.ReadOnly = true;
            _dataGridViewHorseRaceResult.RowHeadersVisible = false;
            _dataGridViewHorseRaceResult.Font = new Font(_dataGridViewHorseRaceResult.Font.FontFamily, 10);
            _dataGridViewHorseRaceResult.AutoSize = true;
            _dataGridViewHorseRaceResult.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            _dataGridViewHorseRaceResult.MultiSelect = false;
            _dataGridViewHorseRaceResult.AllowUserToResizeColumns = false;
            _dataGridViewHorseRaceResult.AllowUserToResizeRows = false;

            // 列定義
            _dataGridViewHorseRaceResult.Columns.AddRange(new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn
                {
                    HeaderText = "日付",
                    DataPropertyName = nameof(HorseRaceResultViewModel.Date),
                },
                new DataGridViewTextBoxColumn
                {
                    HeaderText = "レース名",
                    DataPropertyName = nameof(HorseRaceResultViewModel.RaceName),
                },
                new DataGridViewTextBoxColumn
                {
                    HeaderText = "コース",
                    DataPropertyName = nameof(HorseRaceResultViewModel.RaceTrackName),
                },
                new DataGridViewTextBoxColumn
                {
                    HeaderText = "馬場",
                    DataPropertyName = nameof(HorseRaceResultViewModel.TrackCondition),
                },
                new DataGridViewTextBoxColumn
                {
                    HeaderText = "枠番",
                    DataPropertyName = nameof(HorseRaceResultViewModel.Wakuban),
                    DefaultCellStyle = new DataGridViewCellStyle
                    {
                        Alignment = DataGridViewContentAlignment.MiddleRight
                    },
                },
                new DataGridViewTextBoxColumn
                {
                    HeaderText = "馬番",
                    DataPropertyName = nameof(HorseRaceResultViewModel.Umaban),
                    DefaultCellStyle = new DataGridViewCellStyle
                    {
                        Alignment = DataGridViewContentAlignment.MiddleRight
                    },
                },
                new DataGridViewTextBoxColumn
                {
                    HeaderText = "着順",
                    DataPropertyName = nameof(HorseRaceResultViewModel.Rank),
                    DefaultCellStyle = new DataGridViewCellStyle
                    {
                        Alignment = DataGridViewContentAlignment.MiddleRight
                    },
                },
                new DataGridViewTextBoxColumn
                {
                    HeaderText = "騎手",
                    DataPropertyName = nameof(HorseRaceResultViewModel.JockeyAndWeight),
                },
                new DataGridViewTextBoxColumn
                {
                    HeaderText = "あがり",
                    DataPropertyName = nameof(HorseRaceResultViewModel.Agari),
                },
                new DataGridViewTextBoxColumn
                {
                    HeaderText = "距離ローテ",
                    DataPropertyName = nameof(HorseRaceResultViewModel.DistanceRotation),
                    DefaultCellStyle = new DataGridViewCellStyle
                    {
                        Alignment = DataGridViewContentAlignment.MiddleCenter
                    },
                },
                new DataGridViewTextBoxColumn
                {
                    HeaderText = "急坂",
                    DataPropertyName = nameof(HorseRaceResultViewModel.HasSlope),
                    DefaultCellStyle = new DataGridViewCellStyle
                    {
                        Alignment = DataGridViewContentAlignment.MiddleCenter
                    },
                },
                new DataGridViewTextBoxColumn
                {
                    HeaderText = "小回",
                    DataPropertyName = nameof(HorseRaceResultViewModel.HasTightCorner),
                    DefaultCellStyle = new DataGridViewCellStyle
                    {
                        Alignment = DataGridViewContentAlignment.MiddleCenter
                    },
                },
                new DataGridViewTextBoxColumn
                {
                    HeaderText = "短直",
                    DataPropertyName = nameof(HorseRaceResultViewModel.HomeStratchIsShort),
                    DefaultCellStyle = new DataGridViewCellStyle
                    {
                        Alignment = DataGridViewContentAlignment.MiddleCenter
                    },
                },
                new DataGridViewTextBoxColumn
                {
                    HeaderText = "内外",
                    DataPropertyName = nameof(HorseRaceResultViewModel.UchiSoto),
                    DefaultCellStyle = new DataGridViewCellStyle
                    {
                        Alignment = DataGridViewContentAlignment.MiddleCenter
                    },
                },
                new DataGridViewTextBoxColumn
                {
                    HeaderText = "間隔",
                    DataPropertyName = nameof(HorseRaceResultViewModel.RaceInterval),
                    DefaultCellStyle = new DataGridViewCellStyle
                    {
                        Alignment = DataGridViewContentAlignment.MiddleCenter
                    },
                },
            });

            //ソートはしない
            foreach (DataGridViewColumn column in _dataGridViewHorseRaceResult.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            // 列ヘッダはすべて中央寄せ
            _dataGridViewHorseRaceResult.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //行の色定義(着順)
            _dataGridViewHorseRaceResult.CellFormatting += (sender, e) =>
            {
                if (e.RowIndex < 0) return;
                var item = _dataGridViewHorseRaceResult.Rows[e.RowIndex].DataBoundItem as HorseRaceResultViewModel;
                if (item == null) return;
                switch (item.Rank)
                {
                    case "1":
                    case "2":
                    case "3":
                        _dataGridViewHorseRaceResult.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Gold;
                        break;
                    default:
                        _dataGridViewHorseRaceResult.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                        break;
                }
            };

            //画面起動時は非表示
            _dataGridViewHorseRaceResult.Visible = false;
        }
    }
}
