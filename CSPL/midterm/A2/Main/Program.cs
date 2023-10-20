namespace Csspl.Program.Trigonometry
{
    using Csspl.Process.Trigonometry;
    using Csspl.App.Trigonometry;

    class Program
    {
        public static void Main()
        {
            Process proc = new Process();
            App app = new App(proc);

            while(app.Run());
        }

    } /* class Program */

} /*  Csspl.Program.Trigonometry */