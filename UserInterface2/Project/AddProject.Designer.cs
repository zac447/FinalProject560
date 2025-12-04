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
            uxManagerID = new Label();
            uxStatus = new Label();
            uxManagerIDText = new TextBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            uxOK = new Button();
            uxCancel = new Button();
            uxProposalID = new Label();
            uxStartDate = new Label();
            uxPropsalIDText = new TextBox();
            uxStartDateText = new TextBox();
            SuspendLayout();
            // 
            // uxManagerID
            // 
            uxManagerID.AutoSize = true;
            uxManagerID.Location = new Point(21, 78);
            uxManagerID.Margin = new Padding(2, 0, 2, 0);
            uxManagerID.Name = "uxManagerID";
            uxManagerID.Size = new Size(100, 25);
            uxManagerID.TabIndex = 1;
            uxManagerID.Text = "ManagerID";
            // 
            // uxStatus
            // 
            uxStatus.AutoSize = true;
            uxStatus.Location = new Point(21, 175);
            uxStatus.Margin = new Padding(2, 0, 2, 0);
            uxStatus.Name = "uxStatus";
            uxStatus.Size = new Size(60, 25);
            uxStatus.TabIndex = 8;
            uxStatus.Text = "Status";
            // 
            // uxManagerIDText
            // 
            uxManagerIDText.Location = new Point(146, 78);
            uxManagerIDText.Margin = new Padding(2);
            uxManagerIDText.Name = "uxManagerIDText";
            uxManagerIDText.Size = new Size(292, 31);
            uxManagerIDText.TabIndex = 10;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(146, 175);
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
            checkBox2.Location = new Point(302, 175);
            checkBox2.Margin = new Padding(2);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(126, 29);
            checkBox2.TabIndex = 18;
            checkBox2.Text = "Completed";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // uxOK
            // 
            uxOK.Location = new Point(146, 240);
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
            uxCancel.Location = new Point(317, 240);
            uxCancel.Margin = new Padding(2);
            uxCancel.Name = "uxCancel";
            uxCancel.Size = new Size(111, 35);
            uxCancel.TabIndex = 20;
            uxCancel.Text = "Cancel";
            uxCancel.UseVisualStyleBackColor = true;
            uxCancel.Click += uxCancel_Click;
            // 
            // uxProposalID
            // 
            uxProposalID.AutoSize = true;
            uxProposalID.Location = new Point(21, 27);
            uxProposalID.Name = "uxProposalID";
            uxProposalID.Size = new Size(100, 25);
            uxProposalID.TabIndex = 21;
            uxProposalID.Text = "ProposalID";
            // 
            // uxStartDate
            // 
            uxStartDate.AutoSize = true;
            uxStartDate.Location = new Point(21, 127);
            uxStartDate.Name = "uxStartDate";
            uxStartDate.Size = new Size(90, 25);
            uxStartDate.TabIndex = 22;
            uxStartDate.Text = "Start Date";
            // 
            // uxPropsalIDText
            // 
            uxPropsalIDText.Location = new Point(146, 27);
            uxPropsalIDText.Name = "uxPropsalIDText";
            uxPropsalIDText.Size = new Size(292, 31);
            uxPropsalIDText.TabIndex = 23;
            // 
            // uxStartDateText
            // 
            uxStartDateText.Location = new Point(146, 127);
            uxStartDateText.Name = "uxStartDateText";
            uxStartDateText.Size = new Size(292, 31);
            uxStartDateText.TabIndex = 24;
            // 
            // AddProject
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 360);
            Controls.Add(uxStartDateText);
            Controls.Add(uxPropsalIDText);
            Controls.Add(uxStartDate);
            Controls.Add(uxProposalID);
            Controls.Add(uxCancel);
            Controls.Add(uxOK);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(uxManagerIDText);
            Controls.Add(uxStatus);
            Controls.Add(uxManagerID);
            Margin = new Padding(2);
            Name = "AddProject";
            Text = "Add Project";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label uxManagerID;
        private Label uxStatus;
        private TextBox uxManagerIDText;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Button uxOK;
        private Button uxCancel;
        private Label uxProposalID;
        private Label uxStartDate;
        private TextBox uxPropsalIDText;
        private TextBox uxStartDateText;
    }
}