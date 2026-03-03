namespace StudioKEIBA.HorseProfilerApp
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            _mainPanel = new Panel();
            SuspendLayout();
            // 
            // _mainPanel
            // 
            _mainPanel.Dock = DockStyle.Fill;
            _mainPanel.Location = new Point(0, 0);
            _mainPanel.Name = "_mainPanel";
            _mainPanel.Size = new Size(800, 450);
            _mainPanel.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(_mainPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormMain";
            Text = "競走馬プロファイリングツール　StudioKEIBA";
            ResumeLayout(false);
        }

        #endregion

        private Panel _mainPanel;
    }
}
