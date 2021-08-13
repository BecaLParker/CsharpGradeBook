using System.Collections.Generic;

namespace GradeBook
{
    class Book
    {
        //  Constructor method (~ Ruby def initialize)
        public Book()
        {
            grades = new List<double>();
        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);

        }

        // field (instance variable?)
        List<double> grades;


    }
}