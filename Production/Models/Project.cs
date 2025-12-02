namespace ProjectData.Models
{
    public class Project
    {
        public int ProjectId { get; }
        public int CustomerId { get; }
        public string ProjectName { get; }
        public DateTime StartDate { get; }
        public DateTime? EndDate { get; }
        public int ManagerId { get; }
        public ProjectStatus Status { get; }

        internal Project(int projectId, int customerId, string projectName,
           DateTime startDate, DateTime? endDate, int managerId, ProjectStatus status)
        {
            ProjectId = projectId;
            CustomerId = customerId;
            ProjectName = projectName;
            StartDate = startDate;
            EndDate = endDate;
            ManagerId = managerId;
            Status = status;
        }
    }
}