using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLightModul3
{
    class Task7
    {
        /*
         7 Расширение массива (9 баллов)
            Пользователь вводит числа, и программа их запоминает. Как только пользователь введёт
            команду sum, программа выведет сумму всех веденных чисел. Программа должна работать на
            основе расширения массива. Внимание, нельзя использовать List<T> и Array.Resize
            Дополнительные 5 баллов:
            Сделать команду sort которая выведет все числа в порядке убывания
         */

        private static void Main(string[] args)
        {
            float[] userValues = new float[1];
            string greeting = "Здравствуйте.";
            string task = 
                "\nВведите пожалуйста число, \n" +
                "команду \"sum\", чтобы увидеть сумму всех введённых чисел\n" +
                "команду \"sort\", чтобы увидеть все введённые Вами числа в порядке убывания\n" +
                "или команду \"exit:\", чтобы выйти из программы: ";
            string rezult = "\nВаше значение {0} записано.";
            string sumRezult = "\nСумма Ваших чисел составляет: ";
            string bye = "Пока";

            bool exit = false;
            string userCommand = "";
            float nextValue = 0;
            float sum = 0;

            Console.WriteLine(greeting);
            while(!exit)
            {
                Console.Write(task);
                userCommand = Console.ReadLine();
                switch (userCommand)
                {
                    case "sum":
                        sum = 0;
                        for (int valueNumber = 0; valueNumber < userValues.Length; valueNumber++)
                        {
                            sum += userValues[valueNumber];
                        }
                        Console.WriteLine(sumRezult+sum);
                        break;
                    case "sort":

                        float temp;
                        for (int i = 0; i < userValues.Length; i++)
                        {
                            for (int j = i + 1; j < userValues.Length; j++)
                            {
                                if (userValues[i] < userValues[j])
                                {
                                    temp = userValues[i];
                                    userValues[i] = userValues[j];
                                    userValues[j] = temp;
                                }
                            }
                        }
                        for (int valueNumber = 0; valueNumber < userValues.Length; valueNumber++)
                        {
                            Console.Write(userValues[valueNumber]+"\t");
                        }
                        Console.WriteLine();
                        break;
                    case "exit":
                        exit = true;
                        Console.WriteLine(bye);
                        continue;
                    default:
                        nextValue = Convert.ToSingle(userCommand);
                        float[] extUserValues = new float[userValues.Length+1];
                        for (int valueNumber = 0; valueNumber < userValues.Length; valueNumber++)
                        {
                            extUserValues[valueNumber] = userValues[valueNumber];
                        }
                        extUserValues[extUserValues.Length - 1] = nextValue;
                        userValues = extUserValues;
                        Console.WriteLine(rezult, nextValue);
                        break;
                }
            }
        }
    }
}
