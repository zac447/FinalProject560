namespace UserInterface2
{
    public partial class UserInterface : Form
    {
        public UserInterface()
        {
            InitializeComponent();
        }

        public bool ValidateNulls(string value, string field)
        {
            if (string.IsNullOrEmpty(value))
            {
                MessageBox.Show($"{field} cannot be left blank.");
                return false;
            }
            return true;
        }

        public bool CheckCheckBoxes(bool box1, bool box2, string field)
        {
            if (box1 == false && box2 == false)
            {
                MessageBox.Show($"A {field} must be selected.");
                return false;
            }
            if (box1 == true && box2 == true)
            {
                MessageBox.Show($"Only one {field} can be selected.");
                return false;
            }
            return true;
        }

        private void uxSearchButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void uxAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomer addNewCustomer = new AddCustomer();
            addNewCustomer.ShowDialog();
        }

        private void uxUpdateCustomer_Click(object sender, EventArgs e)
        {
            UpdateCustomer updateCustomer = new UpdateCustomer();
            updateCustomer.ShowDialog();
        }

        private void uxAddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployee addNewEmployee = new AddEmployee();
            addNewEmployee.ShowDialog();
        }

        private void uxUpdateEmployee_Click(object sender, EventArgs e)
        {
            UpdateEmployee updateEmployee = new UpdateEmployee();
            updateEmployee.ShowDialog();
        }

        private void uxEmployeeHours_Click(object sender, EventArgs e)
        {
            LogHours logHours = new LogHours();
            logHours.ShowDialog();
        }

        private void uxAddProposal_Click(object sender, EventArgs e)
        {
            AddProposal addProposal = new AddProposal();
            addProposal.ShowDialog();
        }

        private void uxProposalStatus_Click(object sender, EventArgs e)
        {
            UpdateProposalStatus updateStatus = new UpdateProposalStatus();
            updateStatus.ShowDialog();
        }

        private void uxAddProject_Click(object sender, EventArgs e)
        {
            AddProject addProject = new AddProject();
            addProject.ShowDialog();
        }

        private void uxProjectStatus_Click(object sender, EventArgs e)
        {
            UpdateProposalStatus updateStatus = new UpdateProposalStatus();
            updateStatus.ShowDialog();
        }

        private void uxTotalHoursPerProject_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void uxMonthlySales_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void uxCostSummary_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
