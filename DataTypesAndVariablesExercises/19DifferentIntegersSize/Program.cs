using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace _19DifferentIntegersSize
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            try
            {
                var integerNumber = Convert.ToInt64(input);
                //long integerNumber = long.Parse(Console.ReadLine());

                Console.WriteLine("{0} can fit in:", integerNumber);

                if (integerNumber >= sbyte.MinValue && integerNumber <= sbyte.MaxValue)
                {
                    Console.WriteLine("* sbyte");
                }
                if (integerNumber >= byte.MinValue && integerNumber <= byte.MaxValue)
                {
                    Console.WriteLine("* byte");
                }
                if (integerNumber >= short.MinValue && integerNumber <= short.MaxValue)
                {
                    Console.WriteLine("* short");
                }
                if (integerNumber >= ushort.MinValue && integerNumber <= ushort.MaxValue)
                {
                    Console.WriteLine("* ushort");
                }
                if (integerNumber >= int.MinValue && integerNumber <= int.MaxValue)
                {
                    Console.WriteLine("* int");
                }
                if (integerNumber >= uint.MinValue && integerNumber <= uint.MaxValue)
                {
                    Console.WriteLine("* uint");
                }
                if (integerNumber >= long.MinValue && integerNumber <= long.MaxValue)
                {
                    Console.WriteLine("* long");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("{0} can't fit in any type", input);
            }
          
        }
    }
}
