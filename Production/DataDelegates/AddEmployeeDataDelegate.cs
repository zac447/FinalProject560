using Data;
using ProjectData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectData.DataDelegates
{
    internal class AddEmployeeDataDelegate(int? managerId, string lastName, string firstName,
       DateTime dateOfBirth, string title, DateTime dateOfHire, EmployeeStatus status, decimal hourlyRate)
       : NonQueryDataDelegate<int>("Add_Employee")
    {
        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);
            command.Parameters.AddWithValue("@ManagerID", managerId ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@LastName", lastName);
            command.Parameters.AddWithValue("@FirstName", firstName);
            command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
            command.Parameters.AddWithValue("@Title", title);
            command.Parameters.AddWithValue("@DateOfHire", dateOfHire);
            command.Parameters.AddWithValue("@Status", status.ToString());
            command.Parameters.AddWithValue("@HourlyRate", hourlyRate);
        }

        public override int Translate(Command command)
        {
            return 1;
        }
    }
}
