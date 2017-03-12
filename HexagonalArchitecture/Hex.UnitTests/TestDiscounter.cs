using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hex.Business;
using Hex.DAL;

namespace Hex.UnitTests
{
    public class TestDiscounter
    {
        public void RunTests()
        {
            var result1 = RunTest(100, 5);
            Console.WriteLine("Test 1 result: {0}", result1.ToString());

            var result2 = RunTest(200, 10);
            Console.WriteLine("Test 2 result: {0}", result2.ToString());

            var result3 = RunTest(1001, 50);
            Console.WriteLine("Test 3 result: {0}", result3.ToString());
        }

        private bool RunTest(double amount, double expectedResult)
        {
            Discounter app = new Discounter(RepositoryFactory.GetMockRateRepository());
            var result = app.Discount(amount);
            return (result == expectedResult);
        }
    }
}
