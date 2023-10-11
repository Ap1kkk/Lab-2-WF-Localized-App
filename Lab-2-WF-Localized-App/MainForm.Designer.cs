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
            this.LocaleButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStartClock = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStopClock = new System.Windows.Forms.ToolStripMenuItem();
            this.addCityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.MenuStopClock,
            this.addCityToolStripMenuItem});
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
            // addCityToolStripMenuItem
            // 
            this.addCityToolStripMenuItem.Name = "addCityToolStripMenuItem";
            resources.ApplyResources(this.addCityToolStripMenuItem, "addCityToolStripMenuItem");
            this.addCityToolStripMenuItem.Click += new System.EventHandler(this.addCityToolStripMenuItem_Click);
            // 
            // MainLayoutPanel
            // 
            resources.ApplyResources(this.MainLayoutPanel, "MainLayoutPanel");
            this.MainLayoutPanel.Name = "MainLayoutPanel";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainLayoutPanel);
            this.Controls.Add(this.LocaleButton);
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
        private System.Windows.Forms.Button LocaleButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Menu;
        private System.Windows.Forms.ToolStripMenuItem MenuStartClock;
        private System.Windows.Forms.ToolStripMenuItem MenuStopClock;
        private System.Windows.Forms.FlowLayoutPanel MainLayoutPanel;
        private System.Windows.Forms.ToolStripMenuItem addCityToolStripMenuItem;
    }
}

