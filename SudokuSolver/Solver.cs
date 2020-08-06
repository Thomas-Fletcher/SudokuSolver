using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace SudokuSolver
{
    public class Solver
    {
        public static int[][] LoadTable()
        {
            // Load up a table
            int[][] table = new int[9][];

            Console.WriteLine("Hello Jedi Council");
            Console.WriteLine("Please enter your sudoku table:");
            Console.WriteLine("Use any single character to represent a empty cell (excluding 1-9)");

            for (int i = 0; i < 9; i++)
            {
                table[i] = new int[9];
                string line = Console.ReadLine();
                line = Regex.Replace(line.PadRight(9).Substring(0, 9), "[^0-9]", "0");
                char[] lineArr = line.ToCharArray();
                for (int j = 0; j < 9; j++)
                    table[i][j] = lineArr[j] - '0';
            }

            return table;
        }

        public static void PrintTable(int[][] table)
        {
            // print table out
            Console.WriteLine();
            for (int i = 0; i < 9; i++)
                Console.WriteLine("{0}", string.Join(null, table[i]));
        }

        public static int[] GetOptions(int[][] table, int row, int col)
        {
            // get options available for a given cell

            var options = new List<int>();

            for (int c = 1; c <= 9; c++)
            {
                bool match = false;

                for (int i = 0; i < 9; i++)
                {
                    if (table[row][i] == c ||
                        table[i][col] == c ||
                        table[(row - row % 3) + i % 3][(col - col % 3) + i % 3] == c)
                    {
                        match = true;
                        break;
                    }
                }

                if (!match)
                    options.Add(c);
            }

            return options.ToArray();
        }

        public static bool Solve(int[][] table)
        {
            // Recursive function.
            // look for cell with least amount of options. 
            // Try option and move onto next cell. 
            // If no empty cells exist -> solved.
            // If no options exists -> fail -> use next closest option prior.

            bool solved = false;

            int row = -1;
            int col = -1;
            int[] options = null;

            // find a empty cell with the lowest options
            for (int i = 0; i < 9; i++)
                for (int j = 0; j < 9; j++)
                    if (table[i][j] == 0)
                    {
                        int[] newOptions = GetOptions(table, i, j);
                        if (row < 0 || newOptions.Length < options.Length)
                        {
                            row = i;
                            col = j;
                            options = newOptions;
                        }
                    }

            // if no empty cells found -> 'row' cannot be larger than zero -> Solved.
            if (row < 0)
            {
                solved = true;
            }
            else
            {
                // loop through cell's options
                // Check if another cell can be solved by calling Solve().
                
                for (int i = 0; i < options.Length; i++)
                {
                    table[row][col] = options[i];
                    if (Solve(table))
                    {
                        solved = true;
                        break;
                    }
                    table[row][col] = 0;
                }
                
            }

            return solved;
        }
    }
}
