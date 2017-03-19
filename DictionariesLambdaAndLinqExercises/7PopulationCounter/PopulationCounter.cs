using System;
using System.Collections.Generic;
using System.Linq;

namespace _7PopulationCounter
{
    public class PopulationCounter
    {
        public static void Main()
        {
            var populationStatistics = new Dictionary<string, Dictionary<string, long>>();
            var inputData = Console.ReadLine().Split('|').ToList();

            while (inputData[0] != "report")
            {
                var city = inputData[0];
                var country = inputData[1];
                var population = int.Parse(inputData[2]);
                if (!populationStatistics.ContainsKey(country))
                {
                    populationStatistics[country] = new Dictionary<string, long>();
                }
                if (!populationStatistics[country].ContainsKey(city))
                {
                    populationStatistics[country][city] = population;
                }


                inputData = Console.ReadLine().Split('|').ToList();
            }
            //var result = new Dictionary<string, Dictionary<string, int>>();

            //var sum = 0;
            foreach (var country in populationStatistics.OrderByDescending(x => x.Value.Sum(y => y.Value)))
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value.Sum(x=> x.Value)})");
                foreach (var cities in country.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"=>{cities.Key}: {cities.Value}");
                }
            }

            //Does not work!
            //foreach (var country in populationStatistics)
            //{
            //    //var sumOfTowns = country.Value.Select(x => x.Value).ToList();
            //    //Console.WriteLine(string.Join(", ",sumOfTowns.Sum()));
            //    List<int> sumOfTowns = country.Value.Select(x => x.Value).ToList();
            //    Console.WriteLine($"{country.Key} (total population: {sumOfTowns.Sum()})");
            //    Console.Write($"=>{string.Join("=>", country.Value.Select(x => $"{x.Key}: {x.Value}\r\n").OrderByDescending(x => x))}");
            //}

            // Work!
            //foreach (var country in populationStatistics.OrderByDescending(x => x.Value.Sum(y => y.Value)))
            //{
            //    List<long> sumOfTowns = country.Value.Select(x => x.Value).ToList();
            //    Console.WriteLine($"{country.Key} (total population: {sumOfTowns.Sum()})");

            //    Console.Write($"=>{string.Join("=>", country.Value.OrderByDescending(x => x.Value).Select(x => $"{x.Key}: {x.Value}\r\n"))}");
            //}

        }
    }
}
