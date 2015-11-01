using System;

namespace SystemEkspercki
{
    public class TrueRandom : IRandom
    {
        private readonly Random random;

        public TrueRandom()
        {
            random = new Random();
        }

        public int Next(int minValue, int maxValue)
        {
            return random.Next(minValue, maxValue);
        }

        public int Next(int maxValue)
        {
            return random.Next(maxValue);
        }
    }
}
