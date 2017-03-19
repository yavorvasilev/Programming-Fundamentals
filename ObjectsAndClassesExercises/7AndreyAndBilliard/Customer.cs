using System.Linq;
using System.Collections.Generic;

namespace _7AndreyAndBilliard
{
    public class Customer
    {
        public string Name { get; set; }

        public Dictionary<string, int> Order { get; set; }

        public decimal Bill { get; set; }
    }
}
