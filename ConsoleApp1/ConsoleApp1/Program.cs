using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade
{
    class Program
    {
        static void Main(string[] args)
        {
            
            GradeBook book = new GradeBook();
            book.AddGrade(23);
            book.AddGrade(87.3f);
            book.AddGrade(55);
            book.AddGrade(99);

            GradeStatistics stats = book.ComputeStatistics();

            WriteResult("Average Grade", (int)stats.AverageGardes);
            WriteResult("Highest Grade", stats.HighestGrades);
            WriteResult("Lowest Garde", stats.LowestGrades);
            

        }

        static void WriteResult(string description, int result)
        {
            Console.WriteLine(description + ":" + result);
        }

        static void WriteResult(string description, float result)
        {
            Console.WriteLine(description + ":" + result);
        }
    }
}
