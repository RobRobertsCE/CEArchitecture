using System;
using NTierDAL;

namespace NTierDAL
{
    public class CustomerDTO : ICustomerDTO
    {
        public virtual Guid CustomerId { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual int Age { get; set; }

        public CustomerDTO()
        {

        }
    }
}
