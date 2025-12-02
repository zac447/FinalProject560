namespace UserInterface2
{
    partial class AddProject
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
            uxProjectProposalID = new Label();
            uxManagerID = new Label();
            uxStatus = new Label();
            uxProjectProposalIDText = new TextBox();
            uxManagerIDText = new TextBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            uxOK = new Button();
            uxCancel = new Button();
            uxEndDate = new Label();
            uxEndDateText = new TextBox();
            uxCustomerID = new Label();
            uxStartDate = new Label();
            uxStartDateText = new TextBox();
            uxCustomerIDText = new TextBox();
            SuspendLayout();
            // 
            // uxProjectProposalID
            // 
            uxProjectProposalID.AutoSize = true;
            uxProjectProposalID.Location = new Point(21, 73);
            uxProjectProposalID.Margin = new Padding(2, 0, 2, 0);
            uxProjectProposalID.Name = "uxProjectProposalID";
            uxProjectProposalID.Size = new Size(118, 25);
            uxProjectProposalID.TabIndex = 0;
            uxProjectProposalID.Text = "Project Name";
            // 
            // uxManagerID
            // 
            uxManagerID.AutoSize = true;
            uxManagerID.Location = new Point(21, 195);
            uxManagerID.Margin = new Padding(2, 0, 2, 0);
            uxManagerID.Name = "uxManagerID";
            uxManagerID.Size = new Size(100, 25);
            uxManagerID.TabIndex = 1;
            uxManagerID.Text = "ManagerID";
            // 
            // uxStatus
            // 
            uxStatus.AutoSize = true;
            uxStatus.Location = new Point(21, 234);
            uxStatus.Margin = new Padding(2, 0, 2, 0);
            uxStatus.Name = "uxStatus";
            uxStatus.Size = new Size(60, 25);
            uxStatus.TabIndex = 8;
            uxStatus.Text = "Status";
            // 
            // uxProjectProposalIDText
            // 
            uxProjectProposalIDText.Location = new Point(146, 73);
            uxProjectProposalIDText.Margin = new Padding(2);
            uxProjectProposalIDText.Name = "uxProjectProposalIDText";
            uxProjectProposalIDText.Size = new Size(292, 31);
            uxProjectProposalIDText.TabIndex = 9;
            // 
            // uxManagerIDText
            // 
            uxManagerIDText.Location = new Point(146, 195);
            uxManagerIDText.Margin = new Padding(2);
            uxManagerIDText.Name = "uxManagerIDText";
            uxManagerIDText.Size = new Size(292, 31);
            uxManagerIDText.TabIndex = 10;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(146, 230);
            checkBox1.Margin = new Padding(2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(129, 29);
            checkBox1.TabIndex = 17;
            checkBox1.Text = "Not Started";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(302, 230);
            checkBox2.Margin = new Padding(2);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(126, 29);
            checkBox2.TabIndex = 18;
            checkBox2.Text = "Completed";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // uxOK
            // 
            uxOK.Location = new Point(146, 284);
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
            uxCancel.Location = new Point(317, 284);
            uxCancel.Margin = new Padding(2);
            uxCancel.Name = "uxCancel";
            uxCancel.Size = new Size(111, 35);
            uxCancel.TabIndex = 20;
            uxCancel.Text = "Cancel";
            uxCancel.UseVisualStyleBackColor = true;
            uxCancel.Click += uxCancel_Click;
            // 
            // uxEndDate
            // 
            uxEndDate.AutoSize = true;
            uxEndDate.Location = new Point(21, 154);
            uxEndDate.Name = "uxEndDate";
            uxEndDate.Size = new Size(84, 25);
            uxEndDate.TabIndex = 22;
            uxEndDate.Text = "End Date";
            // 
            // uxEndDateText
            // 
            uxEndDateText.Location = new Point(146, 159);
            uxEndDateText.Name = "uxEndDateText";
            uxEndDateText.Size = new Size(292, 31);
            uxEndDateText.TabIndex = 24;
            // 
            // uxCustomerID
            // 
            uxCustomerID.AutoSize = true;
            uxCustomerID.Location = new Point(21, 26);
            uxCustomerID.Name = "uxCustomerID";
            uxCustomerID.Size = new Size(107, 25);
            uxCustomerID.TabIndex = 25;
            uxCustomerID.Text = "CustomerID";
            // 
            // uxStartDate
            // 
            uxStartDate.AutoSize = true;
            uxStartDate.Location = new Point(21, 113);
            uxStartDate.Name = "uxStartDate";
            uxStartDate.Size = new Size(90, 25);
            uxStartDate.TabIndex = 26;
            uxStartDate.Text = "Start Date";
            // 
            // uxStartDateText
            // 
            uxStartDateText.Location = new Point(146, 113);
            uxStartDateText.Name = "uxStartDateText";
            uxStartDateText.Size = new Size(292, 31);
            uxStartDateText.TabIndex = 27;
            // 
            // uxCustomerIDText
            // 
            uxCustomerIDText.Location = new Point(146, 26);
            uxCustomerIDText.Name = "uxCustomerIDText";
            uxCustomerIDText.Size = new Size(292, 31);
            uxCustomerIDText.TabIndex = 28;
            // 
            // AddProject
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 360);
            Controls.Add(uxCustomerIDText);
            Controls.Add(uxStartDateText);
            Controls.Add(uxStartDate);
            Controls.Add(uxCustomerID);
            Controls.Add(uxEndDateText);
            Controls.Add(uxEndDate);
            Controls.Add(uxCancel);
            Controls.Add(uxOK);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(uxManagerIDText);
            Controls.Add(uxProjectProposalIDText);
            Controls.Add(uxStatus);
            Controls.Add(uxManagerID);
            Controls.Add(uxProjectProposalID);
            Margin = new Padding(2);
            Name = "AddProject";
            Text = "Add Project";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label uxProjectProposalID;
        private Label uxManagerID;
        private Label uxStatus;
        private TextBox uxProjectProposalIDText;
        private TextBox uxManagerIDText;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Button uxOK;
        private Button uxCancel;
        private Label uxEndDate;
        private TextBox uxEndDateText;
        private Label uxCustomerID;
        private Label uxStartDate;
        private TextBox uxStartDateText;
        private TextBox uxCustomerIDText;
    }
}