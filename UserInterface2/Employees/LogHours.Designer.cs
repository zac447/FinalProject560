namespace UserInterface2
{
    partial class LogHours
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
            uxProjectID = new Label();
            uxEmployeeID = new Label();
            uxDescription = new Label();
            uxDate = new Label();
            uxHours = new Label();
            uxProjectIDText = new TextBox();
            uxEmployeeIDText = new TextBox();
            uxDescriptionText = new TextBox();
            uxDateText = new TextBox();
            uxHoursText = new TextBox();
            uxOK = new Button();
            uxCancel = new Button();
            SuspendLayout();
            // 
            // uxProjectID
            // 
            uxProjectID.AutoSize = true;
            uxProjectID.Location = new Point(21, 23);
            uxProjectID.Margin = new Padding(2, 0, 2, 0);
            uxProjectID.Name = "uxProjectID";
            uxProjectID.Size = new Size(84, 25);
            uxProjectID.TabIndex = 0;
            uxProjectID.Text = "ProjectID";
            // 
            // uxEmployeeID
            // 
            uxEmployeeID.AutoSize = true;
            uxEmployeeID.Location = new Point(21, 59);
            uxEmployeeID.Margin = new Padding(2, 0, 2, 0);
            uxEmployeeID.Name = "uxEmployeeID";
            uxEmployeeID.Size = new Size(108, 25);
            uxEmployeeID.TabIndex = 1;
            uxEmployeeID.Text = "EmployeeID";
            // 
            // uxDescription
            // 
            uxDescription.AutoSize = true;
            uxDescription.Location = new Point(21, 98);
            uxDescription.Margin = new Padding(2, 0, 2, 0);
            uxDescription.Name = "uxDescription";
            uxDescription.Size = new Size(102, 25);
            uxDescription.TabIndex = 2;
            uxDescription.Text = "Description";
            // 
            // uxDate
            // 
            uxDate.AutoSize = true;
            uxDate.Location = new Point(21, 134);
            uxDate.Margin = new Padding(2, 0, 2, 0);
            uxDate.Name = "uxDate";
            uxDate.Size = new Size(49, 25);
            uxDate.TabIndex = 3;
            uxDate.Text = "Date";
            // 
            // uxHours
            // 
            uxHours.AutoSize = true;
            uxHours.Location = new Point(21, 174);
            uxHours.Margin = new Padding(2, 0, 2, 0);
            uxHours.Name = "uxHours";
            uxHours.Size = new Size(60, 25);
            uxHours.TabIndex = 8;
            uxHours.Text = "Hours";
            // 
            // uxProjectIDText
            // 
            uxProjectIDText.Location = new Point(129, 23);
            uxProjectIDText.Margin = new Padding(2);
            uxProjectIDText.Name = "uxProjectIDText";
            uxProjectIDText.Size = new Size(292, 31);
            uxProjectIDText.TabIndex = 9;
            // 
            // uxEmployeeIDText
            // 
            uxEmployeeIDText.Location = new Point(129, 59);
            uxEmployeeIDText.Margin = new Padding(2);
            uxEmployeeIDText.Name = "uxEmployeeIDText";
            uxEmployeeIDText.Size = new Size(292, 31);
            uxEmployeeIDText.TabIndex = 10;
            // 
            // uxDescriptionText
            // 
            uxDescriptionText.Location = new Point(129, 98);
            uxDescriptionText.Margin = new Padding(2);
            uxDescriptionText.Name = "uxDescriptionText";
            uxDescriptionText.Size = new Size(292, 31);
            uxDescriptionText.TabIndex = 11;
            // 
            // uxDateText
            // 
            uxDateText.Location = new Point(129, 134);
            uxDateText.Margin = new Padding(2);
            uxDateText.Name = "uxDateText";
            uxDateText.Size = new Size(292, 31);
            uxDateText.TabIndex = 12;
            // 
            // uxHoursText
            // 
            uxHoursText.Location = new Point(129, 174);
            uxHoursText.Margin = new Padding(2);
            uxHoursText.Name = "uxHoursText";
            uxHoursText.Size = new Size(292, 31);
            uxHoursText.TabIndex = 17;
            // 
            // uxOK
            // 
            uxOK.Location = new Point(95, 233);
            uxOK.Margin = new Padding(2);
            uxOK.Name = "uxOK";
            uxOK.Size = new Size(111, 35);
            uxOK.TabIndex = 19;
            uxOK.Text = "OK";
            uxOK.UseVisualStyleBackColor = true;
            uxOK.Click += uxOK_Click;
            // 
            // uxCancel
            // 
            uxCancel.Location = new Point(275, 233);
            uxCancel.Margin = new Padding(2);
            uxCancel.Name = "uxCancel";
            uxCancel.Size = new Size(111, 35);
            uxCancel.TabIndex = 20;
            uxCancel.Text = "Cancel";
            uxCancel.UseVisualStyleBackColor = true;
            uxCancel.Click += uxCancel_Click;
            // 
            // LogHours
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 318);
            Controls.Add(uxCancel);
            Controls.Add(uxOK);
            Controls.Add(uxHoursText);
            Controls.Add(uxDateText);
            Controls.Add(uxDescriptionText);
            Controls.Add(uxEmployeeIDText);
            Controls.Add(uxProjectIDText);
            Controls.Add(uxHours);
            Controls.Add(uxDate);
            Controls.Add(uxDescription);
            Controls.Add(uxEmployeeID);
            Controls.Add(uxProjectID);
            Margin = new Padding(2);
            Name = "LogHours";
            Text = "Log Hours";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label uxProjectID;
        private Label uxEmployeeID;
        private Label uxDescription;
        private Label uxDate;
        private Label uxHours;
        private TextBox uxProjectIDText;
        private TextBox uxEmployeeIDText;
        private TextBox uxDescriptionText;
        private TextBox uxDateText;
        private TextBox uxHoursText;
        private Button uxOK;
        private Button uxCancel;
    }
}