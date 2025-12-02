using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectData.DataDelegates
{
    internal class UpdateTimeEntryDataDelegate(int projectHoursId, int hours, string description)
       : DataDelegate("Update_Time_Entry")
    {
        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);
            command.Parameters.AddWithValue("@ProjectHoursID", projectHoursId);
            command.Parameters.AddWithValue("@Hours", hours);
            command.Parameters.AddWithValue("@Description", description);
        }
    }
}
