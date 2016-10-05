using System;

namespace Codehunt
{
    public static class Methods
    {
        public static int Level_02_05(int n)
        {
            return n*(n-1)*(2*n-1)/6;
        }

        public static int Level_02_07(string s, char x)
        {
            var xs = new String(x, 1);
            return s.Length - s.Replace(xs, null).Length;
        }

        public static int Level_03_01(int number, int power)
        {
            return (int)(long)Math.Pow(number, power);
        }
    }
}