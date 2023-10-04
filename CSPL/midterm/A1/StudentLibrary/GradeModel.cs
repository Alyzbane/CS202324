namespace StudentLibrary
{
   public class GradeModel
    {
	// score is round down by default
	
        public string Period { get; set; }
        public double Score { get; set; }
        public GradeModel(string period, double score)
        {
            Period = period;
            Score = Math.Floor(score);
        }
    }
}
