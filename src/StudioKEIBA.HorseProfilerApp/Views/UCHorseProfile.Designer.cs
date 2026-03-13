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
            ((System.ComponentModel.ISupportInitialize)_dataGridViewHorseRaceResult).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // _buttonGetHorseProfile
            // 
            _buttonGetHorseProfile.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            _buttonGetHorseProfile.Font = new Font("メイリオ", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            _buttonGetHorseProfile.Location = new Point(5, 782);
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
            _labelHorseName.Size = new Size(1110, 63);
            _labelHorseName.TabIndex = 1;
            _labelHorseName.Text = "     (競走馬名)";
            _labelHorseName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // _labelPedigree
            // 
            _labelPedigree.AutoSize = true;
            _labelPedigree.Font = new Font("メイリオ", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            _labelPedigree.Location = new Point(21, 74);
            _labelPedigree.Margin = new Padding(4, 0, 4, 0);
            _labelPedigree.Name = "_labelPedigree";
            _labelPedigree.Size = new Size(100, 24);
            _labelPedigree.TabIndex = 2;
            _labelPedigree.Text = "<血統情報>";
            // 
            // _dataGridViewHorseRaceResult
            // 
            _dataGridViewHorseRaceResult.BackgroundColor = SystemColors.Control;
            _dataGridViewHorseRaceResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _dataGridViewHorseRaceResult.Dock = DockStyle.Fill;
            _dataGridViewHorseRaceResult.GridColor = SystemColors.ControlDark;
            _dataGridViewHorseRaceResult.Location = new Point(3, 25);
            _dataGridViewHorseRaceResult.Name = "_dataGridViewHorseRaceResult";
            _dataGridViewHorseRaceResult.Size = new Size(1096, 258);
            _dataGridViewHorseRaceResult.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(_dataGridViewHorseRaceResult);
            groupBox1.Location = new Point(5, 487);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1102, 286);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "戦歴";
            // 
            // UCHorseProfile
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Controls.Add(_labelPedigree);
            Controls.Add(_labelHorseName);
            Controls.Add(_buttonGetHorseProfile);
            Font = new Font("メイリオ", 11F, FontStyle.Regular, GraphicsUnit.Point, 128);
            Margin = new Padding(5, 6, 5, 6);
            Name = "UCHorseProfile";
            Size = new Size(1110, 842);
            Load += _ucHorseProfileLoaded;
            ((System.ComponentModel.ISupportInitialize)_dataGridViewHorseRaceResult).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button _buttonGetHorseProfile;
        private Label _labelHorseName;
        private Label _labelPedigree;
        private DataGridView _dataGridViewHorseRaceResult;
        private GroupBox groupBox1;
    }
}
