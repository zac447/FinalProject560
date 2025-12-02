namespace ProjectData.Models
{
    public class Employee
    {
        public int EmployeeId { get; }
        public int? ManagerId { get; }
        public string LastName { get; }
        public string FirstName { get; }
        public DateTime DateOfBirth { get; }
        public string Title { get; }
        public DateTime DateOfHire { get; }
        public EmployeeStatus Status { get; }
        public decimal HourlyRate { get; }

        internal Employee(int employeeId, int? managerId, string lastName, string firstName,
           DateTime dateOfBirth, string title, DateTime dateOfHire, EmployeeStatus status, decimal hourlyRate)
        {
            EmployeeId = employeeId;
            ManagerId = managerId;
            LastName = lastName;
            FirstName = firstName;
            DateOfBirth = dateOfBirth;
            Title = title;
            DateOfHire = dateOfHire;
            Status = status;
            HourlyRate = hourlyRate;
        }
    }
}
