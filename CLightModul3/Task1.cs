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
            int[,] tables = { { 2, 3 }, { 3, 4 }, { 3, 5 } , { 4, 7 } , { 3, 6 } , { 3, 6 } };
            int[] order = new int[tables.GetLength(0)] ;
            

            string greeting = 
                "Добро пожаловать в ресторан.\n " +
                "У нас Вы можете забронировать места зараннее.";
            string freePlaces = "У нас остались свободные места за следующими столами: ";
            string tableTask = "Введите номер стола за которым хотите сидеть или Exit, если хотите выйти: ";
            string wrongTable = "Такого стола нет";
            string wrongPlaces = "За столом {0} не хватает мест, выберите другой стол.";
            string tableRezerved = "Этот стол занят.";
            string placeTask = "Введите кличество мест, которое хотите занять: ";
            string rezultTitle = "Вы забронировали места: ";
            string rezultFormat = "Стол {0} - {1} мест.";
            string bye = "Пока";



            bool exit = false;

            string commandName = "Bron";

            Console.WriteLine(greeting);

            while (!exit)
            {
                switch (commandName)
                {
                    case "Exit":
                        exit = true;
                        Console.WriteLine(bye);
                        continue;
                    case "Bron":
                        Console.WriteLine(freePlaces);
                        for (int i = 0; i < tables.GetLength(0); i++)
                        {
                            Console.WriteLine(
                                "Стол №" + i + ": свобно - " 
                                + tables[i, 0] + ", занято "
                                + (tables[i, 1] - tables[i, 0]) + " мест."
                                );
                        }
                        Console.Write(tableTask);
                        string currentCommand = Console.ReadLine().ToLower();
                        if(currentCommand == "exit")
                        {
                            commandName = "Exit";
                            continue;
                        }
                        int currentTable = Convert.ToInt32(currentCommand);

                        if (currentTable >= 0 && currentTable < tables.GetLength(0) )
                        {
                            if(tables[currentTable, 1] == tables[currentTable, 0])
                            {
                                Console.WriteLine(tableRezerved);
                                continue;
                            }
                            Console.Write(placeTask);
                            int currentPlaceCount = Convert.ToInt32(Console.ReadLine());
                            if(currentPlaceCount > tables[currentTable, 0])
                            {

                                Console.WriteLine(wrongPlaces);
                                commandName = "Bron";
                                continue;
                            }
                            else
                            {
                                order[currentTable] = currentPlaceCount;
                                tables[currentTable, 0] -= currentPlaceCount;
                                Console.WriteLine(rezultTitle);
                                for (int tableNumber = 0; tableNumber < order.Length; tableNumber++)
                                {
                                    if(order[tableNumber] > 0)
                                    {
                                        Console.WriteLine(rezultFormat, tableNumber, order[tableNumber]);
                                    }
                                }
                                commandName = "Bron";
                            }
                        }
                        else
                        {
                            Console.WriteLine(wrongTable);
                            continue;
                        }
                            
                        break;
                }
            }
        }
    }
}
