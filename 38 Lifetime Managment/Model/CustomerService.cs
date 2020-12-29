using System;

namespace Lifetime_Managment.Model
{
    public class CustomerServices : ICustomerScoped, ICustomerSingleton
    {
        public string singletonGuid { get; set; }
        public string scopedGuid { get; set; }


        public CustomerServices()
        {
            singletonGuid = Guid.NewGuid().ToString();
            scopedGuid = Guid.NewGuid().ToString();
        }
    }
}

