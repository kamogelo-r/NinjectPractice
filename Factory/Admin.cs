using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Factory
{
    public class Admin
    {
        public readonly ICustomer cust; //DI: assigns objects; makes testing easier; less code for modifications

        /// <summary>
        /// custIOC passed from ninject
        /// </summary>
        /// <param name="custIOC"></param>
        public Admin(ICustomer custIOC) //IOC: binds an interface to its class and creates objects at runtime (ninject = IOC)
        {
            cust = custIOC;
        }

        public void GetCustomerDetails()
        {
            cust.GetDetails();
        }
    }
}
