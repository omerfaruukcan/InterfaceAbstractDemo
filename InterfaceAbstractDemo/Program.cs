using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager baseCustomerManager = new StarbuckCustomerManager(new CustomerCheckManager());
            baseCustomerManager.Save(new Customer { DateofBirth = 1998, FirstName = "Ömer Faruk", LastName = "Can", NationalityId = 48310496724 });

            BaseCustomerManager baseCustomerManager1 = new NeroCustomerManager(new CustomerCheckManager());
            baseCustomerManager1.Save(new Customer { FirstName = "Busra" });
        }
    }
}
