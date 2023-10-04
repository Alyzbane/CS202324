namespace IOHandler
{
    using Menu;
    public class InputParser
    {
        public InputParser() { }

        public bool validChoice(int inp)
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
            string? readInput; 
            readInput = Console.ReadLine();
            int num;

            if(readInput.Length < 1) return -1;

            if (char.IsDigit(readInput[0]) && int.TryParse(readInput, out num) == true)
                if(validChoice(num)) return num;

            Console.WriteLine($"Invalid input: {readInput}");
            return -999;
        }

        public void ReadKey()
        {
            Console.Write("\nPress enter to continue...");
            while (Console.ReadKey(true).Key != ConsoleKey.Enter)
            {
                Console.WriteLine("\nPress enter to continue...\n");
            }
            for (int i = 0; i < 50; i++) Console.WriteLine();
        }

        public bool YesNoOption(string guide)
        {

            UtilityMenu uMenu = new UtilityMenu();
            bool state = true;
            uMenu.YesNoView();
            Console.Write($"{guide}");
            ConsoleKeyInfo ckey = Console.ReadKey(false);
            Console.WriteLine();
            if (ckey.Key == ConsoleKey.D1)        state = false; // yes 
            else if (ckey.Key == ConsoleKey.D0)   state = true; // no 
            //Console.WriteLine($"Key pressed, {ckey.KeyChar}");

            return state;
        }
    }

}// end of IOHAndler 
