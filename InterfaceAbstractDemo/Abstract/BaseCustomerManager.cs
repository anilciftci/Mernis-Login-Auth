using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Abstract
{
    public abstract class BaseCustomerManager : ICustomerServices
    {
        public virtual void Save(Customer customer)
        {

            Console.WriteLine("Saved to db : " + customer.FirstName );

        }
    }
}
