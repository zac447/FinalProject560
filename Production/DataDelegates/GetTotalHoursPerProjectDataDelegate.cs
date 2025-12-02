using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectData.DataDelegates
{
    internal class GetTotalHoursPerProjectDataDelegate(int projectId)
       : DataReaderDelegate<ProjectHoursSummary>("Get_Total_Hours_Per_Project")
    {
        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);
            command.Parameters.AddWithValue("@ProjectID", projectId);
        }

        public override ProjectHoursSummary Translate(Command command, IDataRowReader reader)
        {
            if (!reader.Read())
                throw new RecordNotFoundException(projectId.ToString());

            return new ProjectHoursSummary(
               reader.GetInt32("ProjectID"),
               reader.GetInt32("ProjectHours"),
               reader.GetString("FirstName"),
               reader.GetString("LastName"),
               reader.GetString("ProjectName"));
        }
    }

    public class ProjectHoursSummary
    {
        public int ProjectId { get; }
        public int TotalHours { get; }
        public string CustomerFirstName { get; }
        public string CustomerLastName { get; }
        public string ProjectName { get; }

        public ProjectHoursSummary(int projectId, int totalHours, string customerFirstName,
           string customerLastName, string projectName)
        {
            ProjectId = projectId;
            TotalHours = totalHours;
            CustomerFirstName = customerFirstName;
            CustomerLastName = customerLastName;
            ProjectName = projectName;
        }
    }
}