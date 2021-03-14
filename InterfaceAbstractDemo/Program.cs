
using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapter;
using InterfaceAbstractDemo.Concrete;
using System;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            BaseCustomerManager baseCustomerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            baseCustomerManager.Save(new Customer { 
            DateOfBirth = new DateTime(1998,6,9),
            FirstName= "Mehmet Anıl",
            LastName="Çiftçi",
            NationalId="22"}
            );
            Console.ReadLine();

        }
    }
}
