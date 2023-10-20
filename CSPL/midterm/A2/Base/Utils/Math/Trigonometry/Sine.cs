namespace Csspl.Utils.Math.Trigonometry
{
    using System;

    public static class Sine
    {

        public static double Opposite(double hypotenuse, double angle)
        {
            return hypotenuse * Math.Sin(Constants.Radian * angle);
        }

        public static double Hypotenuse(double opposite, double angle)
        {
            return opposite / Math.Sin(Constants.Radian * angle);
        }

        public static double Angle(double opposite, double hypotenuse)
        {
            return Math.Asin(opposite / hypotenuse) * Constants.Degree;
        }

    } /* class Sine */

} /* namespace Csspl.Utils.Math.Trigonometry */

