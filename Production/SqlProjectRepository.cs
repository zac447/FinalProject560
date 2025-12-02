using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using ProjectData.DataDelegates;
using ProjectData.Models;

namespace ProjectData
{
    public class SqlProjectRepository(string connectionString) : IProjectRepository
    {
        private readonly SqlCommandExecutor executor = new(connectionString);

        public void CreateProject(int projectProposalId, int managerId, DateTime startDate, ProjectStatus status)
        {
            var d = new AddProjectDataDelegate(projectProposalId, managerId, startDate, status);
            executor.ExecuteNonQuery(d);
        }

        public void UpdateProjectStatus(int projectId, ProjectStatus status)
        {
            var d = new UpdateProjectStatusDataDelegate(projectId, status);
            executor.ExecuteNonQuery(d);
        }

        public IReadOnlyList<Project> SearchProjects(string? customerName = null, int? managerId = null,
           string? status = null)
        {
            var d = new SearchProjectsDataDelegate(customerName, managerId, status);
            return executor.ExecuteReader(d);
        }
    }
}
