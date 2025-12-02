using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectData.DataDelegates
{
    internal class GetProjectCostSummaryDataDelegate(int? projectId = null, string? status = null)
       : DataReaderDelegate<IReadOnlyList<ProjectCostSummary>>("GetProjectCostSummary")
    {
        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);
            command.Parameters.AddWithValue("@ProjectID", projectId ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@Status", status ?? (object)DBNull.Value);
        }

        public override IReadOnlyList<ProjectCostSummary> Translate(Command command, IDataRowReader reader)
        {
            var results = new List<ProjectCostSummary>();
            while (reader.Read())
            {
                results.Add(new ProjectCostSummary(
                   reader.GetInt32("ProjectID"),
                   reader.GetString("ProjectName"),
                   reader.GetString("Status"),
                   reader.GetString("CustomerName"),
                   reader.GetString("ManagerName"),
                   reader.GetValue<decimal>("TotalMaterialCost"),
                   reader.GetInt32("TotalLaborHours"),
                   reader.GetValue<decimal>("AvgHourlyRate"),
                   reader.GetValue<decimal>("TotalLaborCost"),
                   reader.GetValue<decimal>("TotalProjectCost"),
                   reader.GetDateTime("StartDate",DateTimeKind.Unspecified),
                   reader.GetValue<DateTime?>("EndDate", null)));
            }
            return results;
        }
    }

    public class ProjectCostSummary
    {
        public int ProjectId { get; }
        public string ProjectName { get; }
        public string Status { get; }
        public string CustomerName { get; }
        public string ManagerName { get; }
        public decimal TotalMaterialCost { get; }
        public int TotalLaborHours { get; }
        public decimal AvgHourlyRate { get; }
        public decimal TotalLaborCost { get; }
        public decimal TotalProjectCost { get; }
        public DateTime StartDate { get; }
        public DateTime? EndDate { get; }

        public ProjectCostSummary(int projectId, string projectName, string status, string customerName,
           string managerName, decimal totalMaterialCost, int totalLaborHours, decimal avgHourlyRate,
           decimal totalLaborCost, decimal totalProjectCost, DateTime startDate, DateTime? endDate)
        {
            ProjectId = projectId;
            ProjectName = projectName;
            Status = status;
            CustomerName = customerName;
            ManagerName = managerName;
            TotalMaterialCost = totalMaterialCost;
            TotalLaborHours = totalLaborHours;
            AvgHourlyRate = avgHourlyRate;
            TotalLaborCost = totalLaborCost;
            TotalProjectCost = totalProjectCost;
            StartDate = startDate;
            EndDate = endDate;
        }
    }
}
