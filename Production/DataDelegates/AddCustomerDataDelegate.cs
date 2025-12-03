using Data;
using ProjectData.Models;
using System.Data;

namespace ProjectData.DataDelegates
{
    internal class AddCustomerDataDelegate(string email, string lastName, string firstName,
       string phone, string address, string city, string state, string zipCode, CustomerStatus status)
       : NonQueryDataDelegate<int>("Sales.Add_Customer") //added sales.
    {
        public override void PrepareCommand(Command command)
        {
            base.PrepareCommand(command);
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

        public override int Translate(Command command)
        {
            // Return affected rows or could add output parameter for CustomerID
            return 1;
        }
    }
}
