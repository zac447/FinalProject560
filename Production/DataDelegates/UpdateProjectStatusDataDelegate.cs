using Data;
using ProjectData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectData.DataDelegates
{
    internal class UpdateProjectStatusDataDelegate(int projectId, ProjectStatus status)
       : DataDelegate("Update_Project_Status")
    {
        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);
            command.Parameters.AddWithValue("@ProjectID", projectId);
            command.Parameters.AddWithValue("@Status", status.ToString());
        }
    }
}