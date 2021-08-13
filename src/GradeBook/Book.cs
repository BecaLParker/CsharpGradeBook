using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Book
    {
        //  Constructor method (~ Ruby def initialize)
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);

        }

        public void ShowStatistics()
        {
            var total = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;
            foreach (double number in grades)
            {
                highGrade = Math.Max(number, highGrade);
                lowGrade = Math.Min(number, lowGrade);
                total += number;
            }

            var average = total / grades.Count;

            Console.WriteLine($"Average = {average:N1}");
            Console.WriteLine($"Highest grade = {highGrade:N1}");
            Console.WriteLine($"Lowest grade = {lowGrade:N1}");
        }

        // fields (instance variables?)
        // make private so we can add logic validatation in class methods to prevent out-of-scope grades (eg 101) being added via grades.Add
        private List<double> grades;
        private string name;
    }
}