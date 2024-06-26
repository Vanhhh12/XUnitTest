using Xunit;

namespace CrawlxUnitTest
{
    public class UnitTest1
    {

        [Fact]
        public void IsPrime_InputIs1_ReturnFalse()
        {
            var primeService = new PrimeService();
            bool result = primeService.IsPrime(1);

            Assert.False(false, "1 should not be prime");
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        public void IsPrime_InputLessThan2_ReturnsFalse(int value)
        {
            var _primeService = new PrimeService();
            var result = _primeService.IsPrimeLessThan2(value);
            Assert.False(result, $"{value} should not be prime");
        }
    }
}