namespace StudentLibrary
{
    using System.Collections.Generic;
    using System.Linq;

    public class StudentController
    {
		public List<StudentModel> Students {get; set;}
        StatisticsModel? StudentSolver; 

	   	public StudentController(List<StudentModel> students)
		{
			Students = students;
		}
        
        public List<GradeModel> GetPeriodData(int cmd)
        {
            switch(cmd)
            {
                case 1:
                 return   Students
                         .SelectMany(st => st.Grades)
                         .Where(sc => sc.Period == "Prelim").ToList();

                case 2:
                 return   Students
                         .SelectMany(st => st.Grades)
                         .Where(sc => sc.Period == "Midterm").ToList();

                case 3:
                  return  Students
                         .SelectMany(st => st.Grades)
                         .Where(sc => sc.Period == "Final").ToList();

                default:
                  throw new InvalidOperationException("Invalid Command");
            }
        }

         
       	public string GetPeriodResult(int period)
        {

            StudentSolver = new StatisticsModel(GetPeriodData(period));
    	    return ($"Mean: {StudentSolver.Mean()}\n" +
                             $"Median: {StudentSolver.Median()}\n" +
                             $"Range: {StudentSolver.Range()}\n" +
                             $"Variance: {StudentSolver.Variance()}\n" +
                             $"Standard Deviation: {StudentSolver.Stdev()}\n");
    	}

    }
}
