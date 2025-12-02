using Data;

namespace ProjectData.DataDelegates
{
    internal class ManagerApprovedProjectsDataDelegate(int? managerId = null, string? status = null)
       : DataReaderDelegate<IReadOnlyList<ManagerProjectInfo>>("ManagerApprovedProjects")
    {
        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);
            command.Parameters.AddWithValue("@ManagerID", managerId ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@Status", status ?? (object)DBNull.Value);
        }

        public override IReadOnlyList<ManagerProjectInfo> Translate(Command command, IDataRowReader reader)
        {
            var results = new List<ManagerProjectInfo>();
            while (reader.Read())
            {
                results.Add(new ManagerProjectInfo(
                   reader.GetInt32("ManagerID"),
                   reader.GetString("ManagerName"),
                   reader.GetInt32("ProjectID"),
                   reader.GetString("ProjectName"),
                   reader.GetInt32("CustomerID"),
                   reader.GetString("CustomerName"),
                   reader.GetString("Status"),
                   reader.GetDateTime("StartDate", DateTimeKind.Unspecified),
                   reader.GetValue<DateTime?>("EndDate", null)));
            }
            return results;
        }
    }

    public class ManagerProjectInfo
    {
        public int ManagerId { get; }
        public string ManagerName { get; }
        public int ProjectId { get; }
        public string ProjectName { get; }
        public int CustomerId { get; }
        public string CustomerName { get; }
        public string Status { get; }
        public DateTime StartDate { get; }
        public DateTime? EndDate { get; }

        public ManagerProjectInfo(int managerId, string managerName, int projectId, string projectName,
           int customerId, string customerName, string status, DateTime startDate, DateTime? endDate)
        {
            ManagerId = managerId;
            ManagerName = managerName;
            ProjectId = projectId;
            ProjectName = projectName;
            CustomerId = customerId;
            CustomerName = customerName;
            Status = status;
            StartDate = startDate;
            EndDate = endDate;
        }
    }
}
