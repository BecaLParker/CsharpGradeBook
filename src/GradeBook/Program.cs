﻿using System;
using System.Collections.Generic;
// Add namespaces by clicking a classobject (eg List), pressing ctrl + . and selecting the namespace

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Yr7 Science Grades");
            book.AddGrade(89.1);

            var grades = new List<double>() { 12.7, 10.3, 6.11, 4.1 };
            grades.Add(56.1);

            var total = 0.0;
            var highGrade = double.MinValue;
            foreach (double number in grades)
            {
                if (number > highGrade)
                {
                    highGrade = number;
                }
                total += number;
            }

            var average = total / grades.Count;

            Console.WriteLine($"Average = {average:N1}");
            Console.WriteLine($"Highest grade = {highGrade:N1}");
        }
    }
}
