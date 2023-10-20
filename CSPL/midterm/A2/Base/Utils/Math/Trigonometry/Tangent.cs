namespace Csspl.Utils.Math.Trigonometry
{
    using System;

    public static class Tangent
    {
        public static double Opposite(double adjacent, double angle)
        {
            return adjacent * Math.Tan(Constants.Radian * angle);
        }

        public static double Adjacent(double hypotenuse, double angle)
        {
            return hypotenuse / Math.Tan(Constants.Radian * angle);
        }

        public static double Angle(double opposite, double adjacent)
        {
            return Math.Atan(opposite / adjacent) * Constants.Degree;
        }

    } /* class Tangent */

} /* namespace Csspl.Utils.Math.Trigonometry */
