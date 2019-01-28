using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLightModul3
{
    class Task1
    {
        static void Main(string[] args)
        {
            int[,] table = { { 2, 3, 3 }, { 3, 4, 5 } };
            int[,] order = { { 0, 1, 2 }, { 0, 0, 0 } };
            

            string greeting = 
                "Добро пожаловать в ресторан.\n " +
                "У нас Вы можете забронировать места зараннее.";
            string freePlaces = "У нас остались свободные места за следующими столами: ";
            string tableTask = "Введите номер стола за которым хотите сидеть: ";
            string placeTask = "Введите кличество мест, которое хотите занять: ";



            bool exit = false;

            string commandName = "";

            while (!exit)
            {
                Console.Clear();

                for (int i = 0; i < table.Length; i++)
                {
                    if (table[i,0] > 0) ;
                    Console.WriteLine("Стол №" + i + " - " + table[i,0] + ", занято "+ (table[i, 1]- table[i, 0]));
                }

                Console.Write("\nЗа каким столом вы хотите бронь?: ");
                int bron = Convert.ToInt32(Console.ReadLine());
                if (table[bron] == 0)
                {
                    Console.WriteLine("Мест нет(");
                    continue;
                }

                Console.Write("Сколько мест вам нужно?: ");
                int place = Convert.ToInt32(Console.ReadLine());

                if (table[bron] >= place && place > 0)
                {
                    table[bron] -= place;
                    Console.WriteLine(place + " места за " + bron + " столом зарезервированы.");
                }
                else { Console.WriteLine("Недостаточно мест."); }

                Console.ReadKey();
            }
        }
    }
}
