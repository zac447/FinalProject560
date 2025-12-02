using ProjectData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectData
{
    public interface IEmployeeRepository
    {
        /// <summary>
        /// Creates a new employee in the repository.
        /// </summary>
        /// <param name="managerId">Optional manager ID of the employee to create.</param>
        /// <param name="lastName">Last name of the employee to create.</param>
        /// <param name="firstName">First name of the employee to create.</param>
        /// <param name="dateOfBirth">Date of birth of the employee to create.</param>
        /// <param name="title">Job title of the employee to create.</param>
        /// <param name="dateOfHire">Hire date of the employee to create.</param>
        /// <param name="status">Employment status of the employee to create.</param>
        /// <param name="hourlyRate">Hourly rate of the employee to create.</param>
        /// <returns>
        /// The result code indicating success or failure.
        /// </returns>
        int CreateEmployee(int? managerId, string lastName, string firstName, DateTime dateOfBirth,
           string title, DateTime dateOfHire, EmployeeStatus status, decimal hourlyRate);

        /// <summary>
        /// Updates an existing employee in the repository.
        /// </summary>
        /// <param name="employeeId">Identifier of the employee to update.</param>
        /// <param name="managerId">Updated manager ID of the employee.</param>
        /// <param name="lastName">Updated last name of the employee.</param>
        /// <param name="firstName">Updated first name of the employee.</param>
        /// <param name="dateOfBirth">Updated date of birth of the employee.</param>
        /// <param name="title">Updated job title of the employee.</param>
        /// <param name="status">Updated employment status of the employee.</param>
        /// <param name="hourlyRate">Updated hourly rate of the employee.</param>
        void UpdateEmployee(int employeeId, int? managerId, string lastName, string firstName,
           DateTime dateOfBirth, string title, EmployeeStatus status, decimal hourlyRate);

        /// <summary>
        /// Deactivates the employee with the given <paramref name="employeeId"/>.
        /// </summary>
        /// <param name="employeeId">Identifier of the employee to deactivate.</param>
        void DeactivateEmployee(int employeeId);

        /// <summary>
        /// Searches for employees based on the provided criteria.
        /// </summary>
        /// <param name="employeeId">Optional employee ID to search for.</param>
        /// <param name="managerId">Optional manager ID to search for.</param>
        /// <param name="lastName">Optional last name to search for.</param>
        /// <param name="firstName">Optional first name to search for.</param>
        /// <param name="dateOfBirth">Optional date of birth to search for.</param>
        /// <param name="title">Optional job title to search for.</param>
        /// <param name="dateOfHire">Optional hire date to search for.</param>
        /// <param name="status">Optional employment status to search for.</param>
        /// <param name="hourlyRate">Optional hourly rate to search for.</param>
        /// <returns>
        /// <see cref="IReadOnlyList{Employee}"/> containing all matching employees.
        /// </returns>
        IReadOnlyList<Employee> SearchEmployees(int? employeeId = null, int? managerId = null,
           string? lastName = null, string? firstName = null, DateTime? dateOfBirth = null,
           string? title = null, DateTime? dateOfHire = null, string? status = null, decimal? hourlyRate = null);
    }
}
