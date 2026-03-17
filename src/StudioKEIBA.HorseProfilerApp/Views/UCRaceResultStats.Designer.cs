namespace StudioKEIBA.HorseProfilerApp.Views
{
    partial class UCRaceResultStats
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            _dataGridViewRaceStats = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)_dataGridViewRaceStats).BeginInit();
            SuspendLayout();
            // 
            // _dataGridViewRaceStats
            // 
            _dataGridViewRaceStats.BackgroundColor = SystemColors.Control;
            _dataGridViewRaceStats.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _dataGridViewRaceStats.Dock = DockStyle.Fill;
            _dataGridViewRaceStats.Location = new Point(0, 0);
            _dataGridViewRaceStats.Name = "_dataGridViewRaceStats";
            _dataGridViewRaceStats.Size = new Size(349, 75);
            _dataGridViewRaceStats.TabIndex = 0;
            // 
            // UCRaceResultStats
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(_dataGridViewRaceStats);
            Name = "UCRaceResultStats";
            Size = new Size(349, 75);
            ((System.ComponentModel.ISupportInitialize)_dataGridViewRaceStats).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView _dataGridViewRaceStats;
    }
}
