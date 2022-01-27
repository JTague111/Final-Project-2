using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Fisticode_Try_4
{
    class Game2
    {
        public void Start()
        {
            ConsoleKey KeyToPress=0;
            int lives = 3;
            int enemyLives = 3;
            Console.WriteLine("Lives Left: " + lives);
            Console.WriteLine("Opponent Lives: " + enemyLives);
            Console.WriteLine("Blocky prepares to hit you");
            Console.WriteLine("Input dodge");

            ConsoleKeyInfo keyPressed = Console.ReadKey();
            int[] Buttons = new int[] {39, 40, 38, 37, 32 };
           Random rnd = new Random();
            Thread.Sleep(15);
                var randomNumber= rnd.Next(0, 5);
            for (int i = 0; i < Buttons.Length; i++)
            {
                if (Buttons[randomNumber]==Buttons[i])
                {
                    Console.WriteLine($"The random number is {Buttons[i]}");
                     KeyToPress = GiveMeMYButton(Buttons[i]);
                }
            }

            /*switch (randomNumber)
            {
                default:
            }*/
            // First Attack
            Console.WriteLine($"The key to peress is{KeyToPress}");
            if (keyPressed.Key == KeyToPress)//ConsoleKey.RightArrow
            {

                Console.WriteLine("Counter attack!");
                Console.WriteLine("You sock Blocky in the jaw");
                enemyLives--;
            }
            else if (keyPressed.Key == ConsoleKey.LeftArrow)
            {
                Console.WriteLine("Blocky hits you with a devestating left hook!");
                lives--;
            }
            else if (keyPressed.Key == ConsoleKey.DownArrow)
            {
                Console.WriteLine("Blocky hits you with a devestating left hook!");
                lives--;
            }
            else if (keyPressed.Key == ConsoleKey.Spacebar)
            {
                Console.WriteLine("Blocky hits you with a devestating left hook!");
                lives--;
            }
            else if (keyPressed.Key == ConsoleKey.UpArrow)
            {
                Console.WriteLine("Blocky hits you with a devestating left hook!");
                lives--;
            }
            else
            {
                Console.WriteLine("You were indecisive and Blocky hit you");
                lives--;
            }

            Console.WriteLine("Lives Left: " + lives);
            Console.WriteLine("Opponent Lives: " + enemyLives);
            Console.WriteLine("Blocky prepares for a second attack");
            Console.WriteLine("input dodge");

            ConsoleKeyInfo keyPressed2 = Console.ReadKey();

            // Second Attack
            if (keyPressed2.Key == ConsoleKey.DownArrow)
            {
                Console.WriteLine("Counter attack!");
                Console.WriteLine("You sock Blocky in the jaw");
                enemyLives--;
            }
            else if (keyPressed2.Key == ConsoleKey.LeftArrow)
            {
                Console.WriteLine("Blocky strongly uppercuts you!");
                lives--;
            }
            else if (keyPressed2.Key == ConsoleKey.RightArrow)
            {
                Console.WriteLine("Blocky strongly uppercuts you!");
                lives--;
            }
            else if (keyPressed2.Key == ConsoleKey.UpArrow)
            {
                Console.WriteLine("Blocky strongly uppercuts you!");
                lives--;
            }
            else if (keyPressed2.Key == ConsoleKey.Spacebar)
            {
                Console.WriteLine("Blocky strongly uppercuts you!");
                lives--;
            }
            else
            {
                Console.WriteLine("You were indecisive and Blocky hit you");
                lives--;
            }

            Console.WriteLine("Lives Left: " + lives);
            Console.WriteLine("Opponent Lives: " + enemyLives);
            Console.WriteLine("Blocky prepares for a third attack");
            Console.WriteLine("input dodge");

            ConsoleKeyInfo keyPressed3 = Console.ReadKey();
            // third attack
            if (keyPressed3.Key == ConsoleKey.LeftArrow)
            {
                Console.WriteLine("Counter attack!");
                Console.WriteLine("You sock Blocky in the jaw");
                enemyLives--;
                bool isTrue = enemyLives == 0;
                if (isTrue == true)
                {
                    Console.WriteLine("VICTORY!");
                    return;
                }
            }
            else if (keyPressed3.Key == ConsoleKey.RightArrow)
            {
                Console.WriteLine("Blocky hits you with a quick right jab");
                lives--;
                bool isTrue = lives == 0;
                if (isTrue == true)
                {
                    Console.WriteLine("\n\n");
                    Console.WriteLine(" #####     #    #     # #######    ####### #     # ####### ######  ");
                    Console.WriteLine("#     #   # #   ##   ## #          #     # #     # #       #     # ");
                    Console.WriteLine("#        #   #  # # # # #          #     # #     # #       #     # ");
                    Console.WriteLine("#  #### #     # #  #  # #####      #     # #     # #####   ######  ");
                    Console.WriteLine("#     # ####### #     # #          #     #  #   #  #       #   #   ");
                    Console.WriteLine("#     # #     # #     # #          #     #   # #   #       #    #  ");
                    Console.WriteLine(" #####  #     # #     # #######    #######    #    ####### #     # ");
                    Console.ReadKey();
                    System.Environment.Exit(0);
                }
            }
            else if (keyPressed3.Key == ConsoleKey.DownArrow)
            {
                Console.WriteLine("Blocky hits you with a quick right jab!");
                lives--;
                bool isTrue = lives == 0;
                if (isTrue == true)
                {
                    System.Environment.Exit(0);
                }
            }
            else if (keyPressed3.Key == ConsoleKey.UpArrow)
            {
                Console.WriteLine("Blocky hits you with a quick right jab!");
                lives--;
                bool isTrue = lives == 0;
                if (isTrue == true)
                {
                    System.Environment.Exit(0);
                }
            }
            else if (keyPressed3.Key == ConsoleKey.Spacebar)
            {
                Console.WriteLine("Blocky hits you with a quick right jab!");
                lives--;
                bool isTrue = lives == 0;
                if (isTrue == true)
                {
                    System.Environment.Exit(0);
                }
            }
            else
            {
                Console.WriteLine("You were indecisive and Blocky hit you");
                lives--;
                bool isTrue = lives == 0;
                if (isTrue == true)
                {
                    System.Environment.Exit(0);
                }
            }

            Console.WriteLine("Lives Left: " + lives);
            Console.WriteLine("Opponent Lives: " + enemyLives);
            Console.WriteLine("Blocky prepares for a fourth attack");
            Console.WriteLine("input dodge");

            ConsoleKeyInfo keyPressed4 = Console.ReadKey();
            // fourth attack
            if (keyPressed4.Key == ConsoleKey.UpArrow)
            {
                Console.WriteLine("Counter attack!");
                Console.WriteLine("You sock Blocky in the jaw");
                enemyLives--;
                bool isTrue = enemyLives == 0;
                if (isTrue == true)
                {
                    Console.WriteLine("VICTORY!");
                    return;
                }
            }
            else if (keyPressed4.Key == ConsoleKey.RightArrow)
            {
                Console.WriteLine("Blocky grapples you and attacks!");
                lives--;
                bool isTrue = lives == 0;
                if (isTrue == true)
                {
                    System.Environment.Exit(0);
                }
            }
            else if (keyPressed4.Key == ConsoleKey.LeftArrow)
            {
                Console.WriteLine("Blocky grapples you and attacks!");
                lives--;
                bool isTrue = lives == 0;
                if (isTrue == true)
                {
                    System.Environment.Exit(0);
                }
            }
            else if (keyPressed4.Key == ConsoleKey.DownArrow)
            {
                Console.WriteLine("Blocky grapples you and attacks!");
                lives--;
                bool isTrue = lives == 0;
                if (isTrue == true)
                {
                    System.Environment.Exit(0);
                }
            }
            else if (keyPressed4.Key == ConsoleKey.Spacebar)
            {
                Console.WriteLine("Blocky grapples you and attacks!");
                lives--;
                bool isTrue = lives == 0;
                if (isTrue == true)
                {
                    System.Environment.Exit(0);
                }
            }
            else
            {
                Console.WriteLine("You were indecisive and Blocky hit you");
                lives--;
                bool isTrue = lives == 0;
                if (isTrue == true)
                {
                    System.Environment.Exit(0);
                }
            }


            Console.WriteLine("Lives Left: " + lives);
            Console.WriteLine("Opponent Lives: " + enemyLives);
            Console.WriteLine("Blocky prepares for a fifth attack");
            Console.WriteLine("input dodge");

            ConsoleKeyInfo keyPressed5 = Console.ReadKey();
            // fifth attack
            if (keyPressed5.Key == ConsoleKey.Spacebar)
            {
                Console.WriteLine("Counter attack!");
                Console.WriteLine("You sock Blocky in the jaw");
                enemyLives--;
                bool isTrue = enemyLives == 0;
                if (isTrue == true)
                {
                    Console.WriteLine("VICTORY!");
                    return;
                }
            }
            else if (keyPressed5.Key == ConsoleKey.RightArrow)
            {
                Console.WriteLine("Blocky hits you with a powerful strike to the face!");
                lives--;
                bool isTrue = lives == 0;
                if (isTrue == true)
                {
                    System.Environment.Exit(0);
                }
            }
            else if (keyPressed5.Key == ConsoleKey.DownArrow)
            {
                Console.WriteLine("Blocky hits you with a powerful strike to the face!");
                lives--;
                bool isTrue = lives == 0;
                if (isTrue == true)
                {
                    System.Environment.Exit(0);
                }
            }
            else if (keyPressed5.Key == ConsoleKey.LeftArrow)
            {
                Console.WriteLine("Blocky hits you with a powerful strike to the face!");
                lives--;
                bool isTrue = lives == 0;
                if (isTrue == true)
                {
                    System.Environment.Exit(0);
                }
            }
            else if (keyPressed5.Key == ConsoleKey.UpArrow)
            {
                Console.WriteLine("Blocky hits you with a powerful strike to the face!");
                lives--;
                bool isTrue = lives == 0;
                if (isTrue == true)
                {
                    System.Environment.Exit(0);
                }
            }
            else
            {
                Console.WriteLine("You were indecisive and Blocky hit you");
                lives--;
                bool isTrue = lives == 0;
                if (isTrue == true)
                {
                    System.Environment.Exit(0);
                }
            }
            Console.WriteLine("Lives Left: " + lives);
            Console.WriteLine("Opponent Lives: " + enemyLives);
        }

        private ConsoleKey GiveMeMYButton(int v)
        {
            switch (v)
            {
                case 39:
                    return ConsoleKey.RightArrow;
                case 32:
                    return ConsoleKey.Spacebar;
                case 37:
                    return ConsoleKey.LeftArrow;
                case 38:
                    return ConsoleKey.UpArrow;
                case 40:
                    return ConsoleKey.DownArrow;
                default:
                    Console.WriteLine("???");
                    break;
            }
            return default;
        }
    }
}
