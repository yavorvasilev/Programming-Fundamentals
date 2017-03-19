using System;

namespace _10CubeProperties
{
    public class CubeProperties
    {
        public static void Main()
        {
            var sideOfTheCube = double.Parse(Console.ReadLine());
            var propertie = Console.ReadLine();

            var result = GetPropertie(sideOfTheCube, propertie);
            Console.WriteLine("{0:F2}",Math.Round(result,2));
        }

        public static double GetPropertie(double side, string propertie)
        {
            var result = 0d;
            if (propertie == "face")
            {
                result = Math.Sqrt(2 * Math.Pow(side, 2));
                return result;
            }
            else if (propertie == "space")
            {
                result = Math.Sqrt(3 * Math.Pow(side, 2));
                return result;
            }
            else if (propertie == "volume")
            {
                result = Math.Pow(side, 3);
                return result;
            }
            else 
            {
                result = 6 * Math.Pow(side, 2);
                return result;
            }

        }
    }
}
