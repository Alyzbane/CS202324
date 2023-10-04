namespace StudentLibrary
{
     using System.Linq;
     using System.Collections.Generic;

     public class StatisticsModel
     {
        public List<double> FilteredNums { get; set; }
        private int NumbersCount { get; set; }

        public StatisticsModel(List<GradeModel> scores)
        {
            FilteredNums = scores.Select(s => s.Score).ToList(); 
            FilteredNums.OrderBy(s => s).ToList();
            NumbersCount = scores.Count();
        }

        public double Mean()
        {
            return (double) FilteredNums.Average(gd => gd.Score);
        } 

        public double Median()
        {
            return  NumbersCount % 2 == 1 
                     ? (double) FilteredNums.ElementAt(NumbersCount / 2) 
                     : (double) ( FilteredNums.ElementAt(NumbersCount / 2) 
  		             + FilteredNums.ElementAt((NumbersCount - 1) / 2) ) / 2;

        }

        public double Range()
        {
            return FilteredNums.Last() - FilteredNums.First();
        }

        public double Variance()
            // can only return the variance population
        {
            double mean = Mean();
            var difference = FilteredNums.Select(x => x - mean).ToList();
            var squaredDiff = difference.Select(xsq => xsq * xsq).ToList();
            
            return squaredDiff.Average();
        }

        public double Stdev()
            // will return the standard deviation population
        {
            return Math.Sqrt(Variance());
        }

        public int Mode()
        {
            return FilteredNum.Select(sSelect(s
        }
     }
}
