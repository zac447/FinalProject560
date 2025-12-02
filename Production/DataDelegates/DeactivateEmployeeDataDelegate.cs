using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectData.DataDelegates
{
    internal class DeactivateEmployeeDataDelegate(int employeeId)
       : DataDelegate("Deactivate_Employee")
    {
        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);
            command.Parameters.AddWithValue("@EmployeeID", employeeId);
        }
    }
}
