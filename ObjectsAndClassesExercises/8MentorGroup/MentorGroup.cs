using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _8MentorGroup
{
    public class MentorGroup
    {
        public static void Main()
        {
            var listOfStudents = new List<Student>();
            var input = Console.ReadLine();

            while (input != "end of dates")
            {
                var inputDate = input.Split(' ', ',');
                var user = inputDate[0];
                var datesAtended = new List<DateTime>();

                for (int i = 1; i < inputDate.Length; i++)
                {
                    var date = DateTime.ParseExact((inputDate[i]), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    datesAtended.Add(date);
                }

                if (listOfStudents.Any(x => x.Name == user))
                {
                    foreach (var student in listOfStudents)
                    {
                        if (student.Name == user)
                        {
                            student.Attendency.AddRange(datesAtended);
                            break;
                        }
                    }
                }
                else
                {
                    var student = new Student();
                    student.Name = user;
                    student.Attendency = new List<DateTime>();
                    student.Attendency = datesAtended;

                    listOfStudents.Add(student);
                }

                //datesAtended.Clear();
                input = Console.ReadLine();
            }

            var inputComments = Console.ReadLine().Split('-');

            while (inputComments[0] != "end of comments")
            {
                var name = inputComments[0];
                var comments = new List<string>();

                for (int i = 1; i < inputComments.Length; i++)
                {
                    comments.Add(inputComments[i]);
                }
                if (listOfStudents.Any(x => x.Name == name))
                {
                    foreach (var student in listOfStudents)
                    {
                        if (student.Name == name && student.Comments != null)
                        {
                            student.Comments.AddRange(comments);
                            break;
                        }
                        if (student.Name == name && student.Comments == null)
                        {
                            student.Comments = comments;
                            break;
                        }
                    }
                }
                //else
                //{
                //    var student = new Student();
                //    student.Name = name;
                //    student.Comments = comments;
                //    listOfStudents.Add(student);
                //}
                //comments.Clear();
                inputComments = Console.ReadLine().Split('-');
            }

            foreach (var studen in listOfStudents.OrderBy(x => x.Name))
            {
                    Console.WriteLine($"{studen.Name}");
                    Console.WriteLine("Comments:");
                    if (studen.Comments != null)
                    {
                        foreach (var comment in studen.Comments)
                        {
                            Console.Write("- ");
                            Console.WriteLine($"{comment}");
                        }
                    }
                    Console.WriteLine("Dates attended:");
                    foreach (var date  in studen.Attendency.OrderBy(x => x.Date))
                    {
                        Console.Write("-- ");
                        Console.WriteLine($"{date:dd/MM/yyyy}");
                    }              
            }
        }
    }
}
