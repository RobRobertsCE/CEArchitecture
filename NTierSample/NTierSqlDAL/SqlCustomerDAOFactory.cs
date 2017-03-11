using NTierDAL;

namespace NTierDAL.Sql
{
    public class SqlCustomerDAOFactory : ICustomerDAOFactory
    {
        public ICustomerDAO GetDAO()
        {
            return new SqlCustomerDAO();
        }
    }
}
