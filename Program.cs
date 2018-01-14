using System;

namespace FlippingBits
{
    class Program
    {
        static void Main(String[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                long n = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine(flippingBits(n));
            }
        }

        static long flippingBits(long N)
        {
            uint res = 0;
            for (int i = 0; i < 32; i++)
            {
                int bit = (int)(N & 1);
                res += (uint)((1 - bit) << i);
                N >>= 1;
            }
            return res;
        }
    }
}