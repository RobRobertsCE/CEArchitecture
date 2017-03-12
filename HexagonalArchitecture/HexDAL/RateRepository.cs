using System;

namespace Hex.DAL
{
    public class RateRepository : IRateRepository
    {
        public double GetRate(double amount)
        {
           // implement read from data source here
            return 0.10;
        }
    }
}