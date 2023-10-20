namespace Csspl.Process.Trigonometry
{
    using Csspl.Utils.Math.Trigonometry;
    using Csspl.Utils.IO;
    using Csspl.View.Trigonometry.Main;

    public class Process
    {
        public double Result {get; private set;}
        private double _pOne {get; set;}
        private double _pTwo {get; set;}

        public Process() 
        {
            Result = Double.NaN;
            _pOne = Double.NaN;
            _pTwo = Double.NaN;
        }


        /* ===================================== Calculator Functions ========================================== */

        public void ComputeOppositeUsingSine()
        {
            _pOne = InputHandler.GetInput<double>("\t\t\t\tEnter Hypotenuse:\n\t\t\t\t> ");
            _pTwo = InputHandler.GetInput<double>("\t\t\t\tEnter Angle:\n\t\t\t\t> ");
            Result = Sine.Opposite(_pOne, _pTwo);
        }

        public void ComputeOppositeUsingTan()
        {
            _pOne = InputHandler.GetInput<double>("\t\t\t\tEnter Adjacent:\n\t\t\t\t> ");
            _pTwo = InputHandler.GetInput<double>("\t\t\t\tEnter Angle:\n\t\t\t\t> ");
            Result = Tangent.Opposite(_pOne, _pTwo);
        }

        public void ComputeHypotenuseUsingSine()
        {
            _pOne = InputHandler.GetInput<double>("\t\t\t\tEnter Opposite:\n\t\t\t\t> ");
            _pTwo = InputHandler.GetInput<double>("\t\t\t\tEnter Angle:\n\t\t\t\t> ");
            Result = Sine.Hypotenuse(_pOne, _pTwo);
        }

        public void ComputeHypotenuseUsingCosine()
        {
            _pOne = InputHandler.GetInput<double>("\t\t\t\tEnter Adjacent:\n\t\t\t\t> ");
            _pTwo = InputHandler.GetInput<double>("\t\t\t\tEnter Angle:\n\t\t\t\t> ");
            Result = Cosine.Hypotenuse(_pOne, _pTwo);
        }

        public void ComputeAdjacentUsingCosine()
        {
            _pOne = InputHandler.GetInput<double>("\t\t\t\tEnter Hypotenuse:\n\t\t\t\t> ");
            _pTwo = InputHandler.GetInput<double>("\t\t\t\tEnter Angle:\n\t\t\t\t> ");
            Result = Cosine.Adjacent(_pOne, _pTwo);
        }

        public void ComputeAdjacentUsingTan()
        {
            _pOne = InputHandler.GetInput<double>("\t\t\t\tEnter Hypotenuse:\n\t\t\t\t> ");
            _pTwo = InputHandler.GetInput<double>("\t\t\t\tEnter Angle:\n\t\t\t\t> ");
            Result = Tangent.Adjacent(_pOne, _pTwo);
        }

        public void ComputeAngleUsingSine()
        {
            _pOne = InputHandler.GetInput<double>("\t\t\t\tEnter Opposite:\n\t\t\t\t> ");
            _pTwo = InputHandler.GetInput<double>("\t\t\t\tEnter Hypotenuse:\n\t\t\t\t> ");
            Result = Sine.Angle(_pOne, _pTwo);
        }

        public void ComputeAngleUsingCosine()
        {
            _pOne = InputHandler.GetInput<double>("\t\t\t\tEnter Adjacent:\n\t\t\t\t> ");
            _pTwo = InputHandler.GetInput<double>("\t\t\t\tEnter Hypotenuse:\n\t\t\t\t> ");
            Result = Cosine.Angle(_pOne, _pTwo);
        }

        public void ComputeAngleUsingTan()
        {
            _pOne = InputHandler.GetInput<double>("\t\t\t\tEnter Opposite:\n\t\t\t\t> ");
            _pTwo = InputHandler.GetInput<double>("\t\t\t\tEnter Adjacent:\n\t\t\t\t> ");
            Result = Tangent.Angle(_pOne, _pTwo);
        }

        public void ComputeSidesOnRadian()
        {
            _pOne = InputHandler.GetInput<double>("\t\t\t\tEnter Opposite:\n\t\t\t\t> ");
            _pTwo = InputHandler.GetInput<double>("\t\t\t\tEnter Adjacent:\n\t\t\t\t> ");
            Result = Radiance.SidesToRadian(_pOne, _pTwo);
        }

        public void ComputeRadianOnAngle()
        {
            _pOne = InputHandler.GetInput<double>("\t\t\t\tEnter Angle:\n\t\t\t\t> ");
            Result = Radiance.AngleToRadian(_pOne);
        }
        /* ===================================== Calculator Functions ========================================== */

    } /* class Process */
} /* namespace Csspl.Process.Trigonometry */
