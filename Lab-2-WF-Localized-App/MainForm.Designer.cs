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
            this.LocaleButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStartClock = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStopClock = new System.Windows.Forms.ToolStripMenuItem();
            this.NovosibirskTimeBox = new System.Windows.Forms.TextBox();
            this.NovosibirskLabel = new System.Windows.Forms.Label();
            this.NewYorkTimeBox = new System.Windows.Forms.TextBox();
            this.NewYorkLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
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
            // LocaleButton
            // 
            resources.ApplyResources(this.LocaleButton, "LocaleButton");
            this.LocaleButton.Name = "LocaleButton";
            this.LocaleButton.UseVisualStyleBackColor = true;
            this.LocaleButton.Click += new System.EventHandler(this.SwitchLocale);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // Menu
            // 
            this.Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStartClock,
            this.MenuStopClock});
            resources.ApplyResources(this.Menu, "Menu");
            this.Menu.Name = "Menu";
            // 
            // MenuStartClock
            // 
            this.MenuStartClock.Name = "MenuStartClock";
            resources.ApplyResources(this.MenuStartClock, "MenuStartClock");
            this.MenuStartClock.Click += new System.EventHandler(this.MenuStartClock_Click);
            // 
            // MenuStopClock
            // 
            this.MenuStopClock.Name = "MenuStopClock";
            resources.ApplyResources(this.MenuStopClock, "MenuStopClock");
            this.MenuStopClock.Click += new System.EventHandler(this.MenuStopClock_Click);
            // 
            // NovosibirskTimeBox
            // 
            resources.ApplyResources(this.NovosibirskTimeBox, "NovosibirskTimeBox");
            this.NovosibirskTimeBox.Name = "NovosibirskTimeBox";
            // 
            // NovosibirskLabel
            // 
            resources.ApplyResources(this.NovosibirskLabel, "NovosibirskLabel");
            this.NovosibirskLabel.Name = "NovosibirskLabel";
            // 
            // NewYorkTimeBox
            // 
            resources.ApplyResources(this.NewYorkTimeBox, "NewYorkTimeBox");
            this.NewYorkTimeBox.Name = "NewYorkTimeBox";
            // 
            // NewYorkLabel
            // 
            resources.ApplyResources(this.NewYorkLabel, "NewYorkLabel");
            this.NewYorkLabel.Name = "NewYorkLabel";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NewYorkTimeBox);
            this.Controls.Add(this.NewYorkLabel);
            this.Controls.Add(this.NovosibirskTimeBox);
            this.Controls.Add(this.NovosibirskLabel);
            this.Controls.Add(this.LocaleButton);
            this.Controls.Add(this.VladivostokTimeBox);
            this.Controls.Add(this.MoscowTimeBox);
            this.Controls.Add(this.LondonTimeBox);
            this.Controls.Add(this.VladivostokLabel);
            this.Controls.Add(this.MoscowLabel);
            this.Controls.Add(this.LondonLabel);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.Button LocaleButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Menu;
        private System.Windows.Forms.ToolStripMenuItem MenuStartClock;
        private System.Windows.Forms.ToolStripMenuItem MenuStopClock;
        private System.Windows.Forms.TextBox NovosibirskTimeBox;
        private System.Windows.Forms.Label NovosibirskLabel;
        private System.Windows.Forms.TextBox NewYorkTimeBox;
        private System.Windows.Forms.Label NewYorkLabel;
    }
}

