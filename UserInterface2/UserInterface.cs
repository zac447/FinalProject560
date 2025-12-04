using ProjectData;
using ProjectData.DataDelegates;
using System.Text;

namespace UserInterface2
{
    public partial class UserInterface : Form
    {
        private readonly SqlCustomerRepository _custrepo;

        private readonly SqlEmployeeRepository _empRepo;

        private readonly SqlProjectHoursRepository _projHoursRepo;

        private readonly SqlProjectProposalRepository _proposalRepo;

        private readonly SqlProjectRepository _projectRepo;

        private readonly SqlReportingRepository _reportRepo;

        private const string ConnectionString = @"Server=(localdb)\MSSQLLocalDb;Database=FinalProject560DB;Integrated Security=SSPI;";

        public UserInterface()
        {
            InitializeComponent();
            _custrepo = new SqlCustomerRepository(ConnectionString);
            _empRepo = new SqlEmployeeRepository(ConnectionString);
            _projHoursRepo = new SqlProjectHoursRepository(ConnectionString);
            _proposalRepo = new SqlProjectProposalRepository(ConnectionString);
            _projectRepo = new SqlProjectRepository(ConnectionString);
            _reportRepo = new SqlReportingRepository(ConnectionString);
        }

        private void uxSearchButton_Click(object sender, EventArgs e)
        {
            string term = uxSearchBar.Text.Trim();
            var custResults = _custrepo.SearchCustomers(lastName: term);
            //var empResults = _empRepo.SearchEmployees(lastName: term);
            uxOutput.DataSource = custResults.ToList();
            //uxOutput.DataSource = empResults.ToList();
        }

        private void uxAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomer addNewCustomer = new AddCustomer(_custrepo);
            if (addNewCustomer.ShowDialog() == DialogResult.OK)
            {
                uxOutput.DataSource = _custrepo.SearchCustomers();
            }
        }

        private void uxUpdateCustomer_Click(object sender, EventArgs e)
        {
            UpdateCustomer updateCustomer = new UpdateCustomer(_custrepo);
            if (updateCustomer.ShowDialog() == DialogResult.OK)
            {
                uxOutput.DataSource = _custrepo.SearchCustomers();
            }
        }

        private void uxAddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployee addNewEmployee = new AddEmployee(_empRepo);
            if (addNewEmployee.ShowDialog() == DialogResult.OK)
            {
                uxOutput.DataSource = _empRepo.SearchEmployees();
            }
        }

        private void uxUpdateEmployee_Click(object sender, EventArgs e)
        {
            UpdateEmployee updateEmployee = new UpdateEmployee(_empRepo);
            if (updateEmployee.ShowDialog() == DialogResult.OK)
            {
                uxOutput.DataSource = _empRepo.SearchEmployees();
            }
        }

        private void uxEmployeeHours_Click(object sender, EventArgs e)
        {
            LogHours logHours = new LogHours();
            if (logHours.ShowDialog() == DialogResult.OK)
            {
                //uxOutput.DataSource = _projHoursRepo.LogHours();
            }
        }

        private void uxAddProposal_Click(object sender, EventArgs e)
        {
            AddProposal addProposal = new AddProposal(_proposalRepo);
            if (addProposal.ShowDialog() == DialogResult.OK)
            {
                uxOutput.DataSource = _proposalRepo.ListProposals();
            }
        }

        private void uxProposalStatus_Click(object sender, EventArgs e)
        {
            UpdateProposalStatus updateStatus = new UpdateProposalStatus(_proposalRepo);
            if (updateStatus.ShowDialog() == DialogResult.OK)
            {
                uxOutput.DataSource = _proposalRepo.ListProposals();
            }
        }

        private void uxAddProject_Click(object sender, EventArgs e)
        {
            AddProject addProject = new AddProject(_projectRepo);
            if (addProject.ShowDialog() == DialogResult.OK)
            {
                uxOutput.DataSource = _projectRepo.SearchProjects();
            }
        }

        private void uxProjectStatus_Click(object sender, EventArgs e)
        {
            UpdateProjectStatus updateStatus = new UpdateProjectStatus(_projectRepo);
            if (updateStatus.ShowDialog() == DialogResult.OK)
            {
                uxOutput.DataSource = _projectRepo.SearchProjects();
            }
        }

        private void uxTotalHoursPerProject_Click(object sender, EventArgs e)
        {
            using TotalHoursPerProject hours = new TotalHoursPerProject();
            if (hours.ShowDialog() == DialogResult.OK)
            {
                var results = _projHoursRepo.GetTotalHoursForProject(hours.ProjectID);
                uxOutput.DataSource = new List<ProjectHoursSummary> { results };
            }
        }

        private void uxMonthlySales_Click(object sender, EventArgs e)
        {
            using MonthlySalesByEmployeeForm salesByEmp = new MonthlySalesByEmployeeForm();
            if (salesByEmp.ShowDialog() == DialogResult.OK)
            {
                var results = _reportRepo.GetMonthlySalesByEmployee(salesByEmp.Start, salesByEmp.End);
                uxOutput.DataSource = results.ToList();
            }
        }

        private void uxCostSummary_Click(object sender, EventArgs e)
        {
            using ProjectCostSummaryForm costSummary = new ProjectCostSummaryForm();
            if (costSummary.ShowDialog() == DialogResult.OK)
            {
                var results = _reportRepo.GetProjectCostSummary(costSummary.ProjectID);
                uxOutput.DataSource = results.ToList();
            }
        }

        private void uxProjectMaterialCost_Click(object sender, EventArgs e)
        {
            using ProjectMaterialCost materialCost = new ProjectMaterialCost();
            if (materialCost.ShowDialog() == DialogResult.OK)
            {
                var results = _reportRepo.GetProjectMaterialCostSummary(materialCost.ProjectID);
                uxOutput.DataSource = results.ToList();
            }
        }
    }
}
