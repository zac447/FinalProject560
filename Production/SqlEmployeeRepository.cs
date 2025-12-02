using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using ProjectData.DataDelegates;
using ProjectData.Models;

namespace ProjectData
{
    public class SqlEmployeeRepository(string connectionString) : IEmployeeRepository
    {
        private readonly SqlCommandExecutor executor = new(connectionString);

        public int CreateEmployee(int? managerId, string lastName, string firstName, DateTime dateOfBirth,
           string title, DateTime dateOfHire, EmployeeStatus status, decimal hourlyRate)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(lastName);
            ArgumentException.ThrowIfNullOrWhiteSpace(firstName);
            ArgumentException.ThrowIfNullOrWhiteSpace(title);

            if (hourlyRate <= 0)
                throw new ArgumentException("Hourly rate must be greater than zero.", nameof(hourlyRate));

            var d = new AddEmployeeDataDelegate(managerId, lastName, firstName, dateOfBirth,
               title, dateOfHire, status, hourlyRate);
            return executor.ExecuteNonQuery(d);
        }

        public void UpdateEmployee(int employeeId, int? managerId, string lastName, string firstName,
           DateTime dateOfBirth, string title, EmployeeStatus status, decimal hourlyRate)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(lastName);
            ArgumentException.ThrowIfNullOrWhiteSpace(firstName);
            ArgumentException.ThrowIfNullOrWhiteSpace(title);

            var d = new UpdateEmployeeDataDelegate(employeeId, managerId, lastName, firstName,
               dateOfBirth, title, status, hourlyRate);
            executor.ExecuteNonQuery(d);
        }

        public void DeactivateEmployee(int employeeId)
        {
            var d = new DeactivateEmployeeDataDelegate(employeeId);
            executor.ExecuteNonQuery(d);
        }

        public IReadOnlyList<Employee> SearchEmployees(int? employeeId = null, int? managerId = null,
           string? lastName = null, string? firstName = null, DateTime? dateOfBirth = null,
           string? title = null, DateTime? dateOfHire = null, string? status = null, decimal? hourlyRate = null)
        {
            var d = new SearchEmployeeDataDelegate(employeeId, managerId, lastName, firstName,
               dateOfBirth, title, dateOfHire, status, hourlyRate);
            return executor.ExecuteReader(d);
        }
    }
}
