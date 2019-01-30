using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLightModul3
{
    class Task2
    {
        static void Main(string[] args)
        {
            int windowWidth = 94;
            int windowHeight = 50;
            int mapWidth = 40; 
            int mapHeight = 40;
            char mushroom = 'T';
            char mushroomCeeperRight = 'R';
            char mushroomCeeperLeft = 'Я';
            char mushroomCeeper = mushroomCeeperRight;
            int mushroomCounter = 0;
            Random random = new Random();

            Console.SetWindowSize(Console.WindowWidth, windowWidth);
            Console.SetWindowSize(Console.WindowHeight, windowHeight);


            char[,] map = new char[mapWidth, mapHeight];
            for (int row = 0; row < mapHeight; row++)
            {
                for (int col = 0; col < mapWidth; col++)
                {
                    if (row == 0 || col == 0 || row == mapHeight-1 || col == mapWidth-1)
                    {
                        map[row, col] = '#';
                    }
                    else
                    {
                        map[row, col] = ' ';
                        if(row % (random.Next(mapHeight)+1) == 0 && col% (random.Next(mapWidth)+1) == 0)
                        {
                            map[row, col] = mushroom;
                            mushroomCounter++;
                        }
                    }
                }
            }
            char[] bag = new char[0];


            int Y = 1, X = 1;
            while (true)
            {
                Console.SetCursorPosition(mapWidth+5, 0);
                Console.Write("Здравствуйте, Вы пришли в лес за грибами.");
                Console.SetCursorPosition(mapWidth + 5, 1);
                Console.Write("Чтобы приготовить обед. Собери их все!");
                Console.SetCursorPosition(mapWidth+5, 3);
                Console.Write("Сумка:");
                Console.SetCursorPosition(mapWidth + 5, 4);
                for (int i = 0; i < bag.Length; i++)
                {
                    if (i == (windowWidth - mapWidth - 3)/2)
                    {
                        Console.SetCursorPosition(mapWidth + 5, 5);
                    }
                    if (i == windowWidth - mapWidth - 3)
                    {
                        Console.SetCursorPosition(mapWidth + 5, 6);
                    }
                    Console.Write(bag[i] + "|");
                    
                }

                if (bag.Length == mushroomCounter)
                {

                    Console.SetCursorPosition(mapWidth + 5, 10);
                    Console.Write("Поздравляю! Вы собрали все грибы!");

                    Console.SetCursorPosition(mapWidth + 5, 11);
                    Console.Write("Mожете приготовить из них что-то вкусное!");
                }

                Console.SetCursorPosition(0, 0);

                for (int row = 0; row < map.GetLength(0); row++)
                {
                    for (int col = 0; col < map.GetLength(1); col++)
                    {
                        Console.Write(map[row, col]);
                    }
                    Console.WriteLine();
                }
                if(Y < 1) {
                    Y++;
                }
                if (Y > map.GetLength(1) - 2)
                {
                    Y--;
                }
                if(X < 1) {
                    X++;
                }
                if(X > map.GetLength(0) - 2)
                {
                    X--;
                }
                Console.SetCursorPosition(Y, X);
                Console.Write(mushroomCeeper);

                ConsoleKeyInfo charKey = Console.ReadKey();
                switch (charKey.Key)
                {
                    case ConsoleKey.UpArrow:
                        X--;
                        break;
                    case ConsoleKey.DownArrow:
                        X++;
                        break;
                    case ConsoleKey.LeftArrow:
                        Y--;
                        mushroomCeeper = mushroomCeeperLeft;
                        break;
                    case ConsoleKey.RightArrow:
                        Y++;
                        mushroomCeeper = mushroomCeeperRight;
                        break;
                }

                if (map[X, Y] == mushroom)
                {
                    map[X, Y] = 'o';
                    char[] tempBag = new char[bag.Length + 1];
                    for (int i = 0; i < bag.Length; i++)
                    {
                        tempBag[i] = bag[i];
                    }
                    tempBag[tempBag.Length - 1] = mushroom;
                    bag = tempBag;
                }
                Console.Clear();
            }
        }
    }
}
