using ProjectData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectData
{
    public interface ICustomerRepository
    {
        /// <summary>
        /// Creates a new customer in the repository.
        /// </summary>
        /// <param name="email">Email of the customer to create.</param>
        /// <param name="lastName">Last name of the customer to create.</param>
        /// <param name="firstName">First name of the customer to create.</param>
        /// <param name="phone">Phone number of the customer to create.</param>
        /// <param name="address">Address of the customer to create.</param>
        /// <param name="city">City of the customer to create.</param>
        /// <param name="state">State of the customer to create.</param>
        /// <param name="zipCode">Zip code of the customer to create.</param>
        /// <param name="status">Status of the customer to create.</param>
        /// <returns>
        /// The result code indicating success or failure.
        /// </returns>
        int CreateCustomer(string email, string lastName, string firstName, string phone,
           string address, string city, string state, string zipCode, CustomerStatus status);

        /// <summary>
        /// Updates an existing customer in the repository.
        /// </summary>
        /// <param name="customerId">Identifier of the customer to update.</param>
        /// <param name="email">Updated email of the customer.</param>
        /// <param name="lastName">Updated last name of the customer.</param>
        /// <param name="firstName">Updated first name of the customer.</param>
        /// <param name="phone">Updated phone number of the customer.</param>
        /// <param name="address">Updated address of the customer.</param>
        /// <param name="city">Updated city of the customer.</param>
        /// <param name="state">Updated state of the customer.</param>
        /// <param name="zipCode">Updated zip code of the customer.</param>
        /// <param name="status">Updated status of the customer.</param>
        void UpdateCustomer(int customerId, string email, string lastName, string firstName,
           string phone, string address, string city, string state, string zipCode, CustomerStatus status);

        /// <summary>
        /// Deactivates the customer with the given <paramref name="customerId"/>.
        /// </summary>
        /// <param name="customerId">Identifier of the customer to deactivate.</param>
        void DeactivateCustomer(int customerId);

        /// <summary>
        /// Searches for customers based on the provided criteria.
        /// </summary>
        /// <param name="customerId">Optional customer ID to search for.</param>
        /// <param name="lastName">Optional last name to search for.</param>
        /// <param name="firstName">Optional first name to search for.</param>
        /// <param name="city">Optional city to search for.</param>
        /// <param name="status">Optional status to search for.</param>
        /// <returns>
        /// <see cref="IReadOnlyList{Customer}"/> containing all matching customers.
        /// </returns>
        IReadOnlyList<Customer> SearchCustomers(int? customerId = null, string? lastName = null,
           string? firstName = null, string? city = null, string? status = null);
    }
}
