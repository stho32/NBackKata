namespace nback.WinForms
{
    partial class RunTestForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.PositionLabel = new System.Windows.Forms.Label();
            this.TestIsRunningLabel = new System.Windows.Forms.Label();
            this.PatternDisplay = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.StartButton = new System.Windows.Forms.Button();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.AbortButton = new System.Windows.Forms.Button();
            this.IsNotARepetitionButton = new System.Windows.Forms.Button();
            this.IsARepetitionButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.PositionLabel);
            this.panel1.Controls.Add(this.TestIsRunningLabel);
            this.panel1.Controls.Add(this.PatternDisplay);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 305);
            this.panel1.TabIndex = 1;
            // 
            // PositionLabel
            // 
            this.PositionLabel.AutoSize = true;
            this.PositionLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PositionLabel.Location = new System.Drawing.Point(443, 203);
            this.PositionLabel.Name = "PositionLabel";
            this.PositionLabel.Size = new System.Drawing.Size(43, 25);
            this.PositionLabel.TabIndex = 3;
            this.PositionLabel.Text = "1/n";
            // 
            // TestIsRunningLabel
            // 
            this.TestIsRunningLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TestIsRunningLabel.AutoSize = true;
            this.TestIsRunningLabel.ForeColor = System.Drawing.Color.Red;
            this.TestIsRunningLabel.Location = new System.Drawing.Point(685, 9);
            this.TestIsRunningLabel.Name = "TestIsRunningLabel";
            this.TestIsRunningLabel.Size = new System.Drawing.Size(95, 15);
            this.TestIsRunningLabel.TabIndex = 2;
            this.TestIsRunningLabel.Text = "Test is Running...";
            // 
            // PatternDisplay
            // 
            this.PatternDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PatternDisplay.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PatternDisplay.Location = new System.Drawing.Point(0, 0);
            this.PatternDisplay.Name = "PatternDisplay";
            this.PatternDisplay.Size = new System.Drawing.Size(792, 305);
            this.PatternDisplay.TabIndex = 1;
            this.PatternDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.StartButton);
            this.panel2.Controls.Add(this.MessageLabel);
            this.panel2.Controls.Add(this.AbortButton);
            this.panel2.Controls.Add(this.IsNotARepetitionButton);
            this.panel2.Controls.Add(this.IsARepetitionButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 305);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(792, 155);
            this.panel2.TabIndex = 2;
            // 
            // StartButton
            // 
            this.StartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.StartButton.Location = new System.Drawing.Point(374, 98);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(200, 45);
            this.StartButton.TabIndex = 4;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Location = new System.Drawing.Point(12, 128);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(81, 15);
            this.MessageLabel.TabIndex = 3;
            this.MessageLabel.Text = "MessageLabel";
            // 
            // AbortButton
            // 
            this.AbortButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AbortButton.Location = new System.Drawing.Point(580, 98);
            this.AbortButton.Name = "AbortButton";
            this.AbortButton.Size = new System.Drawing.Size(200, 45);
            this.AbortButton.TabIndex = 2;
            this.AbortButton.Text = "Abort / Close";
            this.AbortButton.UseVisualStyleBackColor = true;
            this.AbortButton.Click += new System.EventHandler(this.AbortButton_Click);
            // 
            // IsNotARepetitionButton
            // 
            this.IsNotARepetitionButton.Location = new System.Drawing.Point(221, 6);
            this.IsNotARepetitionButton.Name = "IsNotARepetitionButton";
            this.IsNotARepetitionButton.Size = new System.Drawing.Size(200, 45);
            this.IsNotARepetitionButton.TabIndex = 1;
            this.IsNotARepetitionButton.Text = "Is not a repetition (Hotkey J)";
            this.IsNotARepetitionButton.UseVisualStyleBackColor = true;
            this.IsNotARepetitionButton.Click += new System.EventHandler(this.IsNotARepetitionButton_Click);
            // 
            // IsARepetitionButton
            // 
            this.IsARepetitionButton.Location = new System.Drawing.Point(12, 6);
            this.IsARepetitionButton.Name = "IsARepetitionButton";
            this.IsARepetitionButton.Size = new System.Drawing.Size(200, 45);
            this.IsARepetitionButton.TabIndex = 0;
            this.IsARepetitionButton.Text = "Is a repetition (Hotkey F)";
            this.IsARepetitionButton.UseVisualStyleBackColor = true;
            this.IsARepetitionButton.Click += new System.EventHandler(this.IsARepititionButton_Click);
            // 
            // RunTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 460);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.KeyPreview = true;
            this.Name = "RunTestForm";
            this.Text = "Test Runner";
            this.Load += new System.EventHandler(this.RunTestForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RunTestForm_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label PatternDisplay;
        private Panel panel2;
        private Button IsNotARepetitionButton;
        private Button IsARepetitionButton;
        private Label MessageLabel;
        private Button AbortButton;
        private Label TestIsRunningLabel;
        private Button StartButton;
        private Label PositionLabel;
    }
}