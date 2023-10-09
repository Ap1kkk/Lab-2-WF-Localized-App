namespace Lab_2_WF_Localized_App
{
    partial class AddCityForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCityForm));
            this.label1 = new System.Windows.Forms.Label();
            this.CityInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TimeShiftInput = new System.Windows.Forms.NumericUpDown();
            this.IntervalInput = new System.Windows.Forms.NumericUpDown();
            this.MaxTicksInput = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.TimeShiftInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntervalInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxTicksInput)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // CityInput
            // 
            resources.ApplyResources(this.CityInput, "CityInput");
            this.CityInput.Name = "CityInput";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.OnSubmit);
            // 
            // TimeShiftInput
            // 
            resources.ApplyResources(this.TimeShiftInput, "TimeShiftInput");
            this.TimeShiftInput.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.TimeShiftInput.Name = "TimeShiftInput";
            // 
            // IntervalInput
            // 
            resources.ApplyResources(this.IntervalInput, "IntervalInput");
            this.IntervalInput.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.IntervalInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.IntervalInput.Name = "IntervalInput";
            this.IntervalInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MaxTicksInput
            // 
            resources.ApplyResources(this.MaxTicksInput, "MaxTicksInput");
            this.MaxTicksInput.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.MaxTicksInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MaxTicksInput.Name = "MaxTicksInput";
            this.MaxTicksInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AddCityForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MaxTicksInput);
            this.Controls.Add(this.IntervalInput);
            this.Controls.Add(this.TimeShiftInput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CityInput);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "AddCityForm";
            ((System.ComponentModel.ISupportInitialize)(this.TimeShiftInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntervalInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxTicksInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CityInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown TimeShiftInput;
        private System.Windows.Forms.NumericUpDown IntervalInput;
        private System.Windows.Forms.NumericUpDown MaxTicksInput;
    }
}