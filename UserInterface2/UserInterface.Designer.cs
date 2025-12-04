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
            uxCustomerButton = new ToolStripDropDownButton();
            uxAddCustomer = new ToolStripMenuItem();
            uxUpdateCustomer = new ToolStripMenuItem();
            uxDeactivateCustomer = new ToolStripMenuItem();
            uxEmployee = new ToolStripDropDownButton();
            uxAddEmployee = new ToolStripMenuItem();
            uxUpdateEmployee = new ToolStripMenuItem();
            uxEmployeeHours = new ToolStripMenuItem();
            uxDeactivateEmployee = new ToolStripMenuItem();
            uxProjectsInfo = new ToolStripDropDownButton();
            uxprojectProposals = new ToolStripMenuItem();
            uxAddProposal = new ToolStripMenuItem();
            uxProposalStatus = new ToolStripMenuItem();
            uxProjects = new ToolStripMenuItem();
            uxAddProject = new ToolStripMenuItem();
            uxProjectStatus = new ToolStripMenuItem();
            uxTotalHoursPerProject = new ToolStripButton();
            uxMonthlySales = new ToolStripButton();
            uxCostSummary = new ToolStripButton();
            uxOutput = new DataGridView();
            uxInfoStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)uxOutput).BeginInit();
            SuspendLayout();
            // 
            // uxSearchButton
            // 
            uxSearchButton.Location = new Point(7, 35);
            uxSearchButton.Margin = new Padding(2, 2, 2, 2);
            uxSearchButton.Name = "uxSearchButton";
            uxSearchButton.Size = new Size(111, 35);
            uxSearchButton.TabIndex = 0;
            uxSearchButton.Text = "Search";
            uxSearchButton.UseVisualStyleBackColor = true;
            uxSearchButton.Click += uxSearchButton_Click;
            // 
            // uxSearchBar
            // 
            uxSearchBar.Location = new Point(132, 41);
            uxSearchBar.Margin = new Padding(2, 2, 2, 2);
            uxSearchBar.Name = "uxSearchBar";
            uxSearchBar.Size = new Size(971, 31);
            uxSearchBar.TabIndex = 1;
            uxSearchBar.Text = "Search Bar";
            // 
            // uxInfoStrip
            // 
            uxInfoStrip.ImageScalingSize = new Size(40, 40);
            uxInfoStrip.Items.AddRange(new ToolStripItem[] { uxTabBar, uxCustomerButton, uxEmployee, uxProjectsInfo, uxTotalHoursPerProject, uxMonthlySales, uxCostSummary });
            uxInfoStrip.Location = new Point(0, 0);
            uxInfoStrip.Name = "uxInfoStrip";
            uxInfoStrip.Padding = new Padding(0, 0, 1, 0);
            uxInfoStrip.Size = new Size(1118, 34);
            uxInfoStrip.TabIndex = 2;
            uxInfoStrip.Text = "toolStrip1";
            // 
            // uxTabBar
            // 
            uxTabBar.Name = "uxTabBar";
            uxTabBar.Size = new Size(138, 29);
            uxTabBar.Text = "Quick Reference";
            // 
            // uxCustomerButton
            // 
            uxCustomerButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            uxCustomerButton.DropDownItems.AddRange(new ToolStripItem[] { uxAddCustomer, uxUpdateCustomer, uxDeactivateCustomer });
            uxCustomerButton.Image = (Image)resources.GetObject("uxCustomerButton.Image");
            uxCustomerButton.ImageTransparentColor = Color.Magenta;
            uxCustomerButton.Name = "uxCustomerButton";
            uxCustomerButton.Size = new Size(115, 29);
            uxCustomerButton.Text = "Customers";
            // 
            // uxAddCustomer
            // 
            uxAddCustomer.Name = "uxAddCustomer";
            uxAddCustomer.Size = new Size(278, 34);
            uxAddCustomer.Text = "Add Customer";
            uxAddCustomer.Click += uxAddCustomer_Click;
            // 
            // uxUpdateCustomer
            // 
            uxUpdateCustomer.Name = "uxUpdateCustomer";
            uxUpdateCustomer.Size = new Size(278, 34);
            uxUpdateCustomer.Text = "Update Customer";
            uxUpdateCustomer.Click += uxUpdateCustomer_Click;
            // 
            // uxDeactivateCustomer
            // 
            uxDeactivateCustomer.Name = "uxDeactivateCustomer";
            uxDeactivateCustomer.Size = new Size(278, 34);
            uxDeactivateCustomer.Text = "Deactivate Customer";
            // 
            // uxEmployee
            // 
            uxEmployee.DisplayStyle = ToolStripItemDisplayStyle.Text;
            uxEmployee.DropDownItems.AddRange(new ToolStripItem[] { uxAddEmployee, uxUpdateEmployee, uxEmployeeHours, uxDeactivateEmployee });
            uxEmployee.Image = (Image)resources.GetObject("uxEmployee.Image");
            uxEmployee.ImageTransparentColor = Color.Magenta;
            uxEmployee.Name = "uxEmployee";
            uxEmployee.Size = new Size(116, 29);
            uxEmployee.Text = "Employees";
            // 
            // uxAddEmployee
            // 
            uxAddEmployee.Name = "uxAddEmployee";
            uxAddEmployee.Size = new Size(279, 34);
            uxAddEmployee.Text = "Add Employee";
            uxAddEmployee.Click += uxAddEmployee_Click;
            // 
            // uxUpdateEmployee
            // 
            uxUpdateEmployee.Name = "uxUpdateEmployee";
            uxUpdateEmployee.Size = new Size(279, 34);
            uxUpdateEmployee.Text = "Update Employee";
            uxUpdateEmployee.Click += uxUpdateEmployee_Click;
            // 
            // uxEmployeeHours
            // 
            uxEmployeeHours.Name = "uxEmployeeHours";
            uxEmployeeHours.Size = new Size(279, 34);
            uxEmployeeHours.Text = "Employee Hours";
            uxEmployeeHours.Click += uxEmployeeHours_Click;
            // 
            // uxDeactivateEmployee
            // 
            uxDeactivateEmployee.Name = "uxDeactivateEmployee";
            uxDeactivateEmployee.Size = new Size(279, 34);
            uxDeactivateEmployee.Text = "Deactivate Employee";
            // 
            // uxProjectsInfo
            // 
            uxProjectsInfo.DisplayStyle = ToolStripItemDisplayStyle.Text;
            uxProjectsInfo.DropDownItems.AddRange(new ToolStripItem[] { uxprojectProposals, uxProjects });
            uxProjectsInfo.Image = (Image)resources.GetObject("uxProjectsInfo.Image");
            uxProjectsInfo.ImageTransparentColor = Color.Magenta;
            uxProjectsInfo.Name = "uxProjectsInfo";
            uxProjectsInfo.Size = new Size(92, 29);
            uxProjectsInfo.Text = "Projects";
            // 
            // uxprojectProposals
            // 
            uxprojectProposals.DropDownItems.AddRange(new ToolStripItem[] { uxAddProposal, uxProposalStatus });
            uxprojectProposals.Name = "uxprojectProposals";
            uxprojectProposals.Size = new Size(251, 34);
            uxprojectProposals.Text = "Project Proposals";
            // 
            // uxAddProposal
            // 
            uxAddProposal.Name = "uxAddProposal";
            uxAddProposal.Size = new Size(237, 34);
            uxAddProposal.Text = "Add Proposal";
            uxAddProposal.Click += uxAddProposal_Click;
            // 
            // uxProposalStatus
            // 
            uxProposalStatus.Name = "uxProposalStatus";
            uxProposalStatus.Size = new Size(237, 34);
            uxProposalStatus.Text = "Proposal Status";
            uxProposalStatus.Click += uxProposalStatus_Click;
            // 
            // uxProjects
            // 
            uxProjects.DropDownItems.AddRange(new ToolStripItem[] { uxAddProject, uxProjectStatus });
            uxProjects.Name = "uxProjects";
            uxProjects.Size = new Size(251, 34);
            uxProjects.Text = "Projects";
            // 
            // uxAddProject
            // 
            uxAddProject.Name = "uxAddProject";
            uxAddProject.Size = new Size(221, 34);
            uxAddProject.Text = "Add Project";
            uxAddProject.Click += uxAddProject_Click;
            // 
            // uxProjectStatus
            // 
            uxProjectStatus.Name = "uxProjectStatus";
            uxProjectStatus.Size = new Size(221, 34);
            uxProjectStatus.Text = "Project Status";
            uxProjectStatus.Click += uxProjectStatus_Click;
            // 
            // uxTotalHoursPerProject
            // 
            uxTotalHoursPerProject.DisplayStyle = ToolStripItemDisplayStyle.Text;
            uxTotalHoursPerProject.Image = (Image)resources.GetObject("uxTotalHoursPerProject.Image");
            uxTotalHoursPerProject.ImageTransparentColor = Color.Magenta;
            uxTotalHoursPerProject.Name = "uxTotalHoursPerProject";
            uxTotalHoursPerProject.Size = new Size(194, 29);
            uxTotalHoursPerProject.Text = "Total Hours Per Project";
            uxTotalHoursPerProject.Click += uxTotalHoursPerProject_Click;
            // 
            // uxMonthlySales
            // 
            uxMonthlySales.DisplayStyle = ToolStripItemDisplayStyle.Text;
            uxMonthlySales.Image = (Image)resources.GetObject("uxMonthlySales.Image");
            uxMonthlySales.ImageTransparentColor = Color.Magenta;
            uxMonthlySales.Name = "uxMonthlySales";
            uxMonthlySales.Size = new Size(234, 29);
            uxMonthlySales.Text = "Monthly Sales By Employee";
            uxMonthlySales.Click += uxMonthlySales_Click;
            // 
            // uxCostSummary
            // 
            uxCostSummary.DisplayStyle = ToolStripItemDisplayStyle.Text;
            uxCostSummary.Image = (Image)resources.GetObject("uxCostSummary.Image");
            uxCostSummary.ImageTransparentColor = Color.Magenta;
            uxCostSummary.Name = "uxCostSummary";
            uxCostSummary.Size = new Size(192, 29);
            uxCostSummary.Text = "Project Cost Summary";
            uxCostSummary.Click += uxCostSummary_Click;
            // 
            // uxOutput
            // 
            uxOutput.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            uxOutput.Location = new Point(7, 92);
            uxOutput.Name = "uxOutput";
            uxOutput.RowHeadersWidth = 62;
            uxOutput.Size = new Size(1096, 372);
            uxOutput.TabIndex = 3;
            // 
            // UserInterface
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1118, 476);
            Controls.Add(uxOutput);
            Controls.Add(uxInfoStrip);
            Controls.Add(uxSearchBar);
            Controls.Add(uxSearchButton);
            Margin = new Padding(2, 2, 2, 2);
            Name = "UserInterface";
            Text = "Company Information";
            uxInfoStrip.ResumeLayout(false);
            uxInfoStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)uxOutput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button uxSearchButton;
        private TextBox uxSearchBar;
        private ToolStrip uxInfoStrip;
        private ToolStripLabel uxTabBar;
        private ToolStripDropDownButton uxEmployee;
        private ToolStripMenuItem uxAddEmployee;
        private ToolStripMenuItem uxUpdateEmployee;
        private ToolStripDropDownButton uxProjectsInfo;
        private ToolStripMenuItem uxprojectProposals;
        private ToolStripMenuItem uxAddProposal;
        private ToolStripDropDownButton uxCustomerButton;
        private ToolStripMenuItem uxAddCustomer;
        private ToolStripMenuItem uxUpdateCustomer;
        private ToolStripMenuItem uxEmployeeHours;
        private ToolStripMenuItem uxProposalStatus;
        private ToolStripMenuItem uxDeactivateCustomer;
        private ToolStripMenuItem uxDeactivateEmployee;
        private ToolStripMenuItem uxProjects;
        private ToolStripMenuItem uxAddProject;
        private ToolStripMenuItem uxProjectStatus;
        private ToolStripButton uxTotalHoursPerProject;
        private ToolStripButton uxMonthlySales;
        private ToolStripButton uxCostSummary;
        private DataGridView uxOutput;
    }
}
