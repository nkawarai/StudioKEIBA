namespace StudioKEIBA.HorseProfilerApp.Views
{
    partial class FormProgress
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            _labelProgress = new Label();
            _progressBar = new ProgressBar();
            label2 = new Label();
            _buttonCancel = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // _labelProgress
            // 
            _labelProgress.AutoSize = true;
            _labelProgress.Font = new Font("メイリオ", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            _labelProgress.Location = new Point(16, 23);
            _labelProgress.Name = "_labelProgress";
            _labelProgress.Size = new Size(54, 23);
            _labelProgress.TabIndex = 0;
            _labelProgress.Text = "label1";
            // 
            // _progressBar
            // 
            _progressBar.Location = new Point(12, 93);
            _progressBar.Margin = new Padding(3, 4, 3, 4);
            _progressBar.Name = "_progressBar";
            _progressBar.Size = new Size(387, 31);
            _progressBar.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 69);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 2;
            label2.Text = "Processing....";
            // 
            // _buttonCancel
            // 
            _buttonCancel.Location = new Point(12, 138);
            _buttonCancel.Name = "_buttonCancel";
            _buttonCancel.Size = new Size(96, 33);
            _buttonCancel.TabIndex = 3;
            _buttonCancel.Text = "キャンセル";
            _buttonCancel.UseVisualStyleBackColor = true;
            _buttonCancel.Click += _buttonCancel_Click;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(4, 4);
            label1.Name = "label1";
            label1.Size = new Size(404, 175);
            label1.TabIndex = 4;
            // 
            // FormProgress
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 183);
            Controls.Add(_buttonCancel);
            Controls.Add(label2);
            Controls.Add(_progressBar);
            Controls.Add(_labelProgress);
            Controls.Add(label1);
            Font = new Font("メイリオ", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormProgress";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "FormProgress";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label _labelProgress;
        private ProgressBar _progressBar;
        private Label label2;
        private Button _buttonCancel;
        private Label label1;
    }
}