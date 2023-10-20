namespace Csspl.Utils.Math.Trigonometry
{

    public static class  Radiance
    {

        public static double SidesToRadian(double opposite, double hypotenuse)
        {
            return Sine.Angle(opposite,hypotenuse) * Constants.Radian;
        }
        public static double AngleToRadian(double angle)
        {
            return angle * Constants.Radian;
        }

    } /* class Radiance */

} /* namespace Csspl.Utils.Math.Trigonometry */
