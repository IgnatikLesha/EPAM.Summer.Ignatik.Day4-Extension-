using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    public static class ExtensionForDouble
    {
        public static string Performance(this double x)
        {
            StringBuilder result = new StringBuilder();
            byte[] bytes = BitConverter.GetBytes(x);

            foreach (var a in bytes)
            {
                result.Insert(0, BinaryPerformance(a));
            }
            return result.ToString();
        }

        private static string BinaryPerformance(int x)
        {
            int bits = 8;
            string result = Convert.ToString(x, 2);
            int len = result.Length;
            if (len < bits)
                for (int i = len; i < bits; i++)
                    result = result.Insert(0, "0");
            return result;
        }
    }
}
