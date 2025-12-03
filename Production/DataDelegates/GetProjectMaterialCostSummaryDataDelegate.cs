using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectData.DataDelegates
{
    internal class GetProjectMaterialCostSummaryDataDelegate(int? projectId = null, string? status = null)
       : DataReaderDelegate<IReadOnlyList<ProjectMaterialCostSummary>>("GetProjectMaterialCostSummary")
    {
        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);
            command.Parameters.AddWithValue("@ProjectID", projectId ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@Status", status ?? (object)DBNull.Value);
        }

        public override IReadOnlyList<ProjectMaterialCostSummary> Translate(Command command, IDataRowReader reader)
        {
            var results = new List<ProjectMaterialCostSummary>();
            while (reader.Read())
            {
                results.Add(new ProjectMaterialCostSummary(
                   reader.GetInt32("ProjectID"),
                   reader.GetString("ProjectName"),
                   reader.GetString("Status"),
                   reader.GetString("CustomerName"),
                   reader.GetString("ManagerName"),
                   reader.GetInt32("MaterialCount"),
                   reader.GetValue<decimal>("TotalMaterialCost"),
                   reader.GetDateTime("StartDate", DateTimeKind.Unspecified),
                   reader.GetValue<DateTime?>("EndDate", null)));
            }
            return results;
        }
    }
    public class ProjectMaterialCostSummary
    {
        public int ProjectId { get; }
        public string ProjectName { get; }
        public string Status { get; }
        public string CustomerName { get; }
        public string ManagerName { get; }
        public int MaterialCount { get; }
        public decimal TotalMaterialCost { get; }
        public DateTime StartDate { get; }
        public DateTime? EndDate { get; }

        public ProjectMaterialCostSummary(int projectId, string projectName, string status,
           string customerName, string managerName, int materialCount, decimal totalMaterialCost,
           DateTime startDate, DateTime? endDate)
        {
            ProjectId = projectId;
            ProjectName = projectName;
            Status = status;
            CustomerName = customerName;
            ManagerName = managerName;
            MaterialCount = materialCount;
            TotalMaterialCost = totalMaterialCost;
            StartDate = startDate;
            EndDate = endDate;
        }
    }
}
