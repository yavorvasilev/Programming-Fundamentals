using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _15CenturiesToNanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            long centuries = long.Parse(Console.ReadLine());
            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes = {5} seconds = {6} milliseconds = {7} microseconds = {8} nanoseconds", centuries,
                centuries * 100, Math.Floor(centuries * 100 * 365.2422), 24 * Math.Floor(centuries * 100 * 365.2422),
                60 * (24 * Math.Floor(centuries * 100 * 365.2422)), 60 * (60 * (24 * Math.Floor(centuries * 100 * 365.2422))), 
                1000 * (60 * (60 * (24 * Math.Floor(centuries * 100 * 365.2422)))), (BigInteger)(1000000 * (60 * (60 * (24 * Math.Floor(centuries * 100 * 365.2422))))),
                (BigInteger)(1000000000 * (60 * (60 * (24 * Math.Floor(centuries * 100 * 365.2422))))));
        }
    }
}
