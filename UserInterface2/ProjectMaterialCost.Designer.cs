namespace UserInterface2
{
    partial class ProjectMaterialCost
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
            uxProjectIDLabel = new Label();
            uxStatusLabel = new Label();
            uxSelectedProject = new TextBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            uxOK = new Button();
            SuspendLayout();
            // 
            // uxProjectIDLabel
            // 
            uxProjectIDLabel.AutoSize = true;
            uxProjectIDLabel.Location = new Point(24, 27);
            uxProjectIDLabel.Name = "uxProjectIDLabel";
            uxProjectIDLabel.Size = new Size(139, 41);
            uxProjectIDLabel.TabIndex = 0;
            uxProjectIDLabel.Text = "ProjectID";
            // 
            // uxStatusLabel
            // 
            uxStatusLabel.AutoSize = true;
            uxStatusLabel.Location = new Point(24, 108);
            uxStatusLabel.Name = "uxStatusLabel";
            uxStatusLabel.Size = new Size(98, 41);
            uxStatusLabel.TabIndex = 1;
            uxStatusLabel.Text = "Status";
            // 
            // uxSelectedProject
            // 
            uxSelectedProject.Location = new Point(192, 27);
            uxSelectedProject.Name = "uxSelectedProject";
            uxSelectedProject.Size = new Size(250, 47);
            uxSelectedProject.TabIndex = 2;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(153, 108);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(208, 45);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Not Started";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(379, 108);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(204, 45);
            checkBox2.TabIndex = 4;
            checkBox2.Text = "Completed";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // uxOK
            // 
            uxOK.Location = new Point(153, 194);
            uxOK.Name = "uxOK";
            uxOK.Size = new Size(188, 58);
            uxOK.TabIndex = 5;
            uxOK.Text = "OK";
            uxOK.UseVisualStyleBackColor = true;
            uxOK.Click += uxOK_Click;
            // 
            // ProjectMaterialCost
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(625, 326);
            Controls.Add(uxOK);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(uxSelectedProject);
            Controls.Add(uxStatusLabel);
            Controls.Add(uxProjectIDLabel);
            Name = "ProjectMaterialCost";
            Text = "ProjectMaterialCost";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label uxProjectIDLabel;
        private Label uxStatusLabel;
        private TextBox uxSelectedProject;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Button uxOK;
    }
}