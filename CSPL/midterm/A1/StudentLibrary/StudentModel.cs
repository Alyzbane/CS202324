namespace StudentLibrary
{
    using System.Collections.Generic;

    public class StudentModel
    {
        public string Name { get; set; }
        public List<GradeModel> Grades { get; set; }

        public StudentModel(string name)
        {
            Name = name;
            Grades = new List<GradeModel>();
        }

        public int FinalAverage()
        {
            return (int) Math.Ceiling(Grades.Average(x => x.Score));
        }
    }

}
