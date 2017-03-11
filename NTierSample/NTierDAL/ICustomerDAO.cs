using System;
using System.Collections.Generic;

namespace NTierDAL
{
    public interface ICustomerDAO
    {
        ICustomerDTO Get(Guid id);
        IEnumerable<ICustomerDTO> GetAll();
        void Add(ICustomerDTO itemToInsert);
        void Update(ICustomerDTO itemToUpdate);
        void Delete(Guid id);
    }
}
