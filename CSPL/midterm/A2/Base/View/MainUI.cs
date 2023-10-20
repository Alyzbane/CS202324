namespace Csspl.View.Trigonometry.Main
{
   using System;
   public static class MainUI
   {

      public static void YesNoView(string guide)
      {
         Console.Clear();
         Console.WriteLine($"\n\n\n\t\t\t\t{guide}\n"
                         + "\t\t\t\t[1] --- Yes\n"
                         + "\t\t\t\t[0] --- No");

      }
      public static void StartView()
      {
         Console.Clear();
         Console.WriteLine("\n\n\n\t\t\t\t[ Main Menu ]\n"
                         + "\t\t\t\tTrigonometry Calculator\n"
                         + "\t\t\t\t[1] --- Start\n"
                         + "\t\t\t\t[2] --- Exit");
      }


      public static void CalculationView()
      {
         Console.Clear();
         Console.WriteLine("\n\n\n\t\t\t\t[ Calculation Menu ]\n"
                         + "\t\t\t\t[1]  --- Computes the opposite side using Sine\n"
                         + "\t\t\t\t[2]  --- Computes the opposite side using Tan\n"
                         + "\t\t\t\t[3]  --- Computes Hypotenuse using Sine\n"
                         + "\t\t\t\t[4]  --- Computes Hypotenuse using Cosine\n"
                         + "\t\t\t\t[5]  --- Computes adjacent side using Cosine\n"
                         + "\t\t\t\t[6]  --- Computes adjacent side using Tan\n"
                         + "\t\t\t\t[7]  --- Compute the angle using Sine\n"
                         + "\t\t\t\t[8]  --- Compute the angle using Cosine\n"
                         + "\t\t\t\t[9]  --- Compute the angle using Tan\n"
                         + "\t\t\t\t[10] --- Compute the radiance based on opposite side and hypotenuse\n"
                         + "\t\t\t\t[11] --- Compute the radiance based on angle\n"
                         + "\t\t\t\t[0]  --- Return\n");
      }

      public static void ResultView(double value)
      {
         Console.WriteLine("\n\n\t\t\t\t[ Result ]\n"
                         + $"\t\t\t\t>{value}\n");
      }

   } /* class MainView */
} /* namespace Csspl.View.UI */
