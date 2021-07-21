using System;
using System.Linq;

using SudokuGame;

namespace SudokuSharp
{
    class Program
    {
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
