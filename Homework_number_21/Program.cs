using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_number_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[,] matrix = new int[10, 10];
            int maxRandom = 100;
            int minRandom = 0;
            int maxNumberInMatrix = int.MinValue;
            int replacementNumber = 0;

            Console.WriteLine("Номинальная матрица");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(minRandom, maxRandom);

                    if (matrix[i, j] > maxNumberInMatrix)
                    {
                        maxNumberInMatrix = matrix[i, j];
                    }

                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Изменённая матрица");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == maxNumberInMatrix)
                    {
                        matrix[i, j] = replacementNumber;
                    }

                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"Максимальное число в матреце: {maxNumberInMatrix}");
            Console.ReadLine();
        }
    }
}
