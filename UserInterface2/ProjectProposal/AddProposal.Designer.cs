namespace UserInterface2
{
    partial class AddProposal
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
            uxProjectName = new Label();
            uxProjectDetails = new Label();
            uxCustomerID = new Label();
            uxEstimatedDurationHours = new Label();
            uxStatus = new Label();
            uxProjectNameText = new TextBox();
            uxProjectDetailsText = new TextBox();
            uxCustomerIDText = new TextBox();
            uxEstimatedDurationHoursText = new TextBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            uxOK = new Button();
            uxCancel = new Button();
            SuspendLayout();
            // 
            // uxProjectName
            // 
            uxProjectName.AutoSize = true;
            uxProjectName.Location = new Point(21, 23);
            uxProjectName.Margin = new Padding(2, 0, 2, 0);
            uxProjectName.Name = "uxProjectName";
            uxProjectName.Size = new Size(118, 25);
            uxProjectName.TabIndex = 0;
            uxProjectName.Text = "Project Name";
            // 
            // uxProjectDetails
            // 
            uxProjectDetails.AutoSize = true;
            uxProjectDetails.Location = new Point(21, 59);
            uxProjectDetails.Margin = new Padding(2, 0, 2, 0);
            uxProjectDetails.Name = "uxProjectDetails";
            uxProjectDetails.Size = new Size(124, 25);
            uxProjectDetails.TabIndex = 1;
            uxProjectDetails.Text = "Project Details";
            // 
            // uxCustomerID
            // 
            uxCustomerID.AutoSize = true;
            uxCustomerID.Location = new Point(21, 98);
            uxCustomerID.Margin = new Padding(2, 0, 2, 0);
            uxCustomerID.Name = "uxCustomerID";
            uxCustomerID.Size = new Size(107, 25);
            uxCustomerID.TabIndex = 2;
            uxCustomerID.Text = "CustomerID";
            // 
            // uxEstimatedDurationHours
            // 
            uxEstimatedDurationHours.AutoSize = true;
            uxEstimatedDurationHours.Location = new Point(21, 134);
            uxEstimatedDurationHours.Margin = new Padding(2, 0, 2, 0);
            uxEstimatedDurationHours.Name = "uxEstimatedDurationHours";
            uxEstimatedDurationHours.Size = new Size(217, 25);
            uxEstimatedDurationHours.TabIndex = 3;
            uxEstimatedDurationHours.Text = "Estimated Duration Hours";
            // 
            // uxStatus
            // 
            uxStatus.AutoSize = true;
            uxStatus.Location = new Point(21, 184);
            uxStatus.Margin = new Padding(2, 0, 2, 0);
            uxStatus.Name = "uxStatus";
            uxStatus.Size = new Size(60, 25);
            uxStatus.TabIndex = 8;
            uxStatus.Text = "Status";
            // 
            // uxProjectNameText
            // 
            uxProjectNameText.Location = new Point(238, 23);
            uxProjectNameText.Margin = new Padding(2);
            uxProjectNameText.Name = "uxProjectNameText";
            uxProjectNameText.Size = new Size(292, 31);
            uxProjectNameText.TabIndex = 9;
            // 
            // uxProjectDetailsText
            // 
            uxProjectDetailsText.Location = new Point(238, 59);
            uxProjectDetailsText.Margin = new Padding(2);
            uxProjectDetailsText.Name = "uxProjectDetailsText";
            uxProjectDetailsText.Size = new Size(292, 31);
            uxProjectDetailsText.TabIndex = 10;
            // 
            // uxCustomerIDText
            // 
            uxCustomerIDText.Location = new Point(238, 98);
            uxCustomerIDText.Margin = new Padding(2);
            uxCustomerIDText.Name = "uxCustomerIDText";
            uxCustomerIDText.Size = new Size(292, 31);
            uxCustomerIDText.TabIndex = 11;
            // 
            // uxEstimatedDurationHoursText
            // 
            uxEstimatedDurationHoursText.Location = new Point(238, 134);
            uxEstimatedDurationHoursText.Margin = new Padding(2);
            uxEstimatedDurationHoursText.Name = "uxEstimatedDurationHoursText";
            uxEstimatedDurationHoursText.Size = new Size(292, 31);
            uxEstimatedDurationHoursText.TabIndex = 12;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(160, 184);
            checkBox1.Margin = new Padding(2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(118, 29);
            checkBox1.TabIndex = 17;
            checkBox1.Text = "Approved";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(280, 184);
            checkBox2.Margin = new Padding(2);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(106, 29);
            checkBox2.TabIndex = 18;
            checkBox2.Text = "Declined";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // uxOK
            // 
            uxOK.Location = new Point(116, 264);
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
            uxCancel.Location = new Point(280, 264);
            uxCancel.Margin = new Padding(2);
            uxCancel.Name = "uxCancel";
            uxCancel.Size = new Size(111, 35);
            uxCancel.TabIndex = 20;
            uxCancel.Text = "Cancel";
            uxCancel.UseVisualStyleBackColor = true;
            uxCancel.Click += uxCancel_Click;
            // 
            // AddProposal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 380);
            Controls.Add(uxCancel);
            Controls.Add(uxOK);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(uxEstimatedDurationHoursText);
            Controls.Add(uxCustomerIDText);
            Controls.Add(uxProjectDetailsText);
            Controls.Add(uxProjectNameText);
            Controls.Add(uxStatus);
            Controls.Add(uxEstimatedDurationHours);
            Controls.Add(uxCustomerID);
            Controls.Add(uxProjectDetails);
            Controls.Add(uxProjectName);
            Margin = new Padding(2);
            Name = "AddProposal";
            Text = "Add Proposal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label uxProjectName;
        private Label uxProjectDetails;
        private Label uxCustomerID;
        private Label uxEstimatedDurationHours;
        private Label uxStatus;
        private TextBox uxProjectNameText;
        private TextBox uxProjectDetailsText;
        private TextBox uxCustomerIDText;
        private TextBox uxEstimatedDurationHoursText;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Button uxOK;
        private Button uxCancel;
    }
}