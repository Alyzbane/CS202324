using StudentModel;

namespace Calculator //Activity 2 Solution
{
    public class GradeCalculator
    {
        private const decimal PRELIM_WEIGHT = 0.2m;
        private const decimal MIDTERM_WEIGHT = 0.3m;
        private const decimal FINAL_WEIGHT = 0.5m;
        public decimal ComputeGrade(Grade grade, String period)
        {
            string periodID = period;
            if (periodID.Equals("Prelim")) 
            {
                return ((grade.quiz / 60) * 0.4m)
                    + ((grade.majorExam / 50) * 0.6m);
            }
            else if (periodID.Equals("Midterm")) 
            {
                return ( (grade.quiz / 60 ) * 0.2m) + ( (grade.recitation / 100) * 0.2m) +
                        ( (grade.majorExam / 50) * 0.3m) + ( (grade.project / 20) * 0.3m);
            }
            else if (periodID.Equals("Finals")) 
            {
                return (grade.project* 0.01m);
            }
            return decimal.MinValue;
        }

        public decimal OverallRating(decimal prelim, decimal midterm, decimal finals)
        {
            return ((prelim * PRELIM_WEIGHT) + (midterm * MIDTERM_WEIGHT) + (finals * FINAL_WEIGHT));
        }
    }
} // end of Calculator namespace && Activity 2 Solution﻿// See https://aka.ms/new-console-template for more information 
using StudentModel;
using StudentBuilder;
using Menu;
using IOHandler;
namespace CSPL101 // start of activity 3 solution
{

    public class MainSystem
    {
        static StudentCreator stCreate = new StudentCreator();
        static List<Student> students = stCreate.ActivityDemo();
        static TableView.GradeTable ratingView = new TableView.GradeTable();
        static InputParser utility = new InputParser();
        static MainMenu menus = new MainMenu();


        public static bool SearchStudent()
        {
            int SID = utility.Number("Search Student ID: S");

            if (SID < 0) return false;

            foreach (var values in students)
            {
                if (values.id.Equals(SID))
                {
                    Console.WriteLine("Student ID found");
                    utility.ReadKey();
                    GradesOptions(values);
                    return true; // sucessfull operation
                }
            }
            Console.WriteLine($"\nStudent ID {SID} not found");
            return false; // student id not found 
        }

        public static void GradesOptions(Student student)
        {

            while (true)
            {

                menus.DisplayGrades();
                int opt = utility.Number("Choose Options: ");
                if (utility.validNumber(opt) == false)
                {  
                    utility.ReadKey();
                    return;
                }

                switch (opt)
                {
                    case 1:
                        student.grades.DisplayPrelim();
                        break;
                    case 2:
                        student.grades.DisplayMidterm();
                        break;
                    case 3:
                        student.grades.DisplayFinals();
                        break;
                    case 4:
                        student.grades.DisplayAll();
                        break;
                    case 0:
                        if(utility.YesNoOption("Return to Main Menu?") == true)
                            return;
                        break;
                    default:
                        Console.WriteLine("Error...");
                        break;
                }
                utility.ReadKey();
            }
        }

        public static void Main()
        {
            bool exit = false;
            while (exit != true)
            {
                menus.DisplayMain();
                int cmd = utility.Number(" > ");
                if (utility.validNumber(cmd) == false)
                {
                    utility.ReadKey();
                    continue;
                }
                switch (cmd)
                {
                    case 1:
                        SearchStudent();
                        break;
                    case 2:
                        ratingView.OverallRatingSummary(students);
                        break;
                    case 0:
                        exit = utility.YesNoOption("Exit the program?");
                        break;
                    default:
                        Console.WriteLine("Unknown Error...");
                        break;
                }
                utility.ReadKey();
            }
        }

    }

} // end of CSPL101 naemspace && activiity 3 solution

namespace IOHandler
{
    public class InputParser
    {
        public InputParser() { }

        public bool validNumber(int inp)
        {
            if (inp is 0 or 1 or 2 or 3 or 4 or 5) 
            {
                return true;
            }
            else 
            {
                Console.WriteLine("Invalid number...");
                return false;
            }
        }
        public int Number(string guide)
        {
            Console.Write($"{guide}");
            string? readInput = null;
            readInput = Console.ReadLine();
            int num;
            if (int.TryParse(readInput, out num) == true)
                return num;

            Console.WriteLine($"Invalid input: {readInput}");
            return -999;
        }

        public void ReadKey()
        {
            Console.Write("\nPress enter to continue...");
            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
                Console.WriteLine("\nPress enter to continue...\n");
            }
            for (int i = 0; i < 50; i++) Console.WriteLine();
        }

        public bool YesNoOption(string guide)
        {

            Menu.UtilityMenu uMenu = new UtilityMenu();
            bool? state = null;
            while (state == null)
            {
                uMenu.YesNoView();
                Console.Write($"{guide}");
                ConsoleKeyInfo ckey = Console.ReadKey(false);
                Console.WriteLine();
                if (ckey.Key == ConsoleKey.D1)        state = true;
                else if (ckey.Key == ConsoleKey.D0)   state = false;
                //Console.WriteLine($"Key pressed, {ckey.KeyChar}");
            }

            return (bool)state;
        }
    }

}// end of IOHAndler namespace Menu
{
    public class MainMenu
    {
        public MainMenu() { }
        public void DisplayMain()
        {
            Console.WriteLine
            (
            "Main Menu\n" +
            "+-------------------------------+\n" +
            "| [1] - Search Student ID    \t|\n" +
            "| [2] - Overall Ratings      \t|\n" +
            "| [0] - Exit                 \t|\n" +
           "+-------------------------------+\n"
            );
        }
        public void DisplayGrades()
        {
            Console.WriteLine
           (
           "Grades\n" +
           "+-------------------------------+\n" +
           "| [1] - Prelim              \t|\n" +
           "| [2] - Midterm             \t|\n" +
           "| [3] - Finals              \t|\n" +
           "| [4] - All Grades          \t|\n" +
           "| [0] - Return              \t|\n" +
          "+-------------------------------+\n"
           );
        }


    }
    public class UtilityMenu
    {
        public void YesNoView()
        {
            Console.WriteLine
           (
           "Confirm\n" +
           "+-------------------------------+\n" +
           "| [1] - Yes                 \t|\n" +
           "| [0] - No                  \t|\n" +
          "+-------------------------------+\n"
           );
        }
    }
}// end of Menu namespaceusing StudentModel;
using TableView; // in-use(class): GradeTable


namespace StudentModel //start of studentmodel namespace && acitivty 3 core
{
    public class Student
    {
        public int id { get; set; }
        public string fName { get; set; }
        public string lName { get; set; }
        public String mName { get; set; }
        public string course { get; set; }
        public GradeTable grades { get; set; }
        public Student(GradeTable _grades)
        {
            id = 0;
            fName = "";
            lName = "";
            mName = "";
            course = "";
            grades = _grades;
        }
        public Student()
        {
            id = 0;
            fName = "";
            lName = "";
            mName = "";
            course = "";
            grades = new GradeTable();
        }
        public void DisplayInfo()
        {
            Console.WriteLine
                      (
                        $"\nStudent Identification: {id}" +
                        $"Name: {fName} {mName} {lName}\n" +
                        $"Course: {course}\n"
                      );
        }

    }
    public class Grade
    {
        public decimal majorExam { get; set; }
        public decimal quiz { get; set; }
        public decimal recitation { get; set; }
        public decimal project { get; set; }

        public Grade()
        {
            majorExam = decimal.Zero;
            quiz = decimal.Zero;
            recitation = decimal.Zero;
            project = decimal.Zero;
        }
    }
} //end of StudentModel namespace

namespace StudentBuilder //start of activity 3 solution
{
    public class StudentCreator
    {
        private const int SEM_PERIODS = 3;
        private int STARTING_SID = 202210133;

        public StudentCreator() // ctor
        { }

        public List<Student> ActivityDemo()
        {
            List<Grade> prelim;
            List<Grade> midterm;
            List<Grade> finals;
            List<GradeTable> tableGrade;


            prelim = new List<Grade>
                                    {
                                        new Grade {quiz = 45, majorExam = 30},
                                        new Grade {quiz = 30, majorExam = 30},
                                        new Grade {quiz = 60, majorExam = 30}
                                    };
            midterm = new List<Grade>
                                    {
                                        new Grade {quiz = 45, majorExam = 30, recitation = 90, project = 10},
                                        new Grade {quiz = 12, majorExam = 30, recitation = 75, project = 10},
                                        new Grade {quiz = 12, majorExam = 40, recitation = 75, project = 20},
                                    };
            finals = new List<Grade>
                                    {
                                        new Grade {project = 92},
                                        new Grade {project = 100},
                                        new Grade {project = 60}
                                    };

            tableGrade = new List<GradeTable>();
            for (int i = 0; i < SEM_PERIODS; i++)
            {
                tableGrade.Add(new GradeTable(prelim[i], midterm[i], finals[i]));
            }


            List<Student> studentsEntry = new List<Student>
                                    {
                                       new Student {fName = "Dean", mName= "A",  lName = "James"},
                                       new Student {fName = "Rein", mName = "A", lName = "Janella"},
                                       new Student {fName = "Grey", mName = "A", lName = "Sarah"}
                                    };
            for (int i = 0; i < 3; i++)
            {
                studentsEntry[i].course = "BSIT";
                studentsEntry[i].id = STARTING_SID;
                studentsEntry[i].grades = tableGrade[i];

                STARTING_SID += 1;
            }

            return studentsEntry;
        }
    }
} //end of StudentBuilder namespace && activity 3 solution
using Calculator; // in-use(class): GradeCalculator 
using StudentModel; // in-use(class): Grade 

namespace TableView
{
    public class GradeTable
    {
        public Grade prelim;
        public Grade midterm;
        public Grade finals;
        public decimal prelimRating { get; set; }
        public decimal midtermRating { get; set; }
        public decimal finalsRating { get; set; }
        public decimal overallRating { get; set; }
        public GradeCalculator gradeCalc;


        public GradeTable(Grade _prel, Grade _midt, Grade _fin)
        {
            prelim = _prel;
            midterm = _midt;
            finals = _fin;
            gradeCalc = new GradeCalculator();
            prelimRating = gradeCalc.ComputeGrade(prelim, "Prelim");
            midtermRating = gradeCalc.ComputeGrade(midterm, "Midterm");
            finalsRating = gradeCalc.ComputeGrade(finals, "Finals");
            overallRating = gradeCalc.OverallRating(prelimRating, midtermRating, finalsRating);
        }

        public GradeTable()
        {
            prelim = new Grade();
            midterm = new Grade();
            finals = new Grade();
            gradeCalc = new GradeCalculator();
            prelimRating = decimal.Zero;
            midtermRating = decimal.Zero;
            finalsRating = decimal.Zero;
            overallRating = decimal.Zero;
        }

        public void GradeLogs(Grade grade, decimal periodRating, string period)
        {
            if(grade != null)
            {
                Console.WriteLine($"\nGrading Period: {period}\n" +
                        "+--------------------------+\n" +
                        $"Quiz: {grade.quiz}\n" +
                        $"Major Exam: {grade.majorExam}\n" +
                        $"Recitation: {grade.recitation}\n" +
                        $"Project: {grade.project}\n" +
                        "+--------------------------+\n" +
                        $"Rating: {periodRating}\n");
            }
        }
        public void DisplayPrelim()
        {
            GradeLogs(prelim, prelimRating, "Prelim");
        }

        public void DisplayMidterm()
        {
            GradeLogs(midterm, midtermRating, "Midterm");
        }

        public void DisplayFinals()
        {
            GradeLogs(finals, finalsRating, "Finals");
        }

        public void DisplayAll()
        {
            DisplayPrelim();
            DisplayMidterm();
            DisplayFinals();
            Console.WriteLine($"Overall Rating: {overallRating}\n\n");
        }

        public void OverallRatingSummary(List<Student> students)
        {
            var filteredRating = students.Select(ort => new { ort.id, ort.grades.overallRating });
            Console.WriteLine($"Student ID  \t|\t Overall Rating");

            foreach (var value in filteredRating)
                Console.WriteLine($"S{value.id} \t|\t {value.overallRating}");
        }
    }
} //end of namespace tableview