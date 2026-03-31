using StudioKEIBA.HorseProfilerApp.Views.ViewModels;
using System.Runtime.CompilerServices;

namespace StudioKEIBA.HorseProfilerApp.Extensions
{
    static public class DataGridViewEx
    {
        /// <summary>
        /// 成績表示DataGridViewを初期化する
        /// </summary>
        static internal void InitForRaceStats(this DataGridView self, string categoryName, string categoryPropertyName)
        {
            self.AutoGenerateColumns = false;
            self.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            self.ReadOnly = true;
            self.RowHeadersVisible = false;
            self.AllowUserToResizeColumns = false;
            self.AllowUserToResizeRows = false;
            self.EnableHeadersVisualStyles = false;
            self.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            self.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            self.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Black;
            self.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            self.DefaultCellStyle.SelectionBackColor = self.DefaultCellStyle.BackColor;
            self.DefaultCellStyle.SelectionForeColor = self.DefaultCellStyle.ForeColor;

            self.Columns.AddRange(new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn
                {
                    HeaderText = categoryName,
                    DataPropertyName = categoryPropertyName,
                    Width = self.ScaleWidth(120),
                    DefaultCellStyle = new DataGridViewCellStyle
                    {
                        Alignment = DataGridViewContentAlignment.MiddleCenter
                    }
                },
                new DataGridViewTextBoxColumn
                {
                    HeaderText = "着別度数",
                    DataPropertyName = nameof(IRaceStasViewModel.StatsString),
                    Width = self.ScaleWidth(100),
                    DefaultCellStyle = new DataGridViewCellStyle
                    {
                        Alignment = DataGridViewContentAlignment.MiddleCenter
                    }
                },
                new DataGridViewTextBoxColumn
                {
                    HeaderText = "勝率",
                    DataPropertyName = nameof(IRaceStasViewModel.WinRate),
                    Width = self.ScaleWidth(80),
                    DefaultCellStyle = new DataGridViewCellStyle
                    {
                        Alignment = DataGridViewContentAlignment.MiddleRight,
                        Format = "P1"
                    }
                },
                new DataGridViewTextBoxColumn
                {
                    HeaderText = "複勝率",
                    DataPropertyName = nameof(IRaceStasViewModel.Top3Rate),
                    Width = self.ScaleWidth(80),
                    DefaultCellStyle = new DataGridViewCellStyle
                    {
                        Alignment = DataGridViewContentAlignment.MiddleRight,
                        Format = "P1"
                    }
                },
            });

            //ソートはしない
            foreach (DataGridViewColumn column in self.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            // 列ヘッダはすべて中央寄せ
            self.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        /// <summary>
        /// レース成績データソースを設定する
        /// </summary>
        /// <param name="self"></param>
        /// <param name="dataSource"></param>
        static internal void SetRaceStatDataSource(this DataGridView self, IEnumerable<IRaceStasViewModel> raceStatsVM)
        {
            self.DataSource = raceStatsVM.ToList();
        }
    }
}
