using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HornetAssault
{
    class Program
    {
        static void Main(string[] args)
        {
            var behaivs = Console.ReadLine().Split().Select(long.Parse).ToArray();

            var hornets = Console.ReadLine().Split().Select(long.Parse).ToArray();

            var powerOfHornets = hornets.Sum();

            

            for (int i = 0; i < behaivs.Length; i++)
            {
                if (powerOfHornets > behaivs[i])
                {
                    behaivs[i] = 0;
                }
                if (powerOfHornets <= behaivs[i])
                {
                    behaivs[i] = behaivs[i] - powerOfHornets;
                    for (int h = 0; h < hornets.Length; h++)
                    {
                        if (hornets[h] > 0)
                        {
                            hornets[h] = 0;
                            powerOfHornets = hornets.Sum();
                            break;
                        }
                    }
                }
            }

            if (behaivs.Sum() > 0)
            {
                Console.Write(string.Join(" ",behaivs.Where(x => x > 0)));
            }
            else
            {
                Console.Write(string.Join(" ", hornets.Where(x => x > 0)));
            }
            Console.WriteLine();
        }
    }
}
