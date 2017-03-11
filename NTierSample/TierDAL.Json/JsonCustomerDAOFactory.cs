using NTierDAL;

namespace NTierDAL.Json
{
    public class JsonCustomerDAOFactory : ICustomerDAOFactory
    {
        public ICustomerDAO GetDAO()
        {
            return new JsonCustomerDAO();
        }
    }
}
