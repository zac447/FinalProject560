namespace UserInterface2
{
    partial class TotalHoursPerProject
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
            uxProjectSelect = new Label();
            uxSelectedProject = new TextBox();
            uxOK = new Button();
            SuspendLayout();
            // 
            // uxProjectSelect
            // 
            uxProjectSelect.AutoSize = true;
            uxProjectSelect.Location = new Point(12, 33);
            uxProjectSelect.Name = "uxProjectSelect";
            uxProjectSelect.Size = new Size(265, 25);
            uxProjectSelect.TabIndex = 0;
            uxProjectSelect.Text = "Select a project to see the hours";
            // 
            // uxSelectedProject
            // 
            uxSelectedProject.Location = new Point(292, 33);
            uxSelectedProject.Name = "uxSelectedProject";
            uxSelectedProject.Size = new Size(150, 31);
            uxSelectedProject.TabIndex = 1;
            // 
            // uxOK
            // 
            uxOK.Location = new Point(187, 99);
            uxOK.Name = "uxOK";
            uxOK.Size = new Size(112, 34);
            uxOK.TabIndex = 2;
            uxOK.Text = "OK";
            uxOK.UseVisualStyleBackColor = true;
            uxOK.Click += uxOK_Click;
            // 
            // TotalHoursPerProject
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 192);
            Controls.Add(uxOK);
            Controls.Add(uxSelectedProject);
            Controls.Add(uxProjectSelect);
            Name = "TotalHoursPerProject";
            Text = "Total Hours Per Project";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label uxProjectSelect;
        private TextBox uxSelectedProject;
        private Button uxOK;
    }
}