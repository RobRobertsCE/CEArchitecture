using System;
using NTierDAL;

namespace NTierBusiness.Adapters
{
    internal static class CustomerDTOAdapter
    {
        public static ICustomerBO FromDTO(ICustomerDTO dto)
        {
            var bo = new CustomerBO();
            bo.Id = dto.CustomerId;
            bo.Name = String.Format("{0} {1}", dto.FirstName, dto.LastName);
            bo.Age = dto.Age;

            return bo;
        }

        public static ICustomerDTO ToDTO(ICustomerBO bo)
        {
            ICustomerDTO dto = new CustomerDTO();
            dto.CustomerId = bo.Id;
            if (bo.Name.Contains(" "))
            {
                string[] names = bo.Name.Split(' ');
                dto.FirstName = names[0];
                dto.LastName = names[1];
            }
            else
            {
                dto.FirstName = bo.Name;
            }
            dto.Age = bo.Age;

            return dto;
        }
    }
}
