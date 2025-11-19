namespace UserInterface2
{
    partial class UserInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInterface));
            uxSearchButton = new Button();
            uxSearchBar = new TextBox();
            uxInfoStrip = new ToolStrip();
            uxTabBar = new ToolStripLabel();
            uxCustomerButton = new ToolStripButton();
            uxEmployee = new ToolStripDropDownButton();
            uxEmployeeInfo = new ToolStripMenuItem();
            uxEmployeeHours = new ToolStripMenuItem();
            uxProjectsInfo = new ToolStripDropDownButton();
            uxprojectProposals = new ToolStripMenuItem();
            uxProjectDetails = new ToolStripMenuItem();
            uxProjectMaterials = new ToolStripMenuItem();
            uxOnGoingProjects = new ToolStripMenuItem();
            uxOutputBox = new TextBox();
            uxInfoStrip.SuspendLayout();
            SuspendLayout();
            // 
            // uxSearchButton
            // 
            uxSearchButton.Location = new Point(12, 57);
            uxSearchButton.Name = "uxSearchButton";
            uxSearchButton.Size = new Size(188, 58);
            uxSearchButton.TabIndex = 0;
            uxSearchButton.Text = "Search";
            uxSearchButton.UseVisualStyleBackColor = true;
            uxSearchButton.Click += uxSearchButton_Click;
            // 
            // uxSearchBar
            // 
            uxSearchBar.Location = new Point(224, 68);
            uxSearchBar.Name = "uxSearchBar";
            uxSearchBar.Size = new Size(1087, 47);
            uxSearchBar.TabIndex = 1;
            uxSearchBar.Text = "Search Bar";
            // 
            // uxInfoStrip
            // 
            uxInfoStrip.ImageScalingSize = new Size(40, 40);
            uxInfoStrip.Items.AddRange(new ToolStripItem[] { uxTabBar, uxCustomerButton, uxEmployee, uxProjectsInfo });
            uxInfoStrip.Location = new Point(0, 0);
            uxInfoStrip.Name = "uxInfoStrip";
            uxInfoStrip.Size = new Size(1323, 52);
            uxInfoStrip.TabIndex = 2;
            uxInfoStrip.Text = "toolStrip1";
            // 
            // uxTabBar
            // 
            uxTabBar.Name = "uxTabBar";
            uxTabBar.Size = new Size(233, 45);
            uxTabBar.Text = "Quick Reference";
            // 
            // uxCustomerButton
            // 
            uxCustomerButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            uxCustomerButton.Image = (Image)resources.GetObject("uxCustomerButton.Image");
            uxCustomerButton.ImageTransparentColor = Color.Magenta;
            uxCustomerButton.Name = "uxCustomerButton";
            uxCustomerButton.Size = new Size(164, 45);
            uxCustomerButton.Text = "Customers";
            // 
            // uxEmployee
            // 
            uxEmployee.DisplayStyle = ToolStripItemDisplayStyle.Text;
            uxEmployee.DropDownItems.AddRange(new ToolStripItem[] { uxEmployeeInfo, uxEmployeeHours });
            uxEmployee.Image = (Image)resources.GetObject("uxEmployee.Image");
            uxEmployee.ImageTransparentColor = Color.Magenta;
            uxEmployee.Name = "uxEmployee";
            uxEmployee.Size = new Size(188, 45);
            uxEmployee.Text = "Employees";
            // 
            // uxEmployeeInfo
            // 
            uxEmployeeInfo.Name = "uxEmployeeInfo";
            uxEmployeeInfo.Size = new Size(416, 54);
            uxEmployeeInfo.Text = "All Employee Info";
            // 
            // uxEmployeeHours
            // 
            uxEmployeeHours.Name = "uxEmployeeHours";
            uxEmployeeHours.Size = new Size(416, 54);
            uxEmployeeHours.Text = "Employee Hours";
            // 
            // uxProjectsInfo
            // 
            uxProjectsInfo.DisplayStyle = ToolStripItemDisplayStyle.Text;
            uxProjectsInfo.DropDownItems.AddRange(new ToolStripItem[] { uxprojectProposals, uxProjectMaterials, uxOnGoingProjects });
            uxProjectsInfo.Image = (Image)resources.GetObject("uxProjectsInfo.Image");
            uxProjectsInfo.ImageTransparentColor = Color.Magenta;
            uxProjectsInfo.Name = "uxProjectsInfo";
            uxProjectsInfo.Size = new Size(149, 45);
            uxProjectsInfo.Text = "Projects";
            // 
            // uxprojectProposals
            // 
            uxprojectProposals.DropDownItems.AddRange(new ToolStripItem[] { uxProjectDetails });
            uxprojectProposals.Name = "uxprojectProposals";
            uxprojectProposals.Size = new Size(423, 54);
            uxprojectProposals.Text = "Project Proposals";
            // 
            // uxProjectDetails
            // 
            uxProjectDetails.Name = "uxProjectDetails";
            uxProjectDetails.Size = new Size(397, 54);
            uxProjectDetails.Text = "Proposal Details";
            // 
            // uxProjectMaterials
            // 
            uxProjectMaterials.Name = "uxProjectMaterials";
            uxProjectMaterials.Size = new Size(423, 54);
            uxProjectMaterials.Text = "Project Materials";
            // 
            // uxOnGoingProjects
            // 
            uxOnGoingProjects.Name = "uxOnGoingProjects";
            uxOnGoingProjects.Size = new Size(423, 54);
            uxOnGoingProjects.Text = "On going Projects";
            // 
            // uxOutputBox
            // 
            uxOutputBox.Location = new Point(12, 139);
            uxOutputBox.Multiline = true;
            uxOutputBox.Name = "uxOutputBox";
            uxOutputBox.ScrollBars = ScrollBars.Both;
            uxOutputBox.Size = new Size(1299, 601);
            uxOutputBox.TabIndex = 3;
            uxOutputBox.Text = "OutputBox";
            // 
            // UserInterface
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1323, 781);
            Controls.Add(uxOutputBox);
            Controls.Add(uxInfoStrip);
            Controls.Add(uxSearchBar);
            Controls.Add(uxSearchButton);
            Name = "UserInterface";
            Text = "Company Information";
            uxInfoStrip.ResumeLayout(false);
            uxInfoStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button uxSearchButton;
        private TextBox uxSearchBar;
        private ToolStrip uxInfoStrip;
        private ToolStripLabel uxTabBar;
        private ToolStripButton uxCustomerButton;
        private ToolStripDropDownButton uxEmployee;
        private ToolStripMenuItem uxEmployeeInfo;
        private ToolStripMenuItem uxEmployeeHours;
        private ToolStripDropDownButton uxProjectsInfo;
        private ToolStripMenuItem uxprojectProposals;
        private ToolStripMenuItem uxProjectDetails;
        private ToolStripMenuItem uxProjectMaterials;
        private ToolStripMenuItem uxOnGoingProjects;
        private TextBox uxOutputBox;
    }
}
