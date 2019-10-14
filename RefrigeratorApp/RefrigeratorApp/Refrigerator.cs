using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefrigeratorApp
{
    class Refrigerator
    {
        public double MaximumWeight { get; set; }
        public List<double> TotalWeights { get; set; }

        public Refrigerator()
        {
            TotalWeights = new List<double>();
        }

        public double GetCurrentWeight(double totalWeight)
        {
            TotalWeights.Add(totalWeight);
            return TotalWeights.Sum();
        }

        public double GetRemainingWeight()
        {
           return MaximumWeight - TotalWeights.Sum();
        }
    }
}
