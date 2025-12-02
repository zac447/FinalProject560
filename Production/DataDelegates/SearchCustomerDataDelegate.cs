using Data;
using ProjectData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectData.DataDelegates
{
    internal class SearchCustomerDataDelegate(int? customerId = null, string? lastName = null,
       string? firstName = null, string? city = null, string? status = null)
       : DataReaderDelegate<IReadOnlyList<Customer>>("Search_Customer")
    {
        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);
            command.Parameters.AddWithValue("@CustomerID", customerId ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@LastName", lastName ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@FirstName", firstName ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@City", city ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@Status", status ?? (object)DBNull.Value);
        }

        public override IReadOnlyList<Customer> Translate(Command command, IDataRowReader reader)
        {
            var customers = new List<Customer>();
            while (reader.Read())
            {
                customers.Add(new Customer(
                   reader.GetInt32("CustomerID"),
                   reader.GetString("Email"),
                   reader.GetString("LastName"),
                   reader.GetString("FirstName"),
                   reader.GetString("Phone"),
                   reader.GetString("Address"),
                   reader.GetString("City"),
                   reader.GetString("State"),
                   reader.GetString("ZipCode"),
                   Enum.Parse<CustomerStatus>(reader.GetString("Status"))));
            }
            return customers;
        }
    }
}
