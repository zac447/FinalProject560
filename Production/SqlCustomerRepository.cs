using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using ProjectData.DataDelegates;
using ProjectData.Models;

namespace ProjectData
{
    public class SqlCustomerRepository(string connectionString) : ICustomerRepository
    {
        private readonly SqlCommandExecutor executor = new(connectionString);

        public int CreateCustomer(string email, string lastName, string firstName, string phone,
           string address, string city, string state, string zipCode, CustomerStatus status)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(email);
            ArgumentException.ThrowIfNullOrWhiteSpace(lastName);
            ArgumentException.ThrowIfNullOrWhiteSpace(firstName);
            ArgumentException.ThrowIfNullOrWhiteSpace(phone);
            ArgumentException.ThrowIfNullOrWhiteSpace(address);
            ArgumentException.ThrowIfNullOrWhiteSpace(city);
            ArgumentException.ThrowIfNullOrWhiteSpace(state);
            ArgumentException.ThrowIfNullOrWhiteSpace(zipCode);

            if (phone.Length != 10)
                throw new ArgumentException("Phone number must be ten digits.", nameof(phone));
            if (zipCode.Length != 5)
                throw new ArgumentException("Zip code must be five characters.", nameof(zipCode));

            var d = new AddCustomerDataDelegate(email, lastName, firstName, phone, address,
               city, state, zipCode, status);
            return executor.ExecuteNonQuery(d);
        }

        public void UpdateCustomer(int customerId, string email, string lastName, string firstName,
           string phone, string address, string city, string state, string zipCode, CustomerStatus status)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(email);
            ArgumentException.ThrowIfNullOrWhiteSpace(lastName);
            ArgumentException.ThrowIfNullOrWhiteSpace(firstName);
            ArgumentException.ThrowIfNullOrWhiteSpace(phone);
            ArgumentException.ThrowIfNullOrWhiteSpace(address);
            ArgumentException.ThrowIfNullOrWhiteSpace(city);
            ArgumentException.ThrowIfNullOrWhiteSpace(state);
            ArgumentException.ThrowIfNullOrWhiteSpace(zipCode);

            var d = new UpdateCustomerDataDelegate(customerId, email, lastName, firstName,
               phone, address, city, state, zipCode, status);
            executor.ExecuteNonQuery(d);
        }

        public void DeactivateCustomer(int customerId)
        {
            var d = new DeactivateCustomerDataDelegate(customerId);
            executor.ExecuteNonQuery(d);
        }

        public IReadOnlyList<Customer> SearchCustomers(int? customerId = null, string? lastName = null,
           string? firstName = null, string? city = null, string? status = null)
        {
            var d = new SearchCustomerDataDelegate(customerId, lastName, firstName, city, status);
            return executor.ExecuteReader(d);
        }
    }
}
