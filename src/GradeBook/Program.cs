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

                try
                {
                    //TODO figure out how to use method overloading to handle letter grade input
                    /*var letterGrade = char.Parse(input);
                    book.AddGrade(letterGrade);*/
                    
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }

                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                // could use a finally to close a file etc after a try OR a catch block has run
                finally
                {
                    Console.WriteLine("**");
                }
                
            }






            var stats = book.GetStatistics();


            Console.WriteLine($"Average = {stats.Average:N1}");
            Console.WriteLine($"Highest grade = {stats.High:N1}");
            Console.WriteLine($"Lowest grade = {stats.Low:N1}");
            Console.WriteLine($"Average Letter grade = {stats.Letter}");
        }
    }
}
