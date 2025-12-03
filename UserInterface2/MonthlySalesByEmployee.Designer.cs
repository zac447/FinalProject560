namespace UserInterface2
{
    partial class MonthlySalesByEmployee
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
            uxStartDate = new Label();
            uxEndDate = new Label();
            uxStartText = new TextBox();
            uxEndText = new TextBox();
            uxOK = new Button();
            SuspendLayout();
            // 
            // uxStartDate
            // 
            uxStartDate.AutoSize = true;
            uxStartDate.Location = new Point(34, 28);
            uxStartDate.Name = "uxStartDate";
            uxStartDate.Size = new Size(90, 25);
            uxStartDate.TabIndex = 0;
            uxStartDate.Text = "Start Date";
            // 
            // uxEndDate
            // 
            uxEndDate.AutoSize = true;
            uxEndDate.Location = new Point(34, 74);
            uxEndDate.Name = "uxEndDate";
            uxEndDate.Size = new Size(84, 25);
            uxEndDate.TabIndex = 1;
            uxEndDate.Text = "End Date";
            // 
            // uxStartText
            // 
            uxStartText.Location = new Point(136, 28);
            uxStartText.Name = "uxStartText";
            uxStartText.Size = new Size(150, 31);
            uxStartText.TabIndex = 2;
            // 
            // uxEndText
            // 
            uxEndText.Location = new Point(136, 74);
            uxEndText.Name = "uxEndText";
            uxEndText.Size = new Size(150, 31);
            uxEndText.TabIndex = 3;
            // 
            // uxOK
            // 
            uxOK.Location = new Point(136, 134);
            uxOK.Name = "uxOK";
            uxOK.Size = new Size(112, 34);
            uxOK.TabIndex = 4;
            uxOK.Text = "OK";
            uxOK.UseVisualStyleBackColor = true;
            uxOK.Click += uxOK_Click;
            // 
            // MonthlySalesByEmployee
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 241);
            Controls.Add(uxOK);
            Controls.Add(uxEndText);
            Controls.Add(uxStartText);
            Controls.Add(uxEndDate);
            Controls.Add(uxStartDate);
            Name = "MonthlySalesByEmployee";
            Text = "Monthly Sales By Employee";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label uxStartDate;
        private Label uxEndDate;
        private TextBox uxStartText;
        private TextBox uxEndText;
        private Button uxOK;
    }
}