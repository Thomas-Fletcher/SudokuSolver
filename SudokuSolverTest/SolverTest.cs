using System;
using SudokuSolver;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SudokuSolverTest
{
    [TestClass]
    public class SolverTest
    {
        [TestMethod]
        public void GetOptionsTest()
        {
            int[][] table = Solver.LoadTable();
            int row = 0;
            int col = 0;

            int[] testInstance = Solver.GetOptions(table, row, col);

            Assert.AreEqual(testInstance.Length, 4);
            Assert.AreEqual(testInstance[0], 2);
            Assert.AreEqual(testInstance[1], 3);
            Assert.AreEqual(testInstance[2], 5);
            Assert.AreEqual(testInstance[3], 8);
        }
    }
}
