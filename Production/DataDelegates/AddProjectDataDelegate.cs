using Data;
using ProjectData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectData.DataDelegates
{
    internal class AddProjectDataDelegate(int projectProposalId, int managerId,
       DateTime startDate, ProjectStatus status)
       : DataDelegate("Add_Project")
    {
        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);
            command.Parameters.AddWithValue("@ProjectProposalID", projectProposalId);
            command.Parameters.AddWithValue("@ManagerID", managerId);
            command.Parameters.AddWithValue("@StartDate", startDate);
            command.Parameters.AddWithValue("@Status", status.ToString());
        }
    }
}
