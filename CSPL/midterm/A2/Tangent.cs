namespace Cspl.Math.Trigonometry
{
    public static class Tan
    {
        const double radians = Math.PI / 180;

        public static double Opposite(double adjacent, double angle)
        {
            return adjacent * Math.Tan(radians * angle);
        }

        public static double Adjacent(double hypotenuse, double angle)
        {
            return hypotenuse / Math.Tan(radians * angle);
        }
    }

}
