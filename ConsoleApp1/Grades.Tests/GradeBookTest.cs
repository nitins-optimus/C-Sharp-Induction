using Grade;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Tests
{
    [TestClass]
    class GradeBookTest
    {
        [TestMethod]
        public void ComputeHighestGrades()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(10);
            book.AddGrade(70);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(70, result.HighestGrades);
        }

        [TestMethod]
        public void ComputeLowestGrades()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(89);
            book.AddGrade(6);
            book.AddGrade(3);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(3, result.LowestGrades);
        }

        [TestMethod]
        public void ComputeAverageGrades()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(79);
            book.AddGrade(2);
            book.AddGrade(10);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(8.16, result.AverageGardes, 0.01);
        }   
    }
}
