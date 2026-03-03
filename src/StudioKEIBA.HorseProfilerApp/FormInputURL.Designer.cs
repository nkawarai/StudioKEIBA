namespace StudioKEIBA.HorseProfilerApp
{
    partial class FormInputURL
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
            label1 = new Label();
            label2 = new Label();
            _textBoxURL = new TextBox();
            _buttonExecute = new Button();
            _buttonCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(241, 15);
            label1.TabIndex = 0;
            label1.Text = "netkeibaの競走馬ページのURLを入力してください";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 34);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 1;
            // 
            // _textBoxURL
            // 
            _textBoxURL.Location = new Point(12, 34);
            _textBoxURL.Name = "_textBoxURL";
            _textBoxURL.Size = new Size(498, 23);
            _textBoxURL.TabIndex = 2;
            // 
            // _buttonExecute
            // 
            _buttonExecute.Location = new Point(381, 83);
            _buttonExecute.Name = "_buttonExecute";
            _buttonExecute.Size = new Size(129, 32);
            _buttonExecute.TabIndex = 3;
            _buttonExecute.Text = "取得";
            _buttonExecute.UseVisualStyleBackColor = true;
            _buttonExecute.Click += _buttonExecute_Click;
            // 
            // _buttonCancel
            // 
            _buttonCancel.Location = new Point(12, 83);
            _buttonCancel.Name = "_buttonCancel";
            _buttonCancel.Size = new Size(129, 32);
            _buttonCancel.TabIndex = 4;
            _buttonCancel.Text = "キャンセル";
            _buttonCancel.UseVisualStyleBackColor = true;
            _buttonCancel.Click += _buttonCancel_Click;
            // 
            // FormInputURL
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 127);
            Controls.Add(_buttonCancel);
            Controls.Add(_buttonExecute);
            Controls.Add(_textBoxURL);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormInputURL";
            ShowIcon = false;
            ShowInTaskbar = false;
            Text = "URL入力画面";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox _textBoxURL;
        private Button _buttonExecute;
        private Button _buttonCancel;
    }
}