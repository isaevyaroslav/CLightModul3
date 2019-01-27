using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLightModul3
{
    class Task5
    {
        private static void Main(string[] args)
        {
            /*
             5 Дан массив целых чисел из 30 элементов. (8 баллов)
                Найдите все локальные максимумы. (Элемент является локальным максимумом, если он не
                имеет соседей, больших, чем он сам)
             */
            int[] array = new int[30];
            Random random = new Random();
            Console.Write("\nМассив из {0} целых чисел: ", array.Length);
            for (int itemNumber = 0; itemNumber < array.Length; itemNumber++)
            {
                array[itemNumber] = random.Next(1, 15);
                Console.Write(array[itemNumber] + "\t");
            }
            Console.Write("\nЛокальные максимумы: ");
            for (int itemNumber = 0; itemNumber < array.Length; itemNumber++)
            {
                if(itemNumber == 0)
                {
                    if(array[itemNumber] > array[itemNumber + 1])
                    {
                        Console.Write(array[itemNumber] + "\t");
                    }
                }
                else if (itemNumber == array.Length-1)
                {
                    if (array[itemNumber] > array[itemNumber - 1])
                    {
                        Console.Write(array[itemNumber] + "\t");
                    }
                }
                else 
                {
                    if (array[itemNumber - 1] < array[itemNumber] && array[itemNumber] > array[itemNumber + 1])
                    {
                        Console.Write(array[itemNumber] + "\t");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
