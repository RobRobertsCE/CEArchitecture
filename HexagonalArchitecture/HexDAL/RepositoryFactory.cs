using System;

namespace Hex.DAL
{
    public class RepositoryFactory
    {
        public RepositoryFactory()
        {

        }

        public static IRateRepository GetMockRateRepository()
        {
            return new MockRateRepository();
        }

        public static IRateRepository GetRateRepository()
        {
            return new RateRepository();
        }
    }
}
