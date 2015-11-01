using SystemEkspercki;

namespace SystemEksperckiTests
{
    public class RandomForTest : IRandom
    {
        public int Next(int minValue, int maxValue)
        {
            return 5;
        }

        public int Next(int maxValue)
        {
            return 7;
        }
    }
}
