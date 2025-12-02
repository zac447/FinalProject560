namespace ProjectData.Models
{
    public class ProjectHours
    {
        public int ProjectHoursId { get; }
        public int ProjectId { get; }
        public int EmployeeId { get; }
        public string Description { get; }
        public DateTime WorkPerformedDate { get; }
        public int Hours { get; }

        internal ProjectHours(int projectHoursId, int projectId, int employeeId,
           string description, DateTime workPerformedDate, int hours)
        {
            ProjectHoursId = projectHoursId;
            ProjectId = projectId;
            EmployeeId = employeeId;
            Description = description;
            WorkPerformedDate = workPerformedDate;
            Hours = hours;
        }
    }
}