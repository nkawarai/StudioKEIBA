using StudioKEIBA.Racing;

namespace StudioKEIBA.HorseProfilerApp.Views
{
    public partial class UCRaceResultStats : UserControl
    {
        public UCRaceResultStats(IRaceStats stats)
        {
            InitializeComponent();
            if (stats == null) return;
            InitializeDataGridView(stats);
        }

        private void InitializeDataGridView(IRaceStats stats)
        {
            _dataGridViewRaceStats.AutoGenerateColumns = false;
            _dataGridViewRaceStats.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _dataGridViewRaceStats.ReadOnly = true;
            _dataGridViewRaceStats.RowHeadersVisible = false;
            _dataGridViewRaceStats.AllowUserToResizeColumns = false;
            _dataGridViewRaceStats.AllowUserToResizeRows = false;
            _dataGridViewRaceStats.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            foreach (DataGridViewColumn column in _dataGridViewRaceStats.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            _dataGridViewRaceStats.Columns.AddRange(new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn
                {
                    HeaderText = "着別度数",
                    Name = nameof(IRaceStats.DisplayString),
                    DefaultCellStyle = new DataGridViewCellStyle
                    {
                        Alignment = DataGridViewContentAlignment.MiddleCenter
                    }
                },
                new DataGridViewTextBoxColumn
                {
                    HeaderText = "勝率",
                    Name = nameof(IRaceStats.WinRate),
                    DefaultCellStyle = new DataGridViewCellStyle
                    {
                        Alignment = DataGridViewContentAlignment.MiddleCenter,
                        Format = "P1"
                    }
                },
                new DataGridViewTextBoxColumn
                {
                    HeaderText = "複勝率",
                    Name = nameof(IRaceStats.Top3Rate),
                    DefaultCellStyle = new DataGridViewCellStyle
                    {
                        Alignment = DataGridViewContentAlignment.MiddleCenter,
                        Format = "P1"
                    }
                },
            });

            var row = new
            {
                DisplayString = stats.DisplayString(),
                WinRate = stats.WinRate,
                Top3Rate = stats.Top3Rate,
            };

            _dataGridViewRaceStats.DataSource = new[] { row }.ToList();
            _dataGridViewRaceStats.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
    }
}
