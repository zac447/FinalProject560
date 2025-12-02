using ProjectData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectData
{
    public interface IProjectRepository
    {
        /// <summary>
        /// Creates a new project from an approved proposal.
        /// </summary>
        /// <param name="projectProposalId">Identifier of the approved proposal.</param>
        /// <param name="managerId">Identifier of the project manager.</param>
        /// <param name="startDate">Start date of the project.</param>
        /// <param name="status">Initial status of the project.</param>
        void CreateProject(int projectProposalId, int managerId, DateTime startDate, ProjectStatus status);

        /// <summary>
        /// Updates the status of an existing project.
        /// </summary>
        /// <param name="projectId">Identifier of the project to update.</param>
        /// <param name="status">New status for the project.</param>
        void UpdateProjectStatus(int projectId, ProjectStatus status);

        /// <summary>
        /// Searches for projects based on the provided criteria.
        /// </summary>
        /// <param name="customerName">Optional customer name to search for.</param>
        /// <param name="managerId">Optional manager ID to search for.</param>
        /// <param name="status">Optional status to search for.</param>
        /// <returns>
        /// <see cref="IReadOnlyList{Project}"/> containing all matching projects.
        /// </returns>
        IReadOnlyList<Project> SearchProjects(string? customerName = null, int? managerId = null,
           string? status = null);
    }
}
