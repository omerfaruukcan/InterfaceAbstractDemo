using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using System;

namespace InterfaceAbstractDemo.Concrete
{
    public class StarbuckCustomerManager : BaseCustomerManager
    {
        private ICustomerCheckService _customerCheckService;

        public StarbuckCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }
        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                Console.WriteLine("Not a valid person");
            }
        }
    }
}
