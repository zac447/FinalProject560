using Data;
using ProjectData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectData.DataDelegates
{
    internal class ListProposalByStatusOrCustomerDataDelegate(int? customerId = null, string? status = null)
       : DataReaderDelegate<IReadOnlyList<ProjectProposal>>("List_Proposal_By_Status_OR_Customer")
    {
        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);
            command.Parameters.AddWithValue("@CustomerID", customerId ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@Status", status ?? (object)DBNull.Value);
        }

        public override IReadOnlyList<ProjectProposal> Translate(Command command, IDataRowReader reader)
        {
            var proposals = new List<ProjectProposal>();
            while (reader.Read())
            {
                proposals.Add(new ProjectProposal(
                   reader.GetInt32("ProjectProposalID"),
                   reader.GetString("ProjectName"),
                   reader.GetString("ProjectDetails"),
                   reader.GetInt32("CustomerID"),
                   reader.GetInt32("EstimatedDurationHours"),
                   Enum.Parse<ProposalStatus>(reader.GetString("Status"))));
            }
            return proposals;
        }
    }
}
