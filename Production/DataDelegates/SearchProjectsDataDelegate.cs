using Data;
using ProjectData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectData.DataDelegates
{
    internal class SearchProjectsDataDelegate(string? customerName = null, int? managerId = null, string? status = null)
       : DataReaderDelegate<IReadOnlyList<Project>>("Search_Projects")
    {
        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);
            command.Parameters.AddWithValue("@CustomerName", customerName ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@ManagerID", managerId ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@Status", status ?? (object)DBNull.Value);
        }

        public override IReadOnlyList<Project> Translate(Command command, IDataRowReader reader)
        {
            var projects = new List<Project>();
            while (reader.Read())
            {
                projects.Add(new Project(
                   reader.GetInt32("ProjectID"),
                   reader.GetInt32("CustomerID"),
                   reader.GetString("ProjectName"),
                   reader.GetDateTime("StartDate", DateTimeKind.Unspecified),
                   reader.GetValue<DateTime?>("EndDate", null),
                   reader.GetInt32("ManagerID"),
                   Enum.Parse<ProjectStatus>(reader.GetString("Status"))));
            }
            return projects;
        }
    }
}
