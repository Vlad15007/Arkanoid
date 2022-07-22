using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Arkanoid
{
    class Program
    {
        static int[,] map =
        {
            {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
            {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
            {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
            {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
            {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 2, 2, 2, 2, 2, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
            {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
            {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
            {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
            {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
            {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
            {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
            {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
            {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
            {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
            {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
            {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
            {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
            {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
            {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
            {1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},

        };
        static bool left = false;
        static bool right = false;
        static int y = 0;
        static int x = 0;
        static bool alive = true;

        static void DrawField()
        {
            Console.Clear();
            bool find = false;
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    if (map[i, j] == -1) Console.Write("*");
                    else if (map[i, j] == 3)
                    {
                        find = true;
                        x = j;
                        y = i;
                        Console.Write("^");
                    }
                    else if (map[i, j] == 1) Console.Write("#");
                    else if (map[i, j] == 2) Console.Write("[");
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }

            if (find == false) alive = false;
        }

        static void Move()
        {
            if (left && map[y, x - 1] <= 0)
            {
                map[y, x] = 0;
                x--;
                map[y, x] = 3;
            }
            else if (right && map[y, x + 1] <= 0)
            {
                map[y, x] = 0;
                x++;
                map[y, x] = 3;
            }
        }
        static void Menu()
        {
            Console.Clear();
            Console.SetWindowSize(100, 20);
            Console.SetBufferSize(100, 20);
            string game = @"##    ## #### ##       ##          #### ########       ###    ##       ##        
##   ##   ##  ##       ##           ##     ##         ## ##   ##       ##        
##  ##    ##  ##       ##           ##     ##        ##   ##  ##       ##        
#####     ##  ##       ##           ##     ##       ##     ## ##       ##        
##  ##    ##  ##       ##           ##     ##       ######### ##       ##        
##   ##   ##  ##       ##           ##     ##       ##     ## ##       ##        
##    ## #### ######## ########    ####    ##       ##     ## ######## ########";

            Console.WriteLine(game);
            Console.ReadLine();
        }

        static void TheEnd()
        {
            Console.Clear();
            Console.SetWindowSize(100, 20);
            Console.SetBufferSize(100, 20);
            string game = @" ######      ###    ##     ## ########     #######  ##     ## ######## ########   
##    ##    ## ##   ###   ### ##          ##     ## ##     ## ##       ##     ##  
##         ##   ##  #### #### ##          ##     ## ##     ## ##       ##     ##  
##   #### ##     ## ## ### ## ######      ##     ## ##     ## ######   ########   
##    ##  ######### ##     ## ##          ##     ##  ##   ##  ##       ##   ##    
##    ##  ##     ## ##     ## ##          ##     ##   ## ##   ##       ##    ##   
 ######   ##     ## ##     ## ########     #######     ###    ######## ##     ##";

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(game);

        }

        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Menu();

            Console.SetWindowSize(34, 21);
            Console.SetBufferSize(34, 21);

            Thread keyRead = new Thread(KeyRead);
            keyRead.Start();

            while (alive)
            {
                Move();
                GameLogic();
                DrawField();
                Thread.Sleep(200);
            }
            TheEnd();
        }

        static void GameLogic()
        {
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    if (map[i, j] == -1)
                    {
                        if (i - 1 >= 0)
                        {
                            if(map[i - 1, j] == 0) map[i - 1, j] = -1;
                            else map[i - 1, j] = 0;
                        }
                        map[i, j] = 0;
                    }
                }
            }

            for (int i = map.GetLength(0) - 1; i > 0; i--)
            {
                for (int j = map.GetLength(1) - 1; j > 0; j--)
                {
                    if (map[i, j] == 2)
                    {
                        if (i + 1 < map.GetLength(0))
                        {
                            map[i + 1, j] = 2;
                            map[i, j] = 0;
                        }
                    }
                }
            }
        }

        static void Fire()
        {
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    if (map[i, j] == 3) map[i - 1, j] = -1;
                }
            }

        }

        static void KeyRead()
        {
            while(true)
            {
                ConsoleKey keydown = Console.ReadKey().Key;
                if (keydown == ConsoleKey.LeftArrow)
                {
                    left = true;
                    right = false;
                }
                else if (keydown == ConsoleKey.RightArrow)
                {
                    left = false;
                    right = true;
                }
                else if (keydown == ConsoleKey.Spacebar)
                {
                    Fire();
                }

                Thread.Sleep(100);
            }
            
        }
    }
}
