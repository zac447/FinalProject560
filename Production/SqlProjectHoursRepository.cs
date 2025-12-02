using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using ProjectData.DataDelegates;

namespace ProjectData
{
    public class SqlProjectHoursRepository(string connectionString) : IProjectHoursRepository
    {
        private readonly SqlCommandExecutor executor = new(connectionString);

        public void LogHours(int projectId, int employeeId, string description, DateTime date, int hours)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(description);

            if (hours <= 0)
                throw new ArgumentException("Hours must be greater than zero.", nameof(hours));

            var d = new LogHoursDataDelegate(projectId, employeeId, description, date, hours);
            executor.ExecuteNonQuery(d);
        }

        public void UpdateTimeEntry(int projectHoursId, int hours, string description)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(description);

            if (hours <= 0)
                throw new ArgumentException("Hours must be greater than zero.", nameof(hours));

            var d = new UpdateTimeEntryDataDelegate(projectHoursId, hours, description);
            executor.ExecuteNonQuery(d);
        }

        public ProjectHoursSummary GetTotalHoursForProject(int projectId)
        {
            var d = new GetTotalHoursPerProjectDataDelegate(projectId);
            return executor.ExecuteReader(d);
        }
    }
}
