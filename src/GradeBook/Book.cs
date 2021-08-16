using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        //  Constructor method (~ Ruby def initialize)
        public Book(string name)
        {
            grades = new List<double>();
            Name = name;
        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);

        }

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            var total = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;
            foreach (double grade in grades)
            {
                result.High = Math.Max(grade, result.High);
                result.Low = Math.Min(grade, result.Low);
                total += grade;
            }

            result.Average = total / grades.Count;

            return result;
        }

        // fields (instance variables?)
        // make private so we can add logic validatation in class methods to prevent out-of-scope grades (eg 101) being added via grades.Add
        private List<double> grades;
        public string Name;
    }
}