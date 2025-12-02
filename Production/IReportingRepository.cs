using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectData
{
    using ProjectData.DataDelegates;

    public interface IReportingRepository
    {
        /// <summary>
        /// Retrieves monthly sales data by employee.
        /// </summary>
        /// <param name="startDate">Optional start date for the report period.</param>
        /// <param name="endDate">Optional end date for the report period.</param>
        /// <returns>
        /// <see cref="IReadOnlyList{EmployeeMonthlySales}"/> containing monthly sales data.
        /// </returns>
        IReadOnlyList<EmployeeMonthlySales> GetMonthlySalesByEmployee(DateTime? startDate = null,
           DateTime? endDate = null);

        /// <summary>
        /// Retrieves projects managed by a specific manager.
        /// </summary>
        /// <param name="managerId">Optional manager ID to filter by.</param>
        /// <param name="status">Optional status to filter by.</param>
        /// <returns>
        /// <see cref="IReadOnlyList{ManagerProjectInfo}"/> containing manager project data.
        /// </returns>
        IReadOnlyList<ManagerProjectInfo> GetManagerProjects(int? managerId = null, string? status = null);

        /// <summary>
        /// Retrieves cost summary for projects.
        /// </summary>
        /// <param name="projectId">Optional project ID to filter by.</param>
        /// <param name="status">Optional status to filter by.</param>
        /// <returns>
        /// <see cref="IReadOnlyList{ProjectCostSummary}"/> containing project cost data.
        /// </returns>
        IReadOnlyList<ProjectCostSummary> GetProjectCostSummary(int? projectId = null, string? status = null);
    }
}
