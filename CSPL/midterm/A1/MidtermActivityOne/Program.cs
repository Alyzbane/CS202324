namespace CSPL.Midterm.ActivityOne
{
    using System;
    using StudentLibrary;
    using Menu;

    public class Program
    {
        static List<StudentModel> students = new List<StudentModel>();
        public static void Main()
        {
           LoadData();
           MainMenu menus = new MainMenu();
           StudentController studentViewer = new StudentController(students); 
           IOHandler.InputParser iParser = new IOHandler.InputParser();

           for(int i = 0; i < 100; i++) Console.WriteLine();
           Console.WriteLine("Student Period Grades Summary System");
           iParser.ReadKey();

           bool state = true;
           while(state) 
           {
             menus.DisplayMain();
             int cmd = iParser.Number("> ");
             switch(cmd)
             {
                case 1:
                    DisplayGrades(studentViewer);
                    break;
                case 0:
                    state = iParser.YesNoOption("> ");
                    if(state == false) return;
                    break;
                default:
                    break;
             }
             iParser.ReadKey();
           }
        } // end of Main


        // ******** Start of Initializing the StudentModel Data ********

        public static void DisplayGrades(StudentController studentResults)
        {
            //menus.DisplayGrades()
            string prelimResult = studentResults.GetPeriodResult(1);
            string midtermResult = studentResults.GetPeriodResult(2);
            string finalResult = studentResults.GetPeriodResult(3);

            Console.WriteLine
            (
                "---------------------------------\n" +
                "| Name  \t| Average\t|" 
            );
            foreach(var s in students)
                Console.WriteLine($"| {s.Name}\t| {s.FinalAverage()}\t\t|");

            Console.WriteLine("---------------------------------\n");

            Console.WriteLine
            (
                "**************************************\n" +
                $"\nPrelim Result:\n{prelimResult}  \n" +
                "\n**************************************\n" +
                $"\nMidterm Result:\n{midtermResult}\n" +
                "\n**************************************\n" +
                $"\nFinal Result:\n{finalResult}    \n" +
                "********************************\n"
            );
        }
        public static void LoadData()
        {
            StudentModel studentA = new StudentModel("Student A");
            studentA.Grades.Add(new GradeModel("Prelim", 78.88));
            studentA.Grades.Add(new GradeModel("Midterm", 85.00));
            studentA.Grades.Add(new GradeModel("Final", 100.00));
            students.Add(studentA);

            StudentModel studentB = new StudentModel("Student B");
            studentB.Grades.Add(new GradeModel("Prelim", 56.76));
            studentB.Grades.Add(new GradeModel("Midterm", 98.00));
            studentB.Grades.Add(new GradeModel("Final", 100.00));
            students.Add(studentB);

            StudentModel studentC = new StudentModel("Student C");
            studentC.Grades.Add(new GradeModel("Prelim", 98.00));
            studentC.Grades.Add(new GradeModel("Midterm", 87.92));
            studentC.Grades.Add(new GradeModel("Final", 99.00));
            students.Add(studentC);

            StudentModel studentD = new StudentModel("Student D");
            studentD.Grades.Add(new GradeModel("Prelim", 87.98));
            studentD.Grades.Add(new GradeModel("Midterm", 85.00));
            studentD.Grades.Add(new GradeModel("Final", 98.00));
            students.Add(studentD);

            StudentModel studentE = new StudentModel("Student E");
            studentE.Grades.Add(new GradeModel("Prelim", 89.00));
            studentE.Grades.Add(new GradeModel("Midterm", 90.15));
            studentE.Grades.Add(new GradeModel("Final", 97.00));
            students.Add(studentE);

            StudentModel studentF = new StudentModel("Student F");
            studentF.Grades.Add(new GradeModel("Prelim", 90.00));
            studentF.Grades.Add(new GradeModel("Midterm", 90.11));
            studentF.Grades.Add(new GradeModel("Final", 89.90));
            students.Add(studentF);

        }
        // ******** End of Initializing the StudentModel Data ********

    }
}
