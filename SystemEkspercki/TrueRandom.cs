using System;

namespace SystemEkspercki
{
    /// <summary>
    /// True random
    /// </summary>
    public class TrueRandom : IRandom
    {
        /// <summary>
        /// readonly
        /// </summary>
        private readonly Random random;

        /// <summary>
        /// Constructor
        /// </summary>
        public TrueRandom()
        {
            random = new Random();
        }

        /// <summary>
        /// Next
        /// </summary>
        /// <param name="minValue"></param>
        /// <param name="maxValue"></param>
        /// <returns></returns>
        public int Next(int minValue, int maxValue)
        {
            return random.Next(minValue, maxValue);
        }

        /// <summary>
        /// Next
        /// </summary>
        /// <param name="maxValue"></param>
        /// <returns></returns>
        public int Next(int maxValue)
        {
            return random.Next(maxValue);
        }
    }
}