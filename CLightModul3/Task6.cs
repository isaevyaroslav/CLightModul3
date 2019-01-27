using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLightModul3
{
    class Task6
    {
        /*
         6 Split (3 балла)
            Получить строку от пользователя, разбить её с помощью метода Split на массив по сепаратору
            пробел, и потом вывести каждый элемент массива.
         */

        private static void Main(string[] args)
        {
            string userText = "";
            string[] userWords = new string[0];
            while(userWords.Length <= 1)
            {
                Console.WriteLine("Введите предложение: ");
                userText = Console.ReadLine();
                userWords = userText.Split(' ');
                if(userWords.Length > 1)
                {
                    Console.WriteLine("Все слова из Вашего предложения: ");
                    for (int wordNumber = 0; wordNumber < userWords.Length; wordNumber++)
                    {
                        Console.WriteLine(userWords[wordNumber]);
                    }
                    Console.WriteLine("\nСпасибо.\n");
                }
                else
                {
                    Console.WriteLine("Вы не ввели предложение.");
                    continue;
                }
            }
            
        }
    }
}
