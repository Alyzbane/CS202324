namespace Menu
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
           "| [1] - Display Grades      \t|\n" +
           "| [0] - Exit                \t|\n" +
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
    } //end of MainMenu class

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
    }// end of UtilityMenu class

}// end of Menu namespace
