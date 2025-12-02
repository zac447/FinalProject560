using Data;
using ProjectData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectData.DataDelegates
{
    internal class UpdateEmployeeDataDelegate(int employeeId, int? managerId, string lastName,
       string firstName, DateTime dateOfBirth, string title, EmployeeStatus status, decimal hourlyRate)
       : DataDelegate("Update_Employee")
    {
        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);
            command.Parameters.AddWithValue("@EmployeeID", employeeId);
            command.Parameters.AddWithValue("@ManagerID", managerId ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@LastName", lastName);
            command.Parameters.AddWithValue("@FirstName", firstName);
            command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
            command.Parameters.AddWithValue("@Title", title);
            command.Parameters.AddWithValue("@Status", status.ToString());
            command.Parameters.AddWithValue("@HourlyRate", hourlyRate);
        }
    }
}
