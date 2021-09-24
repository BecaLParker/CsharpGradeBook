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
            if(grade <= 100 && grade >= 0) 
            {
                grades.Add(grade);
            } else {
                throw new ArgumentException($"Invalid value");
            }

        }

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            var total = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            var index = 0;
            do
            {
                result.High = Math.Max(grades[index], result.High);
                result.Low = Math.Min(grades[index], result.Low);
                total += grades[index];
                index += 1;
            } while((index + 1 ) <= grades.Count);

            result.Average = total / grades.Count;

            return result;
        }

        // fields (instance variables?)
        // make private so we can add logic validation in class methods to prevent out-of-scope grades (eg 101) being added via grades.Add
        private List<double> grades;
        public string Name;
    }
}