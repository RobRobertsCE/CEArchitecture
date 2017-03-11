using System;
using NTierDAL.Sql;

namespace NTierDAL.Factory
{
    public static class DAOFactory
    {
        private enum DataSources
        {
            SQL,
            Excel,
            JSON
        }

        private static DataSources _preferredDataSource = DataSources.SQL;

        public static ICustomerDAO GetDAO()
        {
            ICustomerDAO dao;

            switch(_preferredDataSource)
            {
                case DataSources.SQL:
                    {
                        var factory = new SqlCustomerDAOFactory();
                        dao = factory.GetDAO();
                        break;
                    }
                case DataSources.Excel:
                    {
                        throw new NotImplementedException();
                    }
                case DataSources.JSON:
                    {
                        throw new NotImplementedException();
                    }
                default:
                    {
                        throw new ArgumentException("Undefined data source: {0}", _preferredDataSource.ToString());
                    }
            }

            return dao;
        }
    }
}
