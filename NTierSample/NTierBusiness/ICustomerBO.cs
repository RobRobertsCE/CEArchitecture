using System;

namespace NTierBusiness
{
    public interface ICustomerBO
    {
        Guid Id { get; set; }
        string Name { get; set; }
        int Age { get; set; }
    }
}
