using System;

namespace NTierDAL
{
    public interface ICustomerDTO
    {
        Guid CustomerId { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        int Age { get; set; }
    }
}
