namespace nback.WinForms
{
    partial class StartTestForm
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
            this.NameOfSubjectLabel = new System.Windows.Forms.Label();
            this.NameOfSubjectTextBox = new System.Windows.Forms.TextBox();
            this.NNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.NLabel = new System.Windows.Forms.Label();
            this.StimulusDurationInMsLabel = new System.Windows.Forms.Label();
            this.StimulusDurationInMsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.NumberOfStimuliLabel = new System.Windows.Forms.Label();
            this.NumberOfStimuliNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.StartTestButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StimulusDurationInMsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfStimuliNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // NameOfSubjectLabel
            // 
            this.NameOfSubjectLabel.AutoSize = true;
            this.NameOfSubjectLabel.Location = new System.Drawing.Point(42, 26);
            this.NameOfSubjectLabel.Name = "NameOfSubjectLabel";
            this.NameOfSubjectLabel.Size = new System.Drawing.Size(94, 15);
            this.NameOfSubjectLabel.TabIndex = 0;
            this.NameOfSubjectLabel.Text = "Name of subject";
            // 
            // NameOfSubjectTextBox
            // 
            this.NameOfSubjectTextBox.Location = new System.Drawing.Point(42, 44);
            this.NameOfSubjectTextBox.Name = "NameOfSubjectTextBox";
            this.NameOfSubjectTextBox.Size = new System.Drawing.Size(273, 23);
            this.NameOfSubjectTextBox.TabIndex = 1;
            // 
            // NNumericUpDown
            // 
            this.NNumericUpDown.Location = new System.Drawing.Point(321, 44);
            this.NNumericUpDown.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.NNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NNumericUpDown.Name = "NNumericUpDown";
            this.NNumericUpDown.Size = new System.Drawing.Size(51, 23);
            this.NNumericUpDown.TabIndex = 2;
            this.NNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NLabel
            // 
            this.NLabel.AutoSize = true;
            this.NLabel.Location = new System.Drawing.Point(321, 26);
            this.NLabel.Name = "NLabel";
            this.NLabel.Size = new System.Drawing.Size(16, 15);
            this.NLabel.TabIndex = 3;
            this.NLabel.Text = "N";
            // 
            // StimulusDurationInMsLabel
            // 
            this.StimulusDurationInMsLabel.AutoSize = true;
            this.StimulusDurationInMsLabel.Location = new System.Drawing.Point(42, 70);
            this.StimulusDurationInMsLabel.Name = "StimulusDurationInMsLabel";
            this.StimulusDurationInMsLabel.Size = new System.Drawing.Size(184, 15);
            this.StimulusDurationInMsLabel.TabIndex = 5;
            this.StimulusDurationInMsLabel.Text = "Stimulus Duration in Milliseconds";
            // 
            // StimulusDurationInMsNumericUpDown
            // 
            this.StimulusDurationInMsNumericUpDown.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.StimulusDurationInMsNumericUpDown.Location = new System.Drawing.Point(42, 88);
            this.StimulusDurationInMsNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.StimulusDurationInMsNumericUpDown.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.StimulusDurationInMsNumericUpDown.Name = "StimulusDurationInMsNumericUpDown";
            this.StimulusDurationInMsNumericUpDown.Size = new System.Drawing.Size(273, 23);
            this.StimulusDurationInMsNumericUpDown.TabIndex = 4;
            this.StimulusDurationInMsNumericUpDown.ThousandsSeparator = true;
            this.StimulusDurationInMsNumericUpDown.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // NumberOfStimuliLabel
            // 
            this.NumberOfStimuliLabel.AutoSize = true;
            this.NumberOfStimuliLabel.Location = new System.Drawing.Point(321, 70);
            this.NumberOfStimuliLabel.Name = "NumberOfStimuliLabel";
            this.NumberOfStimuliLabel.Size = new System.Drawing.Size(105, 15);
            this.NumberOfStimuliLabel.TabIndex = 7;
            this.NumberOfStimuliLabel.Text = "Number of Stimuli";
            // 
            // NumberOfStimuliNumericUpDown
            // 
            this.NumberOfStimuliNumericUpDown.Location = new System.Drawing.Point(321, 88);
            this.NumberOfStimuliNumericUpDown.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.NumberOfStimuliNumericUpDown.Name = "NumberOfStimuliNumericUpDown";
            this.NumberOfStimuliNumericUpDown.Size = new System.Drawing.Size(273, 23);
            this.NumberOfStimuliNumericUpDown.TabIndex = 6;
            this.NumberOfStimuliNumericUpDown.ThousandsSeparator = true;
            this.NumberOfStimuliNumericUpDown.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // StartTestButton
            // 
            this.StartTestButton.Location = new System.Drawing.Point(478, 128);
            this.StartTestButton.Name = "StartTestButton";
            this.StartTestButton.Size = new System.Drawing.Size(116, 23);
            this.StartTestButton.TabIndex = 8;
            this.StartTestButton.Text = "Start Test";
            this.StartTestButton.UseVisualStyleBackColor = true;
            this.StartTestButton.Click += new System.EventHandler(this.StartTestButton_Click);
            // 
            // StartTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 183);
            this.Controls.Add(this.StartTestButton);
            this.Controls.Add(this.NumberOfStimuliLabel);
            this.Controls.Add(this.NumberOfStimuliNumericUpDown);
            this.Controls.Add(this.StimulusDurationInMsLabel);
            this.Controls.Add(this.StimulusDurationInMsNumericUpDown);
            this.Controls.Add(this.NLabel);
            this.Controls.Add(this.NNumericUpDown);
            this.Controls.Add(this.NameOfSubjectTextBox);
            this.Controls.Add(this.NameOfSubjectLabel);
            this.Name = "StartTestForm";
            this.Text = "StartTestForm";
            ((System.ComponentModel.ISupportInitialize)(this.NNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StimulusDurationInMsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberOfStimuliNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label NameOfSubjectLabel;
        private TextBox NameOfSubjectTextBox;
        private NumericUpDown NNumericUpDown;
        private Label NLabel;
        private Label StimulusDurationInMsLabel;
        private NumericUpDown StimulusDurationInMsNumericUpDown;
        private Label NumberOfStimuliLabel;
        private NumericUpDown NumberOfStimuliNumericUpDown;
        private Button StartTestButton;
    }
}