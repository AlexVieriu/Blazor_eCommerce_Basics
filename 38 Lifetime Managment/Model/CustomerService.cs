using System;
using System.Collections.Generic;
using System.Linq;

namespace Lifetime_Managment.Model
{
    public class CustomerService : ICustomerService
    {
        private List<Customer> customers;
        public string UniqueId { get; set; }

        public CustomerService()
        {
            UniqueId = Guid.NewGuid().ToString();

            customers = new List<Customer>()
             {
                 new Customer{ Id=1, Name="Tom"},
                 new Customer{ Id=1, Name="John"},
                 new Customer{ Id=1, Name="Jane"}
             };
        }

        public Customer GetCustomerById(int id)
        {
            return customers.FirstOrDefault(c => c.Id == id);
        }
    }
}
