using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectData.DataDelegates
{
    internal class MonthlySalesByEmployeeDataDelegate(DateTime? startDate = null, DateTime? endDate = null)
       : DataReaderDelegate<IReadOnlyList<EmployeeMonthlySales>>("MonthlySalesByEmployee")
    {
        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);
            command.Parameters.AddWithValue("@StartDate", startDate ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@EndDate", endDate ?? (object)DBNull.Value);
        }

        public override IReadOnlyList<EmployeeMonthlySales> Translate(Command command, IDataRowReader reader)
        {
            var results = new List<EmployeeMonthlySales>();
            while (reader.Read())
            {
                results.Add(new EmployeeMonthlySales(
                   reader.GetInt32("WorkYear"),
                   reader.GetInt32("WorkMonth"),
                   reader.GetInt32("EmployeeID"),
                   reader.GetString("EmployeeName"),
                   reader.GetInt32("TotalHours"),
                   reader.GetValue<decimal>("TotalSales"),
                   reader.GetInt32("SalesRankInMonth")));
            }
            return results;
        }
    }

    public class EmployeeMonthlySales
    {
        public int WorkYear { get; }
        public int WorkMonth { get; }
        public int EmployeeId { get; }
        public string EmployeeName { get; }
        public int TotalHours { get; }
        public decimal TotalSales { get; }
        public int SalesRankInMonth { get; }

        public EmployeeMonthlySales(int workYear, int workMonth, int employeeId, string employeeName,
           int totalHours, decimal totalSales, int salesRankInMonth)
        {
            WorkYear = workYear;
            WorkMonth = workMonth;
            EmployeeId = employeeId;
            EmployeeName = employeeName;
            TotalHours = totalHours;
            TotalSales = totalSales;
            SalesRankInMonth = salesRankInMonth;
        }
    }
}
