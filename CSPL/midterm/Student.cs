namespace StudentLibrary
{
    using System.Collections.Generic;

    public class Student
    {
        public string Name { get; set; }
        public List<Grade> Grades { get; set; }

        public Student(string name)
        {
            Name = name;
            Grades = new List<Grade>();
        }

        public int FinalAverage()
        {
            return (int) Math.Ceiling(Grades.Average(x => x.Score));
        }
    }

}
