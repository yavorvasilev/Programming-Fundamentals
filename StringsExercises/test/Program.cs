using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {

            var str = Console.ReadLine();

            for (int i = 0; i < str.Length; i++)
            {
                var num = int.Parse(str[i].ToString());

                Console.WriteLine(num);
            }
        }
    }
}
