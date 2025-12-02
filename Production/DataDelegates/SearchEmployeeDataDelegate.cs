using Data;
using ProjectData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectData.DataDelegates
{
    internal class SearchEmployeeDataDelegate(int? employeeId = null, int? managerId = null,
       string? lastName = null, string? firstName = null, DateTime? dateOfBirth = null,
       string? title = null, DateTime? dateOfHire = null, string? status = null, decimal? hourlyRate = null)
       : DataReaderDelegate<IReadOnlyList<Employee>>("Search_Employee")
    {
        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);
            command.Parameters.AddWithValue("@EmployeeID", employeeId ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@ManagerID", managerId ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@LastName", lastName ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@FirstName", firstName ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@Title", title ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@DateOfHire", dateOfHire ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@Status", status ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@HourlyRate", hourlyRate ?? (object)DBNull.Value);
        }

        public override IReadOnlyList<Employee> Translate(Command command, IDataRowReader reader)
        {
            var employees = new List<Employee>();
            while (reader.Read())
            {
                employees.Add(new Employee(
                   reader.GetInt32("EmployeeID"),
                   reader.GetValue<int?>("ManagerID", null),
                   reader.GetString("LastName"),
                   reader.GetString("FirstName"),
                   reader.GetDateTime("DateOfBirth", DateTimeKind.Unspecified),
                   reader.GetString("Title"),
                   reader.GetDateTime("DateOfHire", DateTimeKind.Unspecified),
                   Enum.Parse<EmployeeStatus>(reader.GetString("Status")),
                   reader.GetValue<decimal>("HourlyRate")));
            }
            return employees;
        }
    }
}
