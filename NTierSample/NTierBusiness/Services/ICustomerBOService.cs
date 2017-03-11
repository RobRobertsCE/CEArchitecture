using System;
using System.Collections.Generic;
using NTierBusiness;

namespace NTierBusiness.Services
{
    public interface ICustomerBOService
    {
        ICustomerBO GetCustomer(Guid id);
        IList<ICustomerBO> GetCustomers();
        void Save(ICustomerBO customer);
        void Delete(Guid id);
        ICustomerBO CreateNew();
    }
}
