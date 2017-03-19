using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13PracticeIntegerNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte sbyteValue = -100;
            byte byteValue = 128;
            short shortValue = -3540;
            ushort ushortValue = 64876;
            uint uintValue = 2147483648;
            int intValue = -1141583228;
            long longValue = -1223372036854775808;

            Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n{6} ", sbyteValue, byteValue, shortValue, ushortValue, uintValue, intValue, longValue);
        }
    }
}
