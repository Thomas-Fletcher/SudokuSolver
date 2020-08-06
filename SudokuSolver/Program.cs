using System;

namespace SudokuSolver
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int[][] table = Solver.LoadTable();

                if (Solver.Solve(table))
                {
                    Console.WriteLine("Sudoku Successfully Solved:");
                    Solver.PrintTable(table);
                }    
                else
                    Console.WriteLine("Could not solve this sudoku.");

                Console.Write("Would you like to try and solve another Sudoku (y/n)? ");
                if(Console.ReadLine().ToLower() == "n")
                    break;
            }
        }
    }
}
