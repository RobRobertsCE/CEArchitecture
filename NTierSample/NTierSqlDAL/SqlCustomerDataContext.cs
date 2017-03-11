using System.Data.Entity;

namespace NTierDAL.Sql
{
    internal class SqlCustomerDataContext : DbContext
    {
        public DbSet<SqlCustomerModel> Customers { get; set; }

        public SqlCustomerDataContext()
            : base()
        {

        }
    }
}
