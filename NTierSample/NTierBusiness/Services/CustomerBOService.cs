using System;
using System.Collections.Generic;
using NTierBusiness.Factory;
using NTierDAL;
using NTierDAL.Factory;

namespace NTierBusiness.Services
{
    public sealed class CustomerBOService : ICustomerBOService
    {
        private readonly ICustomerBOFactory _factory;

        public CustomerBOService()
        {
            _factory = new CustomerBOFactory();
        }

        public ICustomerBO GetCustomer(Guid id)
        {
            return _factory.GetAggregateObject(id);
        }

        public IList<ICustomerBO> GetCustomers()
        {
            return _factory.GetAggregateObjects();
        }

        public void Save(ICustomerBO customer)
        {
            _factory.Save(customer);
        }

        public void Delete(Guid id)
        {
            _factory.Delete(id);
        }

        public ICustomerBO CreateNew()
        {
            return new CustomerBO() { Id = Guid.NewGuid() };
        }
    }
}
