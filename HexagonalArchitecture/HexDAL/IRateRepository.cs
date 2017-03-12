using System;

namespace Hex.DAL
{
    public interface IRateRepository
    {
        double GetRate(double amount);
    }
}
