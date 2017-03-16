using System;

namespace Protocol.IO
{
    public class FinalInt64
    {
        public int High;
        public double Low;

        public FinalInt64(double low = 0, int high = 0)
        {
            Low = low;
            High = high;
        }

        public static FinalInt64 FromNumber(double param1)
        {
            var num = Math.Floor(param1/4294967296);
            return new FinalInt64(param1, (int) num);
        }

        public double ToNumber() => (double) High*4294967296 + Low;
    }
}