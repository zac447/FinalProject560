using ProjectData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectData
{
    public interface IProjectProposalRepository
    {
        /// <summary>
        /// Creates a new project proposal in the repository.
        /// </summary>
        /// <param name="projectName">Name of the proposed project.</param>
        /// <param name="projectDetails">Details of the proposed project.</param>
        /// <param name="customerId">Identifier of the customer for the proposal.</param>
        /// <param name="estimatedDurationHours">Estimated duration in hours.</param>
        /// <param name="status">Status of the proposal.</param>
        /// <returns>
        /// The result code indicating success or failure.
        /// </returns>
        int CreateProposal(string projectName, string projectDetails, int customerId,
           int estimatedDurationHours, ProposalStatus status);

        /// <summary>
        /// Updates the status of an existing project proposal.
        /// </summary>
        /// <param name="proposalId">Identifier of the proposal to update.</param>
        /// <param name="status">New status for the proposal.</param>
        void UpdateProposalStatus(int proposalId, ProposalStatus status);

        /// <summary>
        /// Lists project proposals filtered by customer or status.
        /// </summary>
        /// <param name="customerId">Optional customer ID to filter by.</param>
        /// <param name="status">Optional status to filter by.</param>
        /// <returns>
        /// <see cref="IReadOnlyList{ProjectProposal}"/> containing all matching proposals.
        /// </returns>
        IReadOnlyList<ProjectProposal> ListProposals(int? customerId = null, string? status = null);
    }
}
