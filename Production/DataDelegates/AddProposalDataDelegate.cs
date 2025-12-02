using Data;
using ProjectData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectData.DataDelegates
{
    internal class AddProposalDataDelegate(string projectName, string projectDetails,
       int customerId, int estimatedDurationHours, ProposalStatus status)
       : NonQueryDataDelegate<int>("Add_Proposal")
    {
        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);
            command.Parameters.AddWithValue("@ProjectName", projectName);
            command.Parameters.AddWithValue("@ProjectDetails", projectDetails);
            command.Parameters.AddWithValue("@CustomerID", customerId);
            command.Parameters.AddWithValue("@EstimatedDurationHours", estimatedDurationHours);
            command.Parameters.AddWithValue("@Status", status.ToString());
        }

        public override int Translate(Command command)
        {
            return 1;
        }
    }
}
