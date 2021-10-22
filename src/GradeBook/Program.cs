using System;
using System.Collections.Generic;
// Add namespaces by clicking a classobject (eg List), pressing ctrl + . and selecting the namespace

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var book = new Book("Yr7 Science Grades");
            
            // .. Loop asking user for input
            while (true)
            {
                Console.WriteLine("Enter a grade or q to exit");
                var input = Console.ReadLine();

                if (input == "q")
                {
                    break;
                }

                var grade = double.Parse(input);
                book.AddGrade(grade);
            }
            
            

            
            
            
            var stats = book.GetStatistics();


            Console.WriteLine($"Average = {stats.Average:N1}");
            Console.WriteLine($"Highest grade = {stats.High:N1}");
            Console.WriteLine($"Lowest grade = {stats.Low:N1}");
            Console.WriteLine($"Average Letter grade = {stats.Letter}");
        }
    }
}
