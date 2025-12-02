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
    public class SqlProjectProposalRepository(string connectionString) : IProjectProposalRepository
    {
        private readonly SqlCommandExecutor executor = new(connectionString);

        public int CreateProposal(string projectName, string projectDetails, int customerId,
           int estimatedDurationHours, ProposalStatus status)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(projectName);
            ArgumentException.ThrowIfNullOrWhiteSpace(projectDetails);

            if (estimatedDurationHours <= 0)
                throw new ArgumentException("Estimated duration must be greater than zero.", nameof(estimatedDurationHours));

            var d = new AddProposalDataDelegate(projectName, projectDetails, customerId,
               estimatedDurationHours, status);
            return executor.ExecuteNonQuery(d);
        }

        public void UpdateProposalStatus(int proposalId, ProposalStatus status)
        {
            var d = new UpdateProposalStatusDataDelegate(proposalId, status);
            executor.ExecuteNonQuery(d);
        }

        public IReadOnlyList<ProjectProposal> ListProposals(int? customerId = null, string? status = null)
        {
            var d = new ListProposalByStatusOrCustomerDataDelegate(customerId, status);
            return executor.ExecuteReader(d);
        }
    }
}
