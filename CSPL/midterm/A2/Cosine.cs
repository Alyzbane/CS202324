namespace Cspl.Math.Trigonometry
{

    public static class Cosine
    {
        const double  radians = Math.Pi / 180

        public static double Adjacent(double hypotenuse, double angle)
        {
            return hypotenuse * Math.Cos(radians * angle);
        }

        public static double Hypotenuse(double adjacent, double angle)
        {
            return adjacent * Math.Cos(radians * angle);
        }

        public static double Angle(double adjacent, double hypotenuse)
        {
            return Math.Pow(radians, -1) * Math.Acos(adjacent / hypotenuse);
        }
    } /*  Cosine class */

} /* Cspl.Math.Trigonometry */
