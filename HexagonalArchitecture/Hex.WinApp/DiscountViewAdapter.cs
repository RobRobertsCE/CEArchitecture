using Hex.Business;
using Hex.DAL;

namespace Hex.WinApp
{
    public class DiscountViewAdapter
    {
        private readonly Discounter _app;

        public DiscountViewAdapter()
        {
            _app = new Discounter(RepositoryFactory.GetRateRepository());
        }

        public DiscountViewAdapter(IRateRepository repository)
        {
            _app = new Discounter(repository);
        }

        public double GetRate(double amount)
        {
            return _app.Discount(amount);
        }
    }
}
