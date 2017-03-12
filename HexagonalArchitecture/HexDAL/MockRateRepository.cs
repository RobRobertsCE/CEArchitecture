using System;

namespace Hex.DAL
{
    public class MockRateRepository : IRateRepository
    {
        public double GetRate(double amount)
        {
            if (amount <= 100.00) return 0.01;
            if (amount <= 1000.00) return 0.02;
            return 0.05;
        }
    }
}
