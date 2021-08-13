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

        // fields (instance variables?)
        // make private so we can add logic validatation in class methods to prevent out-of-scope grades (eg 101) being added via grades.Add
        private List<double> grades;
        private string name;


    }
}