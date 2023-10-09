namespace Cspl.Math.Trigonometry
{
    public static class Sine
    {
        const double radians = Math.PI / 180;         

        public static double Opposite(double hypotenuse, double angle)
        {
            return hypotenuse * Math.Sin(radians * angle);
        }

        public static double Hypotenuse(double opposite, double angle)
        {
            return opposite / Math.Sin(radians * angle);
        }
    }
    
    public static class Arcsine
    {
        public static double Radiance(double oppposite, double hypotenuse)
        {

        }

    }
}

