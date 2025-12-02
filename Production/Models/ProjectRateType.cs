namespace ProjectData.Models
{
    public class ProjectRateType
    {
        public int RateId { get; }
        public int ProjectId { get; }
        public decimal HourlyRate { get; }
        public DateTime StartDate { get; }
        public DateTime? EndDate { get; }

        internal ProjectRateType(int rateId, int projectId, decimal hourlyRate,
           DateTime startDate, DateTime? endDate)
        {
            RateId = rateId;
            ProjectId = projectId;
            HourlyRate = hourlyRate;
            StartDate = startDate;
            EndDate = endDate;
        }
    }
}