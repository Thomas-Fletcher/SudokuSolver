using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SudokuSolver;

namespace SudokuSolverTest
{
    [TestClass]
    public class SolverTest
    {

        [TestMethod]
        public void GetOptionsTest01()
        {
            int[][] table = new int[][]
            {
                new int[] { 1, 2, 3, 0, 0, 0, 0, 0, 0 },
                new int[] { 7, 8, 9, 0, 0, 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 }
            };

            int[] testResult = new int[] { 4, 5, 6 };
            int[] optionResult = Solver.GetOptions(table, 1, 0);

            Assert.AreEqual(optionResult.Length, testResult.Length);
            Assert.AreEqual(optionResult[0], testResult[0]);
            Assert.AreEqual(optionResult[1], testResult[1]);
            Assert.AreEqual(optionResult[2], testResult[2]);
        }
        
        [TestMethod]
        public void GetOptionsTest02()
        {
            int[][] table = new int[][]
            {
                new int[] { 0, 0, 0, 1, 2, 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                new int[] { 7, 0, 0, 0, 0, 0, 0, 0, 0 },
                new int[] { 8, 0, 0, 0, 0, 0, 0, 0, 0 },
                new int[] { 9, 0, 0, 0, 0, 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 }
            };

            var testResult = new int[] { 3, 4, 5, 6 };
            int[] optionResult = Solver.GetOptions(table, 0, 0);

            Assert.AreEqual(optionResult.Length, testResult.Length);
            Assert.AreEqual(optionResult[0], testResult[0]);
            Assert.AreEqual(optionResult[1], testResult[1]);
            Assert.AreEqual(optionResult[2], testResult[2]);
            Assert.AreEqual(optionResult[3], testResult[3]);
        }
        
        [TestMethod]
        public void GetOptionsTest03()
        {
            int[][] table = new int[][]
            {
                new int[] { 1, 2, 3, 0, 0, 0, 0, 0, 0 },
                new int[] { 7, 8, 9, 0, 0, 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                new int[] { 5, 0, 0, 0, 0, 0, 0, 0, 0 },
                new int[] { 6, 0, 0, 0, 0, 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 }
            };

            var testResult = new int[] { 4 };

            int[] optionResult = Solver.GetOptions(table, 2, 0);

            Assert.AreEqual(optionResult.Length, testResult.Length);
            Assert.AreEqual(optionResult[0], testResult[0]);
        }

        [TestMethod]
        public void SolveTest01()
        {
            int[][] table = new int[][]
            {
                new int[] { 0, 0, 0, 1, 5, 4, 3, 9, 6 },
                new int[] { 0, 0, 0, 3, 2, 7, 1, 4, 8 },
                new int[] { 0, 0, 0, 6, 8, 9, 7, 5, 2 },
                new int[] { 5, 9, 3, 4, 6, 8, 2, 7, 1 },
                new int[] { 4, 7, 2, 5, 1, 3, 6, 8, 9 },
                new int[] { 6, 1, 8, 9, 7, 2, 4, 3, 5 },
                new int[] { 7, 8, 6, 2, 3, 5, 9, 1, 4 },
                new int[] { 1, 5, 4, 7, 9, 6, 8, 2, 3 },
                new int[] { 2, 3, 9, 8, 4, 1, 5, 6, 7 }
            };

            Assert.IsTrue(Solver.Solve(table));
        }

        [TestMethod]
        public void SolveTest02()
        {
            int[][] table = new int[][]
            {
                new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8 },
                new int[] { 9, 0, 0, 0, 0, 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 }
            };

            Assert.IsFalse(Solver.Solve(table));
        }


    }
}
