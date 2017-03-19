using System;

namespace _2MaxMethod
{
    public class MaxMethod
    {
        static void Main()
        {
            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());
            var thirdNumber = int.Parse(Console.ReadLine());

            var bigger = GetMax(GetMax(firstNumber, secondNumber), thirdNumber);

            Console.WriteLine(bigger);


        }

        public static int GetMax(int a, int b)
        {
            var greater = Math.Max(a, b);
            //Console.WriteLine(greater);
            return greater;
           
        }
       
    }
}
