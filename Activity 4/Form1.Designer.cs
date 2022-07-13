namespace Activity_4
{
    partial class TimeCalculator
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
            this.opaquePanel = new System.Windows.Forms.Panel();
            this.answerGroupbox = new System.Windows.Forms.GroupBox();
            this.daysTotalTextbox = new System.Windows.Forms.TextBox();
            this.daysTotalLabel = new System.Windows.Forms.Label();
            this.hoursTotalTextbox = new System.Windows.Forms.TextBox();
            this.hoursTotalLabel = new System.Windows.Forms.Label();
            this.minutesTotalTextbox = new System.Windows.Forms.TextBox();
            this.minutesTotalLabel = new System.Windows.Forms.Label();
            this.consecutiveLabel = new System.Windows.Forms.Label();
            this.consecutiveAnswerLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.secondsEntryTextbox = new System.Windows.Forms.TextBox();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.opaquePanel.SuspendLayout();
            this.answerGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // opaquePanel
            // 
            this.opaquePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.opaquePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.opaquePanel.Controls.Add(this.answerGroupbox);
            this.opaquePanel.Controls.Add(this.calculateButton);
            this.opaquePanel.Controls.Add(this.secondsEntryTextbox);
            this.opaquePanel.Controls.Add(this.instructionLabel);
            this.opaquePanel.Location = new System.Drawing.Point(178, 12);
            this.opaquePanel.Name = "opaquePanel";
            this.opaquePanel.Size = new System.Drawing.Size(200, 321);
            this.opaquePanel.TabIndex = 0;
            // 
            // answerGroupbox
            // 
            this.answerGroupbox.BackColor = System.Drawing.Color.Transparent;
            this.answerGroupbox.Controls.Add(this.daysTotalTextbox);
            this.answerGroupbox.Controls.Add(this.daysTotalLabel);
            this.answerGroupbox.Controls.Add(this.hoursTotalTextbox);
            this.answerGroupbox.Controls.Add(this.hoursTotalLabel);
            this.answerGroupbox.Controls.Add(this.minutesTotalTextbox);
            this.answerGroupbox.Controls.Add(this.minutesTotalLabel);
            this.answerGroupbox.Controls.Add(this.consecutiveLabel);
            this.answerGroupbox.Controls.Add(this.consecutiveAnswerLabel);
            this.answerGroupbox.Location = new System.Drawing.Point(13, 132);
            this.answerGroupbox.Name = "answerGroupbox";
            this.answerGroupbox.Size = new System.Drawing.Size(171, 184);
            this.answerGroupbox.TabIndex = 3;
            this.answerGroupbox.TabStop = false;
            this.answerGroupbox.Text = "Answer:";
            // 
            // daysTotalTextbox
            // 
            this.daysTotalTextbox.Enabled = false;
            this.daysTotalTextbox.Location = new System.Drawing.Point(98, 155);
            this.daysTotalTextbox.Name = "daysTotalTextbox";
            this.daysTotalTextbox.Size = new System.Drawing.Size(67, 23);
            this.daysTotalTextbox.TabIndex = 7;
            // 
            // daysTotalLabel
            // 
            this.daysTotalLabel.AutoSize = true;
            this.daysTotalLabel.Location = new System.Drawing.Point(29, 158);
            this.daysTotalLabel.Name = "daysTotalLabel";
            this.daysTotalLabel.Size = new System.Drawing.Size(63, 15);
            this.daysTotalLabel.TabIndex = 6;
            this.daysTotalLabel.Text = "Days Total:";
            // 
            // hoursTotalTextbox
            // 
            this.hoursTotalTextbox.Enabled = false;
            this.hoursTotalTextbox.Location = new System.Drawing.Point(98, 134);
            this.hoursTotalTextbox.Name = "hoursTotalTextbox";
            this.hoursTotalTextbox.Size = new System.Drawing.Size(67, 23);
            this.hoursTotalTextbox.TabIndex = 5;
            // 
            // hoursTotalLabel
            // 
            this.hoursTotalLabel.AutoSize = true;
            this.hoursTotalLabel.Location = new System.Drawing.Point(22, 137);
            this.hoursTotalLabel.Name = "hoursTotalLabel";
            this.hoursTotalLabel.Size = new System.Drawing.Size(70, 15);
            this.hoursTotalLabel.TabIndex = 4;
            this.hoursTotalLabel.Text = "Hours Total:";
            // 
            // minutesTotalTextbox
            // 
            this.minutesTotalTextbox.Enabled = false;
            this.minutesTotalTextbox.Location = new System.Drawing.Point(98, 113);
            this.minutesTotalTextbox.Name = "minutesTotalTextbox";
            this.minutesTotalTextbox.Size = new System.Drawing.Size(67, 23);
            this.minutesTotalTextbox.TabIndex = 3;
            // 
            // minutesTotalLabel
            // 
            this.minutesTotalLabel.AutoSize = true;
            this.minutesTotalLabel.Location = new System.Drawing.Point(11, 116);
            this.minutesTotalLabel.Name = "minutesTotalLabel";
            this.minutesTotalLabel.Size = new System.Drawing.Size(81, 15);
            this.minutesTotalLabel.TabIndex = 2;
            this.minutesTotalLabel.Text = "Minutes Total:";
            // 
            // consecutiveLabel
            // 
            this.consecutiveLabel.Location = new System.Drawing.Point(6, 19);
            this.consecutiveLabel.Name = "consecutiveLabel";
            this.consecutiveLabel.Size = new System.Drawing.Size(159, 15);
            this.consecutiveLabel.TabIndex = 1;
            this.consecutiveLabel.Text = "Consecutive Time";
            this.consecutiveLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // consecutiveAnswerLabel
            // 
            this.consecutiveAnswerLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.consecutiveAnswerLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.consecutiveAnswerLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.consecutiveAnswerLabel.Location = new System.Drawing.Point(6, 34);
            this.consecutiveAnswerLabel.Name = "consecutiveAnswerLabel";
            this.consecutiveAnswerLabel.Size = new System.Drawing.Size(159, 73);
            this.consecutiveAnswerLabel.TabIndex = 0;
            this.consecutiveAnswerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calculateButton.Location = new System.Drawing.Point(62, 103);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "Calculate!";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // secondsEntryTextbox
            // 
            this.secondsEntryTextbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.secondsEntryTextbox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.secondsEntryTextbox.Location = new System.Drawing.Point(13, 72);
            this.secondsEntryTextbox.Name = "secondsEntryTextbox";
            this.secondsEntryTextbox.Size = new System.Drawing.Size(171, 25);
            this.secondsEntryTextbox.TabIndex = 1;
            // 
            // instructionLabel
            // 
            this.instructionLabel.BackColor = System.Drawing.Color.Transparent;
            this.instructionLabel.Font = new System.Drawing.Font("Viner Hand ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.instructionLabel.Location = new System.Drawing.Point(13, 0);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(171, 69);
            this.instructionLabel.TabIndex = 0;
            this.instructionLabel.Text = "Enter a period of time in seconds!";
            this.instructionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimeCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Activity_4.Properties.Resources.stopwatch;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(390, 345);
            this.Controls.Add(this.opaquePanel);
            this.Name = "TimeCalculator";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Time Calculator";
            this.opaquePanel.ResumeLayout(false);
            this.opaquePanel.PerformLayout();
            this.answerGroupbox.ResumeLayout(false);
            this.answerGroupbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel opaquePanel;
        private GroupBox answerGroupbox;
        private Label consecutiveAnswerLabel;
        private Button calculateButton;
        private TextBox secondsEntryTextbox;
        private Label instructionLabel;
        private Label minutesTotalLabel;
        private Label consecutiveLabel;
        private TextBox daysTotalTextbox;
        private Label daysTotalLabel;
        private TextBox hoursTotalTextbox;
        private Label hoursTotalLabel;
        private TextBox minutesTotalTextbox;
    }
}