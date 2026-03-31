namespace StudioKEIBA.HorseProfilerApp.Views
{
    partial class UCHorseProfile
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
            _buttonGetHorseProfile = new Button();
            _labelHorseName = new Label();
            _labelPedigree = new Label();
            _dataGridViewHorseRaceResult = new DataGridView();
            groupBox1 = new GroupBox();
            _dataGridViewRaceCourseStats = new DataGridView();
            _dataGridViewCourseShapeStats = new DataGridView();
            _dataGridViewDistanceRotationStats = new DataGridView();
            _dataGridViewSummaryStats = new DataGridView();
            _dataGridViewSeasonStats = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)_dataGridViewHorseRaceResult).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_dataGridViewRaceCourseStats).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_dataGridViewCourseShapeStats).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_dataGridViewDistanceRotationStats).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_dataGridViewSummaryStats).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_dataGridViewSeasonStats).BeginInit();
            SuspendLayout();
            // 
            // _buttonGetHorseProfile
            // 
            _buttonGetHorseProfile.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            _buttonGetHorseProfile.Font = new Font("メイリオ", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            _buttonGetHorseProfile.Location = new Point(5, 1227);
            _buttonGetHorseProfile.Margin = new Padding(5, 6, 5, 6);
            _buttonGetHorseProfile.Name = "_buttonGetHorseProfile";
            _buttonGetHorseProfile.Size = new Size(262, 55);
            _buttonGetHorseProfile.TabIndex = 0;
            _buttonGetHorseProfile.Text = "競走馬情報を取得";
            _buttonGetHorseProfile.UseVisualStyleBackColor = true;
            _buttonGetHorseProfile.Click += _buttonGetHorseProfile_Click;
            // 
            // _labelHorseName
            // 
            _labelHorseName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            _labelHorseName.BackColor = Color.DarkBlue;
            _labelHorseName.Font = new Font("メイリオ", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            _labelHorseName.ForeColor = Color.White;
            _labelHorseName.Location = new Point(0, 0);
            _labelHorseName.Margin = new Padding(5, 0, 5, 0);
            _labelHorseName.Name = "_labelHorseName";
            _labelHorseName.Size = new Size(1759, 63);
            _labelHorseName.TabIndex = 1;
            _labelHorseName.Text = "     (競走馬名)";
            _labelHorseName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // _labelPedigree
            // 
            _labelPedigree.AutoSize = true;
            _labelPedigree.Font = new Font("メイリオ", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            _labelPedigree.Location = new Point(8, 77);
            _labelPedigree.Margin = new Padding(4, 0, 4, 0);
            _labelPedigree.Name = "_labelPedigree";
            _labelPedigree.Size = new Size(149, 36);
            _labelPedigree.TabIndex = 2;
            _labelPedigree.Text = "<血統情報>";
            // 
            // _dataGridViewHorseRaceResult
            // 
            _dataGridViewHorseRaceResult.BackgroundColor = SystemColors.Control;
            _dataGridViewHorseRaceResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _dataGridViewHorseRaceResult.Dock = DockStyle.Fill;
            _dataGridViewHorseRaceResult.GridColor = SystemColors.ControlDark;
            _dataGridViewHorseRaceResult.Location = new Point(3, 36);
            _dataGridViewHorseRaceResult.Name = "_dataGridViewHorseRaceResult";
            _dataGridViewHorseRaceResult.RowHeadersWidth = 62;
            _dataGridViewHorseRaceResult.Size = new Size(1745, 481);
            _dataGridViewHorseRaceResult.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(_dataGridViewHorseRaceResult);
            groupBox1.Location = new Point(8, 698);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1751, 520);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "戦歴";
            // 
            // _dataGridViewRaceCourseStats
            // 
            _dataGridViewRaceCourseStats.BackgroundColor = SystemColors.Control;
            _dataGridViewRaceCourseStats.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _dataGridViewRaceCourseStats.Location = new Point(5, 322);
            _dataGridViewRaceCourseStats.Name = "_dataGridViewRaceCourseStats";
            _dataGridViewRaceCourseStats.RowHeadersWidth = 62;
            _dataGridViewRaceCourseStats.Size = new Size(573, 370);
            _dataGridViewRaceCourseStats.TabIndex = 6;
            // 
            // _dataGridViewCourseShapeStats
            // 
            _dataGridViewCourseShapeStats.BackgroundColor = SystemColors.Control;
            _dataGridViewCourseShapeStats.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _dataGridViewCourseShapeStats.Location = new Point(587, 322);
            _dataGridViewCourseShapeStats.Name = "_dataGridViewCourseShapeStats";
            _dataGridViewCourseShapeStats.RowHeadersWidth = 62;
            _dataGridViewCourseShapeStats.Size = new Size(573, 206);
            _dataGridViewCourseShapeStats.TabIndex = 7;
            // 
            // _dataGridViewDistanceRotationStats
            // 
            _dataGridViewDistanceRotationStats.BackgroundColor = SystemColors.Control;
            _dataGridViewDistanceRotationStats.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _dataGridViewDistanceRotationStats.Location = new Point(587, 144);
            _dataGridViewDistanceRotationStats.Name = "_dataGridViewDistanceRotationStats";
            _dataGridViewDistanceRotationStats.RowHeadersWidth = 62;
            _dataGridViewDistanceRotationStats.Size = new Size(573, 172);
            _dataGridViewDistanceRotationStats.TabIndex = 8;
            // 
            // _dataGridViewSummaryStats
            // 
            _dataGridViewSummaryStats.BackgroundColor = SystemColors.Control;
            _dataGridViewSummaryStats.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _dataGridViewSummaryStats.Location = new Point(8, 144);
            _dataGridViewSummaryStats.Name = "_dataGridViewSummaryStats";
            _dataGridViewSummaryStats.RowHeadersWidth = 62;
            _dataGridViewSummaryStats.ScrollBars = ScrollBars.None;
            _dataGridViewSummaryStats.Size = new Size(573, 139);
            _dataGridViewSummaryStats.TabIndex = 9;
            // 
            // _dataGridViewSeasonStats
            // 
            _dataGridViewSeasonStats.BackgroundColor = SystemColors.Control;
            _dataGridViewSeasonStats.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _dataGridViewSeasonStats.Location = new Point(1166, 144);
            _dataGridViewSeasonStats.Name = "_dataGridViewSeasonStats";
            _dataGridViewSeasonStats.RowHeadersWidth = 62;
            _dataGridViewSeasonStats.Size = new Size(573, 172);
            _dataGridViewSeasonStats.TabIndex = 10;
            // 
            // UCHorseProfile
            // 
            AutoScaleDimensions = new SizeF(13F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(_dataGridViewSeasonStats);
            Controls.Add(_dataGridViewSummaryStats);
            Controls.Add(_dataGridViewDistanceRotationStats);
            Controls.Add(_dataGridViewCourseShapeStats);
            Controls.Add(_dataGridViewRaceCourseStats);
            Controls.Add(groupBox1);
            Controls.Add(_labelPedigree);
            Controls.Add(_labelHorseName);
            Controls.Add(_buttonGetHorseProfile);
            Font = new Font("メイリオ", 11F, FontStyle.Regular, GraphicsUnit.Point, 128);
            Margin = new Padding(5, 6, 5, 6);
            Name = "UCHorseProfile";
            Size = new Size(1759, 1287);
            Load += _ucHorseProfileLoaded;
            ((System.ComponentModel.ISupportInitialize)_dataGridViewHorseRaceResult).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_dataGridViewRaceCourseStats).EndInit();
            ((System.ComponentModel.ISupportInitialize)_dataGridViewCourseShapeStats).EndInit();
            ((System.ComponentModel.ISupportInitialize)_dataGridViewDistanceRotationStats).EndInit();
            ((System.ComponentModel.ISupportInitialize)_dataGridViewSummaryStats).EndInit();
            ((System.ComponentModel.ISupportInitialize)_dataGridViewSeasonStats).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button _buttonGetHorseProfile;
        private Label _labelHorseName;
        private Label _labelPedigree;
        private DataGridView _dataGridViewHorseRaceResult;
        private GroupBox groupBox1;
        private DataGridView _dataGridViewRaceCourseStats;
        private DataGridView _dataGridViewCourseShapeStats;
        private DataGridView _dataGridViewDistanceRotationStats;
        private DataGridView _dataGridViewSummaryStats;
        private DataGridView _dataGridViewSeasonStats;
    }
}
