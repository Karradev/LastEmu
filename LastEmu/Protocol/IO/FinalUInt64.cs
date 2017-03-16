using System;

namespace Protocol.IO
{
    public class FinalUInt64
    {
        public uint High;
        public uint Low;

        public FinalUInt64(uint low = 0, int high = 0)
        {
            Low = low;
            High = (uint) high;
        }

        public static FinalUInt64 FromNumber(double param1) => new FinalUInt64((uint)param1, (int)Math.Floor(param1 / 4294967296));

        public double ToNumber() => (double)High * 4294967296 + Low;
    }
}