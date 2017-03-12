using System;
using Hex.DAL;
using Hex.WinApp;

namespace Hex.UITests
{
    public class TestDiscountAdapter
    {
        private IRateRepository _mockRepository;
        private DiscountViewAdapter _adapter;

        public TestDiscountAdapter()
        {
            _mockRepository = RepositoryFactory.GetMockRateRepository();
            _adapter = new DiscountViewAdapter(_mockRepository);
        }

        public void RunTests()
        {
            var result1 = RunTest(100, 5);
            Console.WriteLine("Test 1 result: {0}", result1.ToString());

            var result2 = RunTest(200, 10);
            Console.WriteLine("Test 2 result: {0}", result2.ToString());

            var result3 = RunTest(1001, 50);
            Console.WriteLine("Test 3 result: {0}", result3.ToString());
        }

        public bool RunTest(double amount, double expectedRate)
        {
           var rate = _adapter.GetRate(amount);
           return (rate == expectedRate);
        }
    }
}
