using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectData.DataDelegates
{
    internal class LogHoursDataDelegate(int projectId, int employeeId, string description,
       DateTime date, int hours)
       : DataDelegate("Log_Hours")
    {
        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);
            command.Parameters.AddWithValue("@ProjectID", projectId);
            command.Parameters.AddWithValue("@EmployeeID", employeeId);
            command.Parameters.AddWithValue("@Description", description);
            command.Parameters.AddWithValue("@Date", date);
            command.Parameters.AddWithValue("@Hours", hours);
        }
    }
}
