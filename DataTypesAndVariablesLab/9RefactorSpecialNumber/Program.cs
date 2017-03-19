using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9RefactorSpecialNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            int sum = 0;
            //int itIs = 0;
            bool isItTrue = false;
            for (int number = 1; number <= inputNumber; number++)
            {
                //itIs = number;
                //while (number > 0)
                //{
                    sum += number % 10 + number / 10;
                    //number = number / 10;
                //}
                isItTrue = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{number} -> {isItTrue}");
                sum = 0;
                //number = itIs;
            }

        }
    }
}
