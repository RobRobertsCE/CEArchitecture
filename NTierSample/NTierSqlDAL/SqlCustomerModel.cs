using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NTierDAL;

namespace NTierDAL.Sql
{
    [Table("Customers")]
    internal class SqlCustomerModel : CustomerDTO, ICustomerDTO
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public virtual Guid CustomerId { get; set; }
        [Required, MaxLength(30)]
        public virtual string FirstName { get; set; }
        [Required, MaxLength(30)]
        public virtual string LastName { get; set; }
        public virtual int Age { get; set; }   

        public SqlCustomerModel()
        {

        }
    }
}
