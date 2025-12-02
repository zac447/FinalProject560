using Data;
using ProjectData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectData.DataDelegates
{
    internal class UpdateCustomerDataDelegate(int customerId, string email, string lastName,
       string firstName, string phone, string address, string city, string state,
       string zipCode, CustomerStatus status)
       : DataDelegate("Update_Customer")
    {
        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);
            command.Parameters.AddWithValue("@CustomerID", customerId);
            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@LastName", lastName);
            command.Parameters.AddWithValue("@FirstName", firstName);
            command.Parameters.AddWithValue("@Phone", phone);
            command.Parameters.AddWithValue("@Address", address);
            command.Parameters.AddWithValue("@City", city);
            command.Parameters.AddWithValue("@State", state);
            command.Parameters.AddWithValue("@ZipCode", zipCode);
            command.Parameters.AddWithValue("@Status", status.ToString());
        }
    }
}
