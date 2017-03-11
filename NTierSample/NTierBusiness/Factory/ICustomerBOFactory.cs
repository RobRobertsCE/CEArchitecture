using System;
using System.Collections.Generic;

namespace NTierBusiness.Factory
{
    public interface ICustomerBOFactory
    {
        ICustomerBO GetAggregateObject(Guid id);
        IList<ICustomerBO> GetAggregateObjects();
        void Save(ICustomerBO customer);
        void Delete(Guid id);
    }
}
