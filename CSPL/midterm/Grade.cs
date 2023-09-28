namespace StudentLibrary
{
    using System.Linq;
    using System.Collections.Generic;

    public class Grade
    {
        public string Period { get; set; }
        public double Score { get; set; }
        public Grade(string period, double score)
        {
            Period = period;
            Score = Math.Floor(score);
        }
    }

    public class StatisticsCalculator 
    {
        public List<double> FilteredNums { get; set; }
        private int elementsCount { get; set; }

        public StatisticsCalculator(List<Grade> scores)
        {
            FilteredNums = scores.Select(s => s.Score).ToList(); 
            elementsCount = scores.Count();
        }

        public double Mean()
        {
            double sum = 0.00;
            foreach (var grd in FilteredNums)
            {
              sum += grd; 
            }
            return (double) (sum / elementsCount);
         // return (double) FilteredNums.Average(gd => gd.Score);
        } 

        public double Median()
        {
            var sortedNums = FilteredNums.OrderBy(s => s).ToList();
             return  elementsCount % 2 == 1 
                     ? (double) sortedNums.ElementAt(elementsCount / 2) 
                     : (double) ( sortedNums.ElementAt(elementsCount / 2) + sortedNums.ElementAt((elementsCount - 1) / 2) ) / 2;

        }

        public double Range()
        {
            var sortedNums = FilteredNums.OrderBy(x => x).ToList();
            return sortedNums.Last() - sortedNums.First();
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
    }

}
