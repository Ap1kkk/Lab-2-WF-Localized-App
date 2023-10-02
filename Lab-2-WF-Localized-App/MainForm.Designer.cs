namespace Lab_2_WF_Localized_App
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.VladivostokLabel = new System.Windows.Forms.Label();
            this.MoscowLabel = new System.Windows.Forms.Label();
            this.LondonLabel = new System.Windows.Forms.Label();
            this.LondonTimeBox = new System.Windows.Forms.TextBox();
            this.MoscowTimeBox = new System.Windows.Forms.TextBox();
            this.VladivostokTimeBox = new System.Windows.Forms.TextBox();
            this.StartClockLabel = new System.Windows.Forms.Label();
            this.StopClockLabel = new System.Windows.Forms.Label();
            this.LocaleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // VladivostokLabel
            // 
            resources.ApplyResources(this.VladivostokLabel, "VladivostokLabel");
            this.VladivostokLabel.Name = "VladivostokLabel";
            // 
            // MoscowLabel
            // 
            resources.ApplyResources(this.MoscowLabel, "MoscowLabel");
            this.MoscowLabel.Name = "MoscowLabel";
            // 
            // LondonLabel
            // 
            resources.ApplyResources(this.LondonLabel, "LondonLabel");
            this.LondonLabel.Name = "LondonLabel";
            // 
            // LondonTimeBox
            // 
            resources.ApplyResources(this.LondonTimeBox, "LondonTimeBox");
            this.LondonTimeBox.Name = "LondonTimeBox";
            // 
            // MoscowTimeBox
            // 
            resources.ApplyResources(this.MoscowTimeBox, "MoscowTimeBox");
            this.MoscowTimeBox.Name = "MoscowTimeBox";
            // 
            // VladivostokTimeBox
            // 
            resources.ApplyResources(this.VladivostokTimeBox, "VladivostokTimeBox");
            this.VladivostokTimeBox.Name = "VladivostokTimeBox";
            // 
            // StartClockLabel
            // 
            resources.ApplyResources(this.StartClockLabel, "StartClockLabel");
            this.StartClockLabel.Name = "StartClockLabel";
            // 
            // StopClockLabel
            // 
            resources.ApplyResources(this.StopClockLabel, "StopClockLabel");
            this.StopClockLabel.Name = "StopClockLabel";
            // 
            // LocaleButton
            // 
            resources.ApplyResources(this.LocaleButton, "LocaleButton");
            this.LocaleButton.Name = "LocaleButton";
            this.LocaleButton.UseVisualStyleBackColor = true;
            this.LocaleButton.Click += new System.EventHandler(this.SwitchLocale);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LocaleButton);
            this.Controls.Add(this.StopClockLabel);
            this.Controls.Add(this.StartClockLabel);
            this.Controls.Add(this.VladivostokTimeBox);
            this.Controls.Add(this.MoscowTimeBox);
            this.Controls.Add(this.LondonTimeBox);
            this.Controls.Add(this.VladivostokLabel);
            this.Controls.Add(this.MoscowLabel);
            this.Controls.Add(this.LondonLabel);
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label VladivostokLabel;
        private System.Windows.Forms.Label MoscowLabel;
        private System.Windows.Forms.Label LondonLabel;
        private System.Windows.Forms.TextBox LondonTimeBox;
        private System.Windows.Forms.TextBox MoscowTimeBox;
        private System.Windows.Forms.TextBox VladivostokTimeBox;
        private System.Windows.Forms.Label StartClockLabel;
        private System.Windows.Forms.Label StopClockLabel;
        private System.Windows.Forms.Button LocaleButton;
    }
}

