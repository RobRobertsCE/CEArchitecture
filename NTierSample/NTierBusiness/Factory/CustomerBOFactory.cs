using System;
using System.Collections.Generic;
using NTierBusiness.Adapters;
using NTierDAL;
using NTierDAL.Factory;

namespace NTierBusiness.Factory
{
    // Business logic should be applied here.
    internal class CustomerBOFactory : ICustomerBOFactory
    {
        private readonly ICustomerDAO _dao;

        public CustomerBOFactory ()
        {
            _dao = DAOFactory.GetDAO();
        }

        public CustomerBOFactory(ICustomerDAO dao)
        {
            _dao = dao;
        }

        public ICustomerBO GetAggregateObject(Guid id)
        {
            var dto = _dao.Get(id);
            if (null == dto)
                return null;
            else
                return CustomerDTOAdapter.FromDTO(dto);
        }

        public IList<ICustomerBO> GetAggregateObjects()
        {
            var result = new List<ICustomerBO>();
            var dtoList = _dao.GetAll();
            foreach (var dto in dtoList)
            {
                result.Add(CustomerDTOAdapter.FromDTO(dto));
            }
            return result;
        }

        public void Save(ICustomerBO dto)
        {
            _dao.Add(CustomerDTOAdapter.ToDTO(dto));
        }

        public void Delete(Guid id)
        {
            _dao.Delete(id);
        }
    }
}
