using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLightModul3
{
    class Task4
    {
        private static void Main(string[] args)
        {
            /*
             4 Наибольший элемент. (8 балов)
                Найти наибольший элемент матрицы A(10,10) и записать ноль в ту ячейку, где он находится.
                Вывести наибольший элемент, исходную и полученную матрицу.
             */
            int[,] matrix = new int[10, 10];
            int[] maxIntRowCol = { 0, 0 };

            Random random = new Random();

            // Инициализируем данный массив
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = random.Next(1, 15);
                    Console.Write("{0}\t", matrix[row, col]);
                    if (matrix[row, col] >= matrix[maxIntRowCol[0], maxIntRowCol[1]])
                    {
                        maxIntRowCol[0] = row;
                        maxIntRowCol[1] = col;
                    }
                }
                Console.WriteLine("");
            }
            Console.WriteLine("Максимальное число в матрице: "+matrix[maxIntRowCol[0], maxIntRowCol[1]]);
            Console.WriteLine("Заменим его на ноль: ");
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if(matrix[row, col] == matrix[maxIntRowCol[0], maxIntRowCol[1]])
                    {
                        matrix[row, col] = 0;
                    }
                    Console.Write("{0}\t", matrix[row, col]);
                }
                Console.WriteLine("");
            }

        }
    }
}
