namespace CrawlxUnitTest
{
    public class PrimeService
    {
        public bool IsPrime(int candidate)
        {
            if (candidate == 1)
            {
                return false;
            }
            else return true;   
        }

        public bool IsPrimeLessThan2(int candidate) {
            if (candidate < 2)
            {
                return false;
            } else
            {
                return true;
            }
        }
    }
}