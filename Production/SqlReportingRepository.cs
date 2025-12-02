using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using ProjectData.DataDelegates;

namespace ProjectData
{
    public class SqlReportingRepository(string connectionString) : IReportingRepository
    {
        private readonly SqlCommandExecutor executor = new(connectionString);

        public IReadOnlyList<EmployeeMonthlySales> GetMonthlySalesByEmployee(DateTime? startDate = null,
           DateTime? endDate = null)
        {
            var d = new MonthlySalesByEmployeeDataDelegate(startDate, endDate);
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<ManagerProjectInfo> GetManagerProjects(int? managerId = null, string? status = null)
        {
            var d = new ManagerApprovedProjectsDataDelegate(managerId, status);
            return executor.ExecuteReader(d);
        }

        public IReadOnlyList<ProjectCostSummary> GetProjectCostSummary(int? projectId = null, string? status = null)
        {
            var d = new GetProjectCostSummaryDataDelegate(projectId, status);
            return executor.ExecuteReader(d);
        }
    }
}
