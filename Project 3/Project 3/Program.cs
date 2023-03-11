using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.IO;

namespace CursorMovement
{
    struct enemy
    {
        public int x;
        public int y;
        public string type;
        public bool exist;

    }
    class Programv
    {
        static bool refwall(int x, int y, string add_del, string[,] map)
        {
            bool done = false;
            Random rnd = new Random();
            int num = rnd.Next(4);
            if (num == 0)
            {
                Console.SetCursorPosition(x + 1, y);
                if (add_del == "add")
                {
                    Console.WriteLine("##");
                    refresh_map(x + 1, y, "#", map);
                    refresh_map(x + 2, y, "#", map);
                    done = true;
                }
                else if (add_del == "del")
                {
                    Console.WriteLine("  ");
                    refresh_map(x + 1, y, " ", map);
                    refresh_map(x + 2, y, " ", map);
                    done = true;
                }
                if (!wall_exist(x, y + 1, map))
                {
                    Console.SetCursorPosition(x, y);
                    if (add_del == "add")
                    {
                        Console.WriteLine("#");
                        refresh_map(x, y, "#", map);
                    }
                    else if (add_del == "del")
                    {
                        Console.WriteLine(" ");
                        refresh_map(x, y, " ", map);
                    }
                }
                if (!wall_exist(x + 3, y + 1, map))
                {
                    Console.SetCursorPosition(x + 3, y);
                    if (add_del == "add")
                    {
                        Console.WriteLine("#");
                        refresh_map(x + 3, y, "#", map);
                    }
                    else if (add_del == "del")
                    {
                        Console.WriteLine(" ");
                        refresh_map(x + 3, y, " ", map);
                    }
                }
            }
            else if (num == 1)
            {
                Console.SetCursorPosition(x + 1, y + 3);
                if (add_del == "add")
                {
                    Console.WriteLine("##");
                    refresh_map(x + 1, y + 3, "#", map);
                    refresh_map(x + 2, y + 3, "#", map);
                    done = true;
                }
                else if (add_del == "del")
                {
                    Console.WriteLine("  ");
                    refresh_map(x + 1, y + 3, " ", map);
                    refresh_map(x + 2, y + 3, " ", map);
                    done = true;
                }
                if (!wall_exist(x, y + 2, map))
                {
                    Console.SetCursorPosition(x, y + 3);
                    if (add_del == "add")
                    {
                        Console.WriteLine("#");
                        refresh_map(x, y + 3, "#", map);
                    }
                    else if (add_del == "del")
                    {
                        Console.WriteLine(" ");
                        refresh_map(x, y + 3, " ", map);
                    }
                }
                if (!wall_exist(x + 3, y + 2, map))
                {
                    Console.SetCursorPosition(x + 3, y + 3);
                    if (add_del == "add")
                    {
                        Console.WriteLine("#");
                        refresh_map(x + 3, y + 3, "#", map);
                    }
                    else if (add_del == "del")
                    {
                        Console.WriteLine(" ");
                        refresh_map(x + 3, y + 3, " ", map);
                    }
                }
            }
            else if (num == 2)
            {

                if (add_del == "add")
                {
                    Console.SetCursorPosition(x, y + 1);
                    Console.WriteLine("#");
                    Console.SetCursorPosition(x, y + 2);
                    Console.WriteLine("#");
                    refresh_map(x, y + 1, "#", map);
                    refresh_map(x, y + 2, "#", map);
                    done = true;
                }
                else if (add_del == "del")
                {
                    Console.SetCursorPosition(x, y + 1);
                    Console.WriteLine(" ");
                    Console.SetCursorPosition(x, y + 2);
                    Console.WriteLine(" ");
                    refresh_map(x, y + 1, " ", map);
                    refresh_map(x, y + 2, " ", map);
                    done = true;
                }
                if (!wall_exist(x + 1, y, map))
                {
                    if (add_del == "add")
                    {
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine("#");
                        refresh_map(x, y, "#", map);

                    }
                    else if (add_del == "del")
                    {
                        Console.SetCursorPosition(x, y);
                        Console.WriteLine(" ");
                        refresh_map(x, y, " ", map);
                    }
                }
                if (!wall_exist(x + 1, y + 3, map))
                {
                    if (add_del == "add")
                    {
                        Console.SetCursorPosition(x, y + 3);
                        Console.WriteLine("#");
                        refresh_map(x, y + 3, "#", map);

                    }
                    else if (add_del == "del")
                    {
                        Console.SetCursorPosition(x, y + 3);
                        Console.WriteLine(" ");
                        refresh_map(x, y + 3, " ", map);
                    }
                }
            }
            else if (num == 3)
            {

                if (add_del == "add")
                {
                    Console.SetCursorPosition(x + 3, y + 1);
                    Console.WriteLine("#");
                    Console.SetCursorPosition(x + 3, y + 2);
                    Console.WriteLine("#");
                    refresh_map(x + 3, y + 1, "#", map);
                    refresh_map(x + 3, y + 2, "#", map);
                    done = true;
                }
                else if (add_del == "del")
                {
                    Console.SetCursorPosition(x + 3, y + 1);
                    Console.WriteLine(" ");
                    Console.SetCursorPosition(x + 3, y + 2);
                    Console.WriteLine(" ");
                    refresh_map(x + 3, y + 1, " ", map);
                    refresh_map(x + 3, y + 2, " ", map);
                    done = true;
                }
                if (!wall_exist(x + 2, y, map))
                {
                    if (add_del == "add")
                    {
                        Console.SetCursorPosition(x + 3, y);
                        Console.WriteLine("#");
                        refresh_map(x + 3, y, "#", map);

                    }
                    else if (add_del == "del")
                    {
                        Console.SetCursorPosition(x + 3, y);
                        Console.WriteLine(" ");
                        refresh_map(x + 3, y, " ", map);
                    }
                }
                if (!wall_exist(x + 2, y + 3, map))
                {
                    if (add_del == "add")
                    {
                        Console.SetCursorPosition(x + 3, y + 3);
                        Console.WriteLine("#");
                        refresh_map(x + 3, y + 3, "#", map);

                    }
                    else if (add_del == "del")
                    {
                        Console.SetCursorPosition(x + 3, y + 3);
                        Console.WriteLine(" ");
                        refresh_map(x + 3, y + 3, " ", map);
                    }
                }
            }
            return done;
        }

        static int how_many_walls(int x, int y, string[,] map)
        {
            int count = 0;
            if (wall_exist(x, y + 1, map))
                count++;
            if (wall_exist(x + 3, y + 1, map))
                count++;
            if (wall_exist(x + 1, y, map))
                count++;
            if (wall_exist(x + 1, y + 3, map))
                count++;

            return count;
        }
        static string what_is_in_pixel(int x, int y, string[,] map)
        {
            string pixel = " ";
            if (map[y - 3, x - 3] == "#")
                pixel = "#";
            else if (map[y - 3, x - 3] == "X")
                pixel = "X";
            else if (map[y - 3, x - 3] == "Y")
                pixel = "Y";
            else if (map[y - 3, x - 3] == "P")
                pixel = "P";
            else if (map[y - 3, x - 3] == "+")
                pixel = "+";
            else if (map[y - 3, x - 3] == "1")
                pixel = "1";
            else if (map[y - 3, x - 3] == "2")
                pixel = "2";
            else if (map[y - 3, x - 3] == "3")
                pixel = "3";

            return pixel;
        }
        static bool wall_exist(int x, int y, string[,] map)
        {
            bool flag = false;
            if (map[y - 3, x - 3] == "#")
                flag = true;


            return flag;

        }
        static void refresh_map(int x, int y, string pixel, string[,] map)
        {
            map[y - 3, x - 3] = pixel;
        }

        static void Main(string[] args)
        {

            Thread.Sleep(500);
            string again = "yes";
            do
            {
                // Game Start Menu
                bool entry = false;
                string difficulty = "";
                Console.Write("Please choose difficulty (hard, normal, easy, editor) : ");

                // Controls here is it true input or not
                while (entry == false)
                {
                    string difficult = Console.ReadLine();
                    difficulty = difficult.ToLower();

                    if (difficulty != "hard" & difficulty != "normal" & difficulty != "easy" & difficulty != "editor")
                    {
                        Console.WriteLine("WRONG ENTRY! ");
                        Console.WriteLine("Please Write Correct Difficulty");

                    }
                    else
                    {
                        break;
                    }
                }



                Console.Clear();
                Random rnd = new Random();
                Console.CursorVisible = false;

                // Defining some variables and arrays
                int[] pointsArr = { 1, 1, 1, 1, 1, 1, 2, 2, 2, 3 };
                int[,] pointsPositions = new int[1005, 3];
                int timeUnit = 0, pointsPositionsIndex = 0, minecounter = 2, time = 0, energy = 200, score = 0, timeAdd = 0, maxScore = 0;

                // Taking Max Score from text file
                if (!File.Exists("maxScore.txt"))
                {
                    StreamWriter f = File.CreateText("maxScore.txt");
                    f.Close();
                }
                else
                {
                    StreamReader f = File.OpenText("maxScore.txt");
                    maxScore = Convert.ToInt32(f.ReadLine());
                    f.Close();
                }

                ConsoleKeyInfo cki;              // required for readkey

                bool placemine = false;

                // Defining Struct 
                enemy[] enemies = new enemy[70];
                for (int i = 0; i < enemies.Length; i++)
                {
                    enemies[i].exist = false;

                }

                // Creating a map array to store Collectible numbers, Mines, Player and Enemies
                string[,] map = new string[24, 52];
                for (int i = 0; i < map.GetLength(0); i++)
                {
                    for (int j = 0; j < map.GetLength(1); j++)
                    {
                        map[i, j] = " ";
                    }
                }


                // --- Static screen parts

                Console.SetCursorPosition(3, 3);
                Console.WriteLine("#####################################################");
                for (int i = 0; i < 21; i++)
                {
                    Console.SetCursorPosition(3, 3 + i + 1);
                    Console.WriteLine("#                                                   #");
                }
                Console.SetCursorPosition(3, 25);
                Console.WriteLine("#####################################################");

                // Defining some variables
                int ywalup = 5;
                int ywalldown = 8;

                bool wup = false;
                bool wdown = false;
                bool wleft = false;
                bool wright = false;
                Random rand = new Random();
                int wallsx = 5;


                for (int i = 0; i < 4; i++)
                {

                    while (wallsx < 55)
                    {
                        int Count = 0;

                        int rac = rand.Next(1, 4);
                        while (Count < rac)
                        {
                            if (Count == 3)
                            {
                                break;
                            }
                            if (wup == false)
                            {
                                int ran = rand.Next(0, 2);
                                if (ran == 0)
                                {

                                    wup = true;
                                    Count++;
                                    Console.SetCursorPosition(wallsx, ywalup);
                                    Console.WriteLine("####");
                                    map[ywalup - 3, wallsx - 3] = "#";
                                    map[ywalup - 3, wallsx - 3 + 1] = "#";
                                    map[ywalup - 3, wallsx - 3 + 2] = "#";
                                    map[ywalup - 3, wallsx - 3 + 3] = "#";
                                }

                            }

                            // Controls if there is 3 walls
                            if (Count == 3)
                            {
                                break;
                            }

                            //  Adding walls to downside
                            if (wdown == false)
                            {
                                int ran = rand.Next(0, 2);
                                if (ran == 0)
                                {

                                    wdown = true;
                                    Count++;
                                    Console.SetCursorPosition(wallsx, ywalldown);
                                    Console.WriteLine("####");

                                    map[ywalldown - 3, wallsx - 3] = "#";
                                    map[ywalldown - 3, wallsx - 3 + 1] = "#";
                                    map[ywalldown - 3, wallsx - 3 + 2] = "#";
                                    map[ywalldown - 3, wallsx - 3 + 3] = "#";
                                }

                            }

                            // Controls if there is 3 walls
                            if (Count == 3)
                            {
                                break;
                            }

                            //  Adding walls to left-side

                            if (wleft == false)
                            {
                                int ran = rand.Next(0, 2);

                                if (ran == 0)
                                {
                                    wleft = true;
                                    Count++;
                                    for (int wallsy = ywalup; wallsy < ywalup + 4; wallsy++)
                                    {
                                        Console.SetCursorPosition(wallsx, wallsy);
                                        Console.WriteLine("#");

                                        map[wallsy - 3, wallsx - 3] = "#";
                                    }
                                }
                            }

                            if (Count == 3)
                            {
                                break;
                            }

                            //  Adding walls to rightside

                            if (wright == false)
                            {
                                int ran = rand.Next(0, 2);

                                if (ran == 0)
                                {
                                    Count++;
                                    wright = true;
                                    for (int wallsy = ywalup; wallsy < ywalup + 4; wallsy++)
                                    {
                                        Console.SetCursorPosition(wallsx + 3, wallsy);
                                        Console.WriteLine("#");

                                        map[wallsy - 3, wallsx] = "#";
                                    }
                                }
                            }
                        }
                        // Turning bool variables to false
                        wallsx += 5;
                        wup = false;
                        wright = false;
                        wdown = false;
                        wleft = false;
                    }
                    wallsx = 5;
                    ywalup += 5;
                    ywalldown += 5;
                }
                int cursorx, cursory;   // position of cursor


                do
                {
                    cursorx = rnd.Next(4, 54); cursory = rnd.Next(4, 22);
                } while (wall_exist(cursorx, cursory, map));

                // Randomly generating X and Y enemy positions
                do
                {
                    enemies[0].x = rnd.Next(4, 54); enemies[0].y = rnd.Next(4, 22); enemies[0].type = "X"; enemies[0].exist = true;
                } while (wall_exist(enemies[0].x, enemies[0].y, map));
                do
                {
                    enemies[1].x = rnd.Next(4, 54); enemies[1].y = rnd.Next(4, 22); enemies[1].type = "X"; enemies[1].exist = true;
                } while (wall_exist(enemies[1].x, enemies[1].y, map));
                do
                {
                    enemies[2].x = rnd.Next(4, 54); enemies[2].y = rnd.Next(4, 22); enemies[2].type = "Y"; enemies[2].exist = true;
                } while (wall_exist(enemies[2].x, enemies[2].y, map));
                do
                {
                    enemies[3].x = rnd.Next(4, 54); enemies[3].y = rnd.Next(4, 22); enemies[3].type = "Y"; enemies[3].exist = true;
                } while (wall_exist(enemies[3].x, enemies[3].y, map));

                int number_of_enemy = 4;

                // Coloring
                if (timeUnit == 0)
                {

                    Console.BackgroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(cursorx, cursory);
                    Console.WriteLine("P");
                    Thread.Sleep(1000);
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.SetCursorPosition(cursorx, cursory);
                    Console.WriteLine("P");
                    Thread.Sleep(1000);
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(cursorx, cursory);
                    Console.WriteLine("P");
                    Thread.Sleep(1000);
                    Console.BackgroundColor = ConsoleColor.Black;

                }

                int easy_or_not = 1;
                if (difficulty == "easy")
                    easy_or_not = 2;
                bool gameOver = false;

                // --- Main game loop
                while (!gameOver)
                {

                    // Adding Collectible numbers
                    if (timeUnit == 0)
                    {
                        for (int pointI = 0; pointI < 20; pointI++)
                        {
                            int randomIndex = rnd.Next(0, 10), pointX = 0, pointY = 0;
                            bool flagPoint = true;
                            while (flagPoint)
                            {

                                pointX = rnd.Next(4, 54);
                                pointY = rnd.Next(4, 24);
                                if (!wall_exist(pointX, pointY, map))
                                {
                                    flagPoint = false;
                                }
                            }

                            int point = pointsArr[randomIndex];
                            refresh_map(pointX, pointY, Convert.ToString(point), map);

                            pointsPositionsIndex += 1;

                            Console.SetCursorPosition(pointX, pointY);
                            Console.Write(point);
                        }
                    }

                    // Chronometre
                    if (timeAdd == 4)
                    {
                        time += 1;
                        timeAdd = 0;
                    }

                    Console.SetCursorPosition(64, 3);
                    Console.WriteLine("Time          :   " + time);
                    Console.SetCursorPosition(64, 5);
                    Console.WriteLine("Score         :   " + score);
                    Console.SetCursorPosition(64, 7);
                    Console.WriteLine("Energy        :      ");
                    Console.SetCursorPosition(64, 7);
                    Console.WriteLine("Energy        :   " + energy);
                    Console.SetCursorPosition(64, 9);
                    Console.WriteLine("Mine          :   " + minecounter);
                    Console.SetCursorPosition(64, 11);
                    Console.WriteLine("Max Score     :   " + maxScore);

                    int is_energy_under_zero = 1;
                    if (energy <= 0)
                        is_energy_under_zero = 2;

                    if (timeUnit % 10 == 0) // points
                    {
                        int randomIndex = rnd.Next(0, 10), pointX = 0, pointY = 0;
                        bool flagPoint = true;
                        while (flagPoint)
                        {
                            pointX = rnd.Next(4, 54);
                            pointY = rnd.Next(4, 24);
                            if (!wall_exist(pointX, pointY, map))
                            {
                                flagPoint = false;
                            }
                        }

                        int point = pointsArr[randomIndex];
                        refresh_map(pointX, pointY, Convert.ToString(point), map);

                        pointsPositionsIndex += 1;

                        Console.SetCursorPosition(pointX, pointY);
                        Console.Write(point);
                    }

                    // Taking Input from user
                    if (Console.KeyAvailable && timeUnit % is_energy_under_zero == 0)
                    {

                        


                        cki = Console.ReadKey();         // true: there is a key in keyboard buffer

                        // If you want to activate cleaning buffer you can turn open bottop code

                        while (Console.KeyAvailable)
                        {
                            Console.ReadKey(false);
                        }

                        // Laying Mine if user press Spacebar
                        if (cki.KeyChar == 32)
                        {
                            placemine = true;
                        }

                        // Editor adding mines and enemies 
                        if (cki.KeyChar == 120 && difficulty == "editor")
                        {
                            enemies[number_of_enemy].x = rnd.Next(4, 55); enemies[number_of_enemy].y = rnd.Next(4, 25); enemies[number_of_enemy].type = "X"; enemies[number_of_enemy].exist = true;
                            number_of_enemy++;
                        }
                        if (cki.KeyChar == 121 && difficulty == "editor")
                        {
                            enemies[number_of_enemy].x = rnd.Next(4, 55); enemies[number_of_enemy].y = rnd.Next(4, 25); enemies[number_of_enemy].type = "Y"; enemies[number_of_enemy].exist = true;
                            number_of_enemy++;
                        }

                        if (cki.KeyChar == 109 && difficulty == "editor")
                        {
                            minecounter += 5;
                        }

                        // User Right Movements
                        if (cki.Key == ConsoleKey.RightArrow && cursorx < 54 && !wall_exist(cursorx + 1, cursory, map))
                        {  
                            Console.SetCursorPosition(cursorx, cursory);           
                            if (placemine == true && minecounter != 0)
                            {
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.WriteLine("+");
                                Console.BackgroundColor = ConsoleColor.Black;
                                refresh_map(cursorx, cursory, "+", map);
                                cursorx++;
                                minecounter--;
                                placemine = false;
                            }
                            else
                            {
                                Console.WriteLine(" ");
                                cursorx++;
                            }
                            if (energy > 0)
                                energy--;
                        }
                        // User Left Movements
                        if (cki.Key == ConsoleKey.LeftArrow && cursorx > 4 && !wall_exist(cursorx - 1, cursory, map))
                        {
                            Console.SetCursorPosition(cursorx, cursory);
                            if (placemine == true && minecounter != 0)
                            {
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.WriteLine("+");
                                Console.BackgroundColor = ConsoleColor.Black;
                                refresh_map(cursorx, cursory, "+", map);
                                cursorx--;
                                minecounter--;
                                placemine = false;
                            }
                            else
                            {
                                Console.WriteLine(" ");
                                cursorx--;
                            }
                            if (energy > 0)
                                energy--;
                        }
                        // User Up Movements
                        if (cki.Key == ConsoleKey.UpArrow && cursory > 4 && !wall_exist(cursorx, cursory - 1, map))
                        {

                            Console.SetCursorPosition(cursorx, cursory);
                            if (placemine == true && minecounter != 0)
                            {
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.WriteLine("+");
                                Console.BackgroundColor = ConsoleColor.Black;
                                refresh_map(cursorx, cursory, "+", map);
                                cursory--;
                                minecounter--;
                                placemine = false;
                            }
                            else
                            {
                                Console.WriteLine(" ");
                                cursory--;
                            }
                            if (energy > 0)
                                energy--;
                        }

                        // User Down Movements
                        if (cki.Key == ConsoleKey.DownArrow && cursory < 24 && !wall_exist(cursorx, cursory + 1, map))
                        {
                            Console.SetCursorPosition(cursorx, cursory);
                            if (placemine == true && minecounter != 0)
                            {
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.WriteLine("+");
                                Console.BackgroundColor = ConsoleColor.Black;
                                refresh_map(cursorx, cursory, "+", map);
                                cursory++;
                                minecounter--;
                                placemine = false;
                            }
                            else
                            {
                                Console.WriteLine(" ");
                                cursory++;
                            }
                            if (energy > 0)
                                energy--;
                        }

                        //while (Console.KeyAvailable)
                        //{
                        //    Console.ReadKey(true);
                        //}

                        if (cki.Key == ConsoleKey.Escape) break;
                    }


                    // Adding new enemies to arena
                    if (timeUnit % 150 == 0 && timeUnit > 145)
                    {
                        do
                        {
                            int temp = rnd.Next(0, 2);
                            if (temp == 0)
                            {
                                enemies[number_of_enemy].x = rnd.Next(4, 55); enemies[number_of_enemy].y = rnd.Next(4, 25); enemies[number_of_enemy].type = "Y"; enemies[number_of_enemy].exist = true;
                            }
                            else
                            {
                                enemies[number_of_enemy].x = rnd.Next(4, 55); enemies[number_of_enemy].y = rnd.Next(4, 25); enemies[number_of_enemy].type = "X"; enemies[number_of_enemy].exist = true;
                            }
                        } while (what_is_in_pixel(enemies[number_of_enemy].x, enemies[number_of_enemy].y, map) != " ");
                        number_of_enemy++;
                    }

                    // Enemy Movements
                    for (int k = 0; k < number_of_enemy; k++)
                    {

                        // Y movements
                        if (enemies[k].type == "Y" && enemies[k].exist == true && timeUnit % easy_or_not == 0)
                        {
                            int yx = enemies[k].x;
                            int yy = enemies[k].y;
                            Console.SetCursorPosition(yx, yy);    // delete old y
                            Console.WriteLine(" ");
                            refresh_map(yx, yy, " ", map);


                            if (yy != cursory || yx != cursorx)
                            {
                                bool did_move = false;
                                if (yy > cursory && !wall_exist(yx, yy - 1, map) && !did_move && what_is_in_pixel(yx, yy - 1, map) != "X" && what_is_in_pixel(yx, yy - 1, map) != "Y")
                                {
                                    yy -= 1;
                                    did_move = true;
                                }
                                if (yy < cursory && !wall_exist(yx, yy + 1, map) && !did_move && what_is_in_pixel(yx, yy + 1, map) != "X" && what_is_in_pixel(yx, yy + 1, map) != "Y")
                                {
                                    yy += 1;
                                    did_move = true;
                                }
                                if (yx > cursorx && !wall_exist(yx - 1, yy, map) && !did_move && what_is_in_pixel(yx - 1, yy, map) != "X" && what_is_in_pixel(yx - 1, yy, map) != "Y")
                                {
                                    yx -= 1;
                                    did_move = true;
                                }
                                if (yx < cursorx && !wall_exist(yx + 1, yy, map) && !did_move && what_is_in_pixel(yx + 1, yy, map) != "X" && what_is_in_pixel(yx + 1, yy, map) != "Y")
                                {
                                    yx += 1;
                                    did_move = true;
                                }


                                if (difficulty == "hard")
                                {
                                    if (!did_move && !wall_exist(yx, yy - 1, map) && !did_move && what_is_in_pixel(yx, yy - 1, map) != "X" && what_is_in_pixel(yx, yy - 1, map) != "Y" && yy != 4 && yy != 24)
                                    {
                                        yy -= 1;
                                        did_move = true;
                                    }
                                    else if (!did_move && !wall_exist(yx, yy + 1, map) && !did_move && what_is_in_pixel(yx, yy + 1, map) != "X" && what_is_in_pixel(yx, yy + 1, map) != "Y" && yy != 4 && yy != 24)
                                    {
                                        yy += 1;
                                        did_move = true;
                                    }
                                    else if (!did_move && !wall_exist(yx - 1, yy, map) && !did_move && what_is_in_pixel(yx - 1, yy, map) != "X" && what_is_in_pixel(yx - 1, yy, map) != "Y" && yx != 4 && yx != 54)
                                    {
                                        yx -= 1;
                                        did_move = true;

                                    }
                                    else if (!did_move && !wall_exist(yx + 1, yy, map) && !did_move && what_is_in_pixel(yx + 1, yy, map) != "X" && what_is_in_pixel(yx + 1, yy, map) != "Y" && yx != 4 && yx != 54)
                                    {
                                        yx += 1;
                                        did_move = true;
                                    }

                                }


                            }

                            else
                            {
                                Console.SetCursorPosition(yx, yy);
                                Console.WriteLine(" ");
                                refresh_map(yx, yy, " ", map);
                                gameOver = true;
                                break;
                            }
                            if (what_is_in_pixel(yx, yy, map) == "+")
                            {
                                Console.SetCursorPosition(yx, yy);
                                Console.WriteLine(" ");
                                refresh_map(yx, yy, " ", map);
                                enemies[k].exist = false;
                                enemies[k].x = 0;
                                enemies[k].y = 0;
                                score += 300;

                            }
                            else
                            {
                                Console.SetCursorPosition(yx, yy);    // refresh y (current position)
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("Y");
                                Console.ForegroundColor = ConsoleColor.Gray;

                                refresh_map(yx, yy, "Y", map);
                            }

                            enemies[k].x = yx;
                            enemies[k].y = yy;
                        }

                        // X movements
                        else if (enemies[k].type == "X" && enemies[k].exist == true && timeUnit % easy_or_not == 0)
                        {
                            int xx = enemies[k].x;
                            int xy = enemies[k].y;
                            Console.SetCursorPosition(xx, xy);    // delete old X
                            Console.WriteLine(" ");
                            refresh_map(xx, xy, " ", map);
                            if (xx != cursorx || xy != cursory)
                            {
                                bool did_move = false;
                                if (xx > cursorx && !wall_exist(xx - 1, xy, map) && !did_move && what_is_in_pixel(xx - 1, xy, map) != "X" && what_is_in_pixel(xx - 1, xy, map) != "Y")
                                {
                                    xx -= 1;
                                    did_move = true;
                                }
                                if (xx < cursorx && !wall_exist(xx + 1, xy, map) && !did_move && what_is_in_pixel(xx + 1, xy, map) != "X" && what_is_in_pixel(xx + 1, xy, map) != "Y")
                                {
                                    xx += 1;
                                    did_move = true;
                                }
                                if (xy > cursory && !wall_exist(xx, xy - 1, map) && !did_move && what_is_in_pixel(xx, xy - 1, map) != "X" && what_is_in_pixel(xx, xy - 1, map) != "Y")
                                {
                                    xy -= 1;
                                    did_move = true;
                                }
                                if (xy < cursory && !wall_exist(xx, xy + 1, map) && !did_move && what_is_in_pixel(xx, xy + 1, map) != "X" && what_is_in_pixel(xx, xy + 1, map) != "Y")
                                {
                                    xy += 1;
                                    did_move = true;
                                }
                                if (difficulty == "hard")
                                {
                                    if (!did_move && !wall_exist(xx, xy - 1, map) && !did_move && what_is_in_pixel(xx, xy - 1, map) != "X" && what_is_in_pixel(xx, xy - 1, map) != "Y" && xy != 4 && xy != 24)
                                    {
                                        xy -= 1;
                                        did_move = true;
                                    }
                                    else if (!did_move && !wall_exist(xx, xy + 1, map) && !did_move && what_is_in_pixel(xx, xy + 1, map) != "X" && what_is_in_pixel(xx, xy + 1, map) != "Y" && xy != 4 && xy != 24)
                                    {
                                        xy += 1;
                                        did_move = true;
                                    }
                                    else if (!did_move && !wall_exist(xx - 1, xy, map) && !did_move && what_is_in_pixel(xx - 1, xy, map) != "X" && what_is_in_pixel(xx - 1, xy, map) != "Y" && xx != 4 && xx != 54)
                                    {
                                        xx -= 1;
                                        did_move = true;

                                    }
                                    else if (!did_move && !wall_exist(xx + 1, xy, map) && !did_move && what_is_in_pixel(xx + 1, xy, map) != "X" && what_is_in_pixel(xx + 1, xy, map) != "Y" && xx != 4 && xx != 54)
                                    {
                                        xx += 1;
                                        did_move = true;
                                    }

                                }
                            }

                            else
                            {
                                Console.SetCursorPosition(xx, xy);
                                Console.WriteLine(" ");
                                refresh_map(xx, xy, " ", map);
                                gameOver = true;

                                break;
                            }

                            if (what_is_in_pixel(xx, xy, map) == "+")
                            {
                                Console.SetCursorPosition(xx, xy);
                                Console.WriteLine(" ");
                                refresh_map(xx, xy, " ", map);
                                enemies[k].exist = false;
                                enemies[k].x = 0;
                                enemies[k].y = 0;
                                score += 300;
                            }
                            else
                            {
                                Console.SetCursorPosition(xx, xy);    // refresh X (current position)
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("X");
                                Console.ForegroundColor = ConsoleColor.Gray;
                                refresh_map(xx, xy, "X", map);
                                enemies[k].x = xx;
                                enemies[k].y = xy;
                            }

                        }
                    }
                    if (gameOver)
                    {

                        break;
                    }


                    Console.SetCursorPosition(cursorx, cursory);    // refresh P (current position)
                    cursorx -= 3;
                    cursory -= 3;
                    if (map[cursory, cursorx] == "+")
                    {

                        break;
                    }
                    // Adding score, energy and mine with numbers
                    else if (map[cursory, cursorx] == "1")
                    {
                        score += 10;
                    }
                    else if (map[cursory, cursorx] == "2")
                    {
                        score += 30;
                        energy += 50;
                    }
                    else if (map[cursory, cursorx] == "3")
                    {
                        score += 90;
                        energy += 200;
                        minecounter += 1;
                    }
                    cursorx += 3;
                    cursory += 3;
                    map[cursory - 3, cursorx - 3] = "P";
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("P");
                    Console.ForegroundColor = ConsoleColor.Gray;

                    timeUnit += 1;
                    Thread.Sleep(200);     // sleep 200 ms

                    timeAdd += 1;

                    bool done = false;

                    do
                    {

                        int[] wallsIdx = { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };
                        int[] wallsIdy = { 5, 10, 15, 20 };

                        int randomwallx = rand.Next(0, 10);
                        int randomwally = rand.Next(0, 4);
                        int addordelete = rand.Next(0, 2);

                        if (addordelete == 0)
                        {

                            if (how_many_walls(wallsIdx[randomwallx], wallsIdy[randomwally], map) < 3)
                            {
                                done = refwall(wallsIdx[randomwallx], wallsIdy[randomwally], "add", map);

                            }

                        }
                        else if (addordelete == 1)
                        {

                            if (how_many_walls(wallsIdx[randomwallx], wallsIdy[randomwally], map) > 1)
                            {
                                done = refwall(wallsIdx[randomwallx], wallsIdy[randomwally], "del", map);

                            }

                        }
                    } while (!done);

                    // Wall Part
                    Console.SetCursorPosition(3, 3);
                    for (int kk = 0; kk < 53; kk++)
                    {
                        Console.Write("#");
                    }
                    for (int kk = 0; kk < 21; kk++)
                    {
                        Console.SetCursorPosition(3, kk + 4);
                        Console.Write("#");
                    }
                    for (int kk = 0; kk < 21; kk++)
                    {
                        Console.SetCursorPosition(55, kk + 4);
                        Console.Write("#");
                    }
                    Console.SetCursorPosition(3, 25);
                    for (int kk = 0; kk < 53; kk++)
                    {
                        Console.Write("#");
                    }

                    if (score > maxScore)
                    {
                        File.Delete("maxScore.txt");
                        StreamWriter f = File.CreateText("maxScore.txt");
                        f.Write(score);
                        f.Close();
                    }
                }

                Console.Clear();
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("GAME OVER");
                Console.SetCursorPosition(0, 2);
                Console.WriteLine("Score         :   " + score);
                Console.SetCursorPosition(0, 4);
                Console.WriteLine("Max Score     :   " + maxScore);

                Console.SetCursorPosition(0, 6);
                // Play Again ALgorithm
                do
                {
                    Console.Write("Do you want to try again (yes or no) ? : ");
                    again = Console.ReadLine().ToLower();
                } while (again != "yes" && again != "no");

            } while (again == "yes");


            Thread.Sleep(500);

            Console.SetCursorPosition(0, 30);

            Console.ReadKey(true);

            Console.ReadLine();
        }


    }
}