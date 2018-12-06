using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade

{
    public class GradeStatistics
    {
        public GradeStatistics()
        {
            HighestGrades = 0;
            LowestGrades = float.MaxValue;
        }

        public float AverageGardes;
        public float HighestGrades;
        public float LowestGrades;
    }
}
