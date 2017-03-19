using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3BooleanVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputBool = Console.ReadLine();

            var output = Convert.ToBoolean(inputBool);
            //Console.WriteLine(Convert.ToBoolean(inputBool));
            Console.WriteLine((output == true) ? "Yes" : "No");
        
        }
    }
}
