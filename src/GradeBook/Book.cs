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

        public void AddLetterGrade(char letter) 
        {
            switch(letter)
            {
                case 'A':
                    AddGrade(90);
                    break;

                case 'B':
                    AddGrade(80);
                    break;

                case 'C':
                    AddGrade(70);
                    break;

                default: 
                    AddGrade(0);
                    break;

            }

        }

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            var total = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            if (grades.Count > 0) 
            {
                // for(declare variable; execution condition; action to perform AFTER each iteration) {stuff to do during each iteration}
                for(var index = 0; index < grades.Count; index += 1)
                {
                    result.High = Math.Max(grades[index], result.High);
                    result.Low = Math.Min(grades[index], result.Low);
                    total += grades[index];
                } 

                result.Average = total / grades.Count;

                return result;
            } else {
                throw new ArgumentException($"No grades found");
            }
        }

        // fields (instance variables?)
        // make private so we can add logic validation in class methods to prevent out-of-scope grades (eg 101) being added via grades.Add
        private List<double> grades;
        public string Name;
    }
}