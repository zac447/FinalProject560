using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectData
{
    using ProjectData.DataDelegates;

    public interface IProjectHoursRepository
    {
        /// <summary>
        /// Logs hours worked on a project by an employee.
        /// </summary>
        /// <param name="projectId">Identifier of the project.</param>
        /// <param name="employeeId">Identifier of the employee.</param>
        /// <param name="description">Description of work performed.</param>
        /// <param name="date">Date the work was performed.</param>
        /// <param name="hours">Number of hours worked.</param>
        void LogHours(int projectId, int employeeId, string description, DateTime date, int hours);

        /// <summary>
        /// Updates an existing time entry.
        /// </summary>
        /// <param name="projectHoursId">Identifier of the time entry to update.</param>
        /// <param name="hours">Updated number of hours.</param>
        /// <param name="description">Updated description of work performed.</param>
        void UpdateTimeEntry(int projectHoursId, int hours, string description);

        /// <summary>
        /// Gets the total hours worked on a project.
        /// </summary>
        /// <param name="projectId">Identifier of the project.</param>
        /// <returns>
        /// An instance of <see cref="ProjectHoursSummary"/> containing the total hours summary.
        /// </returns>
        /// <exception cref="DataAccess.RecordNotFoundException">
        /// Thrown if <paramref name="projectId"/> does not exist.
        /// </exception>
        ProjectHoursSummary GetTotalHoursForProject(int projectId);
    }
}
