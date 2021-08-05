using System;
using System.Collections.Generic;
// Add namespaces by clicking a classobject (eg List), pressing ctrl + . and selecting the namespace

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 12.7, 15.1, 10.2 };
            List<double> grades = new List<double>();

            var result = 0.0;
            foreach (double number in numbers)
            {
                result += number;
            }

            if (args.Length > 0)
            {
                Console.WriteLine($"Hello, {args[0]}!");
            }
            else
            {
                Console.WriteLine("Hello!");
            }
        }
    }
}
