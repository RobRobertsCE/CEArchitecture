using System;

namespace NTierBusiness
{
    public sealed class CustomerBO : ICustomerBO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public CustomerBO()
        {

        }

        public CustomerBO(Guid id, string name, int age)
            : this()
        {
            Id = id;
            Name = name;
            Age = age;
        }

        public string GetFirstName()
        {
            return Name.Split(' ')[0];
        }
    }
}
