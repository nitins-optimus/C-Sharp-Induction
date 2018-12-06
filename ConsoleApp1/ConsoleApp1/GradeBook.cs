using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade
{
    public class GradeBook
    {
        public GradeBook()
        {
            grades = new List<float>();
        }

        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();

            float sum = 0;

            foreach(float Grade in grades)
            {
                stats.HighestGrades = Math.Max(Grade, stats.HighestGrades);
                stats.LowestGrades = Math.Min(Grade, stats.LowestGrades);

                sum += Grade;
            }
            stats.AverageGardes = sum / grades.Count;

            return stats;
        }
        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }
        List<float> grades;
    }

}
