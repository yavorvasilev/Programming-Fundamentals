using System;
using System.Linq;
using System.Collections.Generic;

namespace _4AverageGrades
{
    public class AverageGrades
    {
        public static void Main()
        {
            var listOfStudent = new List<Student>();

            var numberOfStudents = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= numberOfStudents; i++)
            {
                var input = Console.ReadLine().Split();

                var student = new Student
                {
                    Name = input[0],
                    Grade = new double[input.Length - 1]
                };
            
                for (int grade = 0; grade < student.Grade.Length; grade++)
                {
                    student.Grade[grade] = double.Parse(input[grade + 1]);
                }
                var averageGrade = student.AverageGrade();

                if (averageGrade >= 5)
                {
                    listOfStudent.Add(student);
                }
            }

            foreach (var item in listOfStudent.OrderBy(x=> x.Name).ThenByDescending(x => x.Grade.Average()))
            {
                Console.WriteLine($"{item.Name} -> {item.AverageGrade():F2}");
            }
        }
    }
}
