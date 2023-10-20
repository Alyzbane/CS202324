namespace Csspl.Utils.Math.Trigonometry
{
    using System;

    public static class Cosine
    {

        public static double Adjacent(double hypotenuse, double angle)
        {
            return hypotenuse * Math.Cos(Constants.Radian * angle);
        }

        public static double Hypotenuse(double adjacent, double angle)
        {
            return adjacent / Math.Cos(Constants.Radian * angle);
        }

        public static double Angle(double adjacent, double hypotenuse)
        {
            return Math.Acos(adjacent / hypotenuse) * Constants.Degree;
        }

    } /*  Cosine class */

} /* Cspl.Math.Trigonometry */
