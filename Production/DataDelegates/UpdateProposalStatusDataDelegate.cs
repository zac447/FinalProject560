using Data;
using ProjectData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectData.DataDelegates
{
    internal class UpdateProposalStatusDataDelegate(int proposalId, ProposalStatus status)
       : DataDelegate("Update_Proposal_Status")
    {
        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);
            command.Parameters.AddWithValue("@ProposalID", proposalId);
            command.Parameters.AddWithValue("@Status", status.ToString());
        }
    }
}