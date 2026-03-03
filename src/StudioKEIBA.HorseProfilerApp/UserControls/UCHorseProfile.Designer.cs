namespace StudioKEIBA.HorseProfilerApp.UserControls
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
            SuspendLayout();
            // 
            // _buttonGetHorseProfile
            // 
            _buttonGetHorseProfile.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            _buttonGetHorseProfile.Location = new Point(3, 511);
            _buttonGetHorseProfile.Name = "_buttonGetHorseProfile";
            _buttonGetHorseProfile.Size = new Size(139, 37);
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
            _labelHorseName.Name = "_labelHorseName";
            _labelHorseName.Size = new Size(859, 41);
            _labelHorseName.TabIndex = 1;
            _labelHorseName.Text = "     (競走馬名)";
            _labelHorseName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UCHorseProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(_labelHorseName);
            Controls.Add(_buttonGetHorseProfile);
            Name = "UCHorseProfile";
            Size = new Size(859, 551);
            ResumeLayout(false);
        }

        #endregion

        private Button _buttonGetHorseProfile;
        private Label _labelHorseName;
    }
}
