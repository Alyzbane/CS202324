namespace Csspl.Utils.IO
{
    using System;
    public static class InputHandler
    {
        /*public static bool IsValidNumStatistic(object obj)
        {
            var _type = obj.GetType();
            if (_type == typeof(float) || _type ==  typeof(double)) return true;
            else return false;
        } */

        public static bool validChoice(int inp)
        {
            if(inp >= 0 && inp <= 11)
            {
                return true;
            }
            else 
            {
                Console.WriteLine("Invalid number...");
                return false;
            }
        }

        public static int Number(string guide)
        {
            Console.Write($"{guide}");
            string? readInput = Console.ReadLine();

            if(String.IsNullOrEmpty(readInput)) return -1;
            if (char.IsDigit(readInput[0]) && int.TryParse(readInput, out int num) == true)
                if(validChoice(num)) return num;

            Console.WriteLine($"Invalid input: {readInput}");
            return -1;
        }

        public static T GetInput<T>(string prompt)
        {
            Console.Write(prompt);
            string? input = Console.ReadLine();

            try
            {
                return (T)Convert.ChangeType(input, typeof(T));
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input. Please try again.");
                ContinueKey();
                return GetInput<T>(prompt);
            }
        }

        public static void ContinueKey()
        {
            Console.Write("\nPress enter to continue...");
            while (Console.ReadKey(true).Key != ConsoleKey.Enter)
            {
                Console.WriteLine("\nPress enter to continue...");
            }
            Console.Clear();
        }

        public static bool YesNoOption(string guide)
        {

            bool state = true;
            Console.Write($"{guide}");
            ConsoleKeyInfo ckey = Console.ReadKey(false);
            Console.WriteLine();

            if(ckey.Key == ConsoleKey.D1)   state = true; // yes 
            else if(ckey.Key == ConsoleKey.D0)  state = false; // no 

            //Console.WriteLine($"Key pressed, {ckey.KeyChar}");
            return state;
        }

    } /* class InputHandler */
} /* namespace Csspl.Utils.IO */
