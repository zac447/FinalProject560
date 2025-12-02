namespace UserInterface2
{
    partial class UpdateProjectStatus
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
            uxSelectProject = new Label();
            uxProjectSearch = new TextBox();
            uxStatus = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            uxOK = new Button();
            uxCancel = new Button();
            SuspendLayout();
            // 
            // uxSelectProject
            // 
            uxSelectProject.AutoSize = true;
            uxSelectProject.Location = new Point(22, 45);
            uxSelectProject.Margin = new Padding(2, 0, 2, 0);
            uxSelectProject.Name = "uxSelectProject";
            uxSelectProject.Size = new Size(215, 25);
            uxSelectProject.TabIndex = 21;
            uxSelectProject.Text = "Enter ProjectID To Update";
            // 
            // uxProjectSearch
            // 
            uxProjectSearch.Location = new Point(260, 45);
            uxProjectSearch.Margin = new Padding(2);
            uxProjectSearch.Name = "uxProjectSearch";
            uxProjectSearch.Size = new Size(149, 31);
            uxProjectSearch.TabIndex = 22;
            // 
            // uxStatus
            // 
            uxStatus.AutoSize = true;
            uxStatus.Location = new Point(28, 92);
            uxStatus.Margin = new Padding(2, 0, 2, 0);
            uxStatus.Name = "uxStatus";
            uxStatus.Size = new Size(60, 25);
            uxStatus.TabIndex = 8;
            uxStatus.Text = "Status";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(167, 92);
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
            checkBox2.Location = new Point(300, 92);
            checkBox2.Margin = new Padding(2);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(126, 29);
            checkBox2.TabIndex = 18;
            checkBox2.Text = "Completed";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // uxOK
            // 
            uxOK.Location = new Point(124, 172);
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
            uxCancel.Location = new Point(287, 172);
            uxCancel.Margin = new Padding(2);
            uxCancel.Name = "uxCancel";
            uxCancel.Size = new Size(111, 35);
            uxCancel.TabIndex = 20;
            uxCancel.Text = "Cancel";
            uxCancel.UseVisualStyleBackColor = true;
            uxCancel.Click += uxCancel_Click;
            // 
            // UpdateProjectStatus
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(506, 274);
            Controls.Add(uxOK);
            Controls.Add(uxCancel);
            Controls.Add(uxStatus);
            Controls.Add(checkBox1);
            Controls.Add(checkBox2);
            Controls.Add(uxProjectSearch);
            Controls.Add(uxSelectProject);
            Margin = new Padding(2);
            Name = "UpdateProjectStatus";
            Text = "Update Project Status";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label uxSelectProject;
        private TextBox uxProjectSearch;
        private Label uxStatus;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Button uxOK;
        private Button uxCancel;

        #endregion
    }
}