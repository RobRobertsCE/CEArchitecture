using Hex.DAL;

namespace Hex.Business
{
    // Reference: http://alistair.cockburn.us/Hexagonal+architecture
    public class Discounter
    {
        private readonly IRateRepository _rateRepository;

        public Discounter(IRateRepository rateRepository)
        {
            _rateRepository = rateRepository;
        }

        public double Discount(double amount)
        {
            double rate = _rateRepository.GetRate(amount);
            return amount * rate;
        }
    }
}
