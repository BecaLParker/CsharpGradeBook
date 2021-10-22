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
            _name = name;
        }
        public void AddGrade(double grade)
        {
            if(grade <= 100 && grade >= 0) 
            {
                grades.Add(grade);
            } else {
                throw new ArgumentException($"Invalid {nameof(grade)}");
            }
        }

        public void AddGrade(char letter) 
        {
            switch (letter)
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

                switch(result.Average){
                    case var d when d >= 90.0:
                        result.Letter = 'A';
                        break;

                    case var d when d >= 80.0:
                        result.Letter = 'B';
                        break;

                    case var d when d >= 70.0:
                        result.Letter = 'C';
                        break;
                    
                    case var d when d >= 60.0:
                        result.Letter = 'D';
                        break;

                    default:
                        result.Letter = 'D';
                        break;
                }
                return result;
            } else {
                throw new ArgumentException($"No grades found");
            }
        }

        // fields (instance variables?)
        // make private so we can add logic validation in class methods to prevent out-of-scope grades (eg 101) being added via grades.Add
        private List<double> grades;
        
        //Access modifier
        public string Name
        {
            get => _name?.ToUpper();
            set => _name = value ?? _name;
        }
        
        // private field to store the underlying state of a property
        private string _name;
    }
}