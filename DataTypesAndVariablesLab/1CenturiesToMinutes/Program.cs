using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1CenturiesToMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            long centuries = long.Parse(Console.ReadLine());
            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes", centuries,
                centuries * 100, Math.Floor(centuries * 100 * 365.2422), 24 * Math.Floor(centuries * 100 * 365.2422),
                60 * (24 * Math.Floor(centuries * 100 * 365.2422)));
        }
    }
}
