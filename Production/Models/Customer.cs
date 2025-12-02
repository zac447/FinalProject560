namespace ProjectData.Models
{
    public class Customer
    {
        public int CustomerId { get; }
        public string Email { get; }
        public string LastName { get; }
        public string FirstName { get; }
        public string Phone { get; }
        public string Address { get; }
        public string City { get; }
        public string State { get; }
        public string ZipCode { get; }
        public CustomerStatus Status { get; }

        internal Customer(int customerId, string email, string lastName, string firstName,
           string phone, string address, string city, string state, string zipCode, CustomerStatus status)
        {
            CustomerId = customerId;
            Email = email;
            LastName = lastName;
            FirstName = firstName;
            Phone = phone;
            Address = address;
            City = city;
            State = state;
            ZipCode = zipCode;
            Status = status;
        }
    }
}