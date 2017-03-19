using System.Linq;

namespace _4AverageGrades
{
    public class Student
    {
        public string Name { get; set; }

        public double[] Grade { get; set; }

        public double AverageGrade()
        {
            return Grade.Average();
        }
    }
}
