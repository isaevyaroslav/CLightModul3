using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLightModul3
{
    class Task3
    {
        private static void Main(string[] args)
        {
            /*
             3 Матрица. (4 балла)
                Дана матрица A(3,3).
                Вычислить сумму второй строки и произведение первого столбца. Вывести исходную матрицу
                и результаты вычислений.
             */
            int[,] matrix = new int[3, 3];

            int sumSecondRow = 0;
            int multFirstCol = 1;

            Random random = new Random();

            // Инициализируем данный массив
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = random.Next(1, 15);
                    Console.Write("{0}\t", matrix[row, col]);
                    if(row == 1)
                    {
                        sumSecondRow += matrix[row, col];
                    }
                    if (col == 0)
                    {
                        multFirstCol *= matrix[row, col];
                    }
                }
                Console.WriteLine("");
            }
            Console.WriteLine("Сумма второй строки: " + sumSecondRow);
            Console.WriteLine("Произведение первого столбца строки: " + multFirstCol);
        }
    }
}
