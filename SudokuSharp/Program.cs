using System;
using System.Linq;

using SudokuGame;

namespace SudokuSharp
{
    class Program
    {
        static void testSudokuSolver()
        {
            var gridsEasy = Properties.Resources.GridEasy.Split('\n').ToArray();
            var gridsMedium = Properties.Resources.GridMedium.Split('\n').ToArray();
            var gridsHard = Properties.Resources.GridHard.Split('\n').ToArray();
            var gridsEvil = Properties.Resources.GridEvil.Split('\n').ToArray();

            var gridStr = gridsEvil[0];
            var gridEmpty = string.Join(" ", Enumerable.Repeat(0, 81));

            SudokuSolver sudokuSolver0 = new SudokuSolver(gridEmpty);
            sudokuSolver0.Execute(displaySolution: true);
            sudokuSolver0.Execute(displaySolution: true);
            sudokuSolver0.Execute(displaySolution: true);
            sudokuSolver0.Execute(displaySolution: true);

            SudokuSolver sudokuSolver1 = new SudokuSolver(gridStr);
            sudokuSolver1.Execute(displaySolution: true);
        }

        static void testSudokuGenerator()
        {
            SudokuGenerator sudokuGenerator0 = new SudokuGenerator(1, Level.All);
            sudokuGenerator0.Execute();

            SudokuGenerator sudokuGenerator1 = new SudokuGenerator(2);
            sudokuGenerator1.ExecuteAll();
        }

        static void testRuntime()
        {
            (string[] task, string[] solution) = SudokuGenerator.GenerateSudoku(Level.Evil);

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    var data = task[i * 9 + j];
                    Console.Write(data != "0" ? data : " ");
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(solution[i * 9 + j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            testRuntime();
            Console.ReadKey();
        }
    }
}
