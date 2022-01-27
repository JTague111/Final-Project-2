using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Fisticode_try4
{
    class Game4
    {
        public void Start()
        {
            ConsoleKey KeyToPress = 0;
            ConsoleKey KeyToPress1 = 0;
            ConsoleKey KeyToPress2 = 0;
            ConsoleKey KeyToPress3 = 0;
            ConsoleKey KeyToPress4 = 0;

            int lives = 3;
            int enemyLives = 3;
            int[] Buttons = new int[] { 39, 40, 38, 37, 32 };
            Random rnd = new Random();
            Thread.Sleep(15);
            var randomNumber = rnd.Next(0, 5);
            for (int i = 0; i < Buttons.Length; i++)
            {
                if (Buttons[randomNumber] == Buttons[i])
                {
                    KeyToPress = GiveMeMYButton(Buttons[i]);
                }
            }
            int[] Buttons1 = new int[] { 39, 40, 38, 37, 32 };
            Random rnd1 = new Random();
            Thread.Sleep(15);
            var randomNumber1 = rnd1.Next(0, 5);
            for (int i = 0; i < Buttons1.Length; i++)
            {
                if (Buttons1[randomNumber1] == Buttons1[i])
                {
                    KeyToPress1 = GiveMeThatButton(Buttons1[i]);
                }
            }
            int[] Buttons2 = new int[] { 39, 40, 38, 37, 32 };
            Random rnd2 = new Random();
            Thread.Sleep(15);
            var randomNumber2 = rnd2.Next(0, 5);
            for (int i = 0; i < Buttons1.Length; i++)
            {
                if (Buttons2[randomNumber2] == Buttons2[i])
                {
                    KeyToPress2 = GiveMeThoseButtons(Buttons2[i]);
                }
            }
            int[] Buttons3 = new int[] { 39, 40, 38, 37, 32 };
            Random rnd3 = new Random();
            Thread.Sleep(15);
            var randomNumber3 = rnd3.Next(0, 5);
            for (int i = 0; i < Buttons3.Length; i++)
            {
                if (Buttons3[randomNumber3] == Buttons3[i])
                {
                    KeyToPress3 = GiveMeTheirButton(Buttons3[i]);
                }
            }
            int[] Buttons4 = new int[] { 39, 40, 38, 37, 32 };
            Random rnd4 = new Random();
            Thread.Sleep(15);
            var randomNumber4 = rnd4.Next(0, 5);
            for (int i = 0; i < Buttons4.Length; i++)
            {
                if (Buttons4[randomNumber4] == Buttons4[i])
                {
                    KeyToPress4 = GiveMeHisButton(Buttons4[i]);
                }
            }
            //switch (randomNumber)
            //{
            //    default:
            //}
            Console.WriteLine("Final opponent");
            Console.WriteLine("=Mike Typeson=");
            Console.WriteLine("Lives Left: " + lives);
            Console.WriteLine("Opponent Lives: " + enemyLives);
            Console.WriteLine("Mike reels back for an attack");
            Console.WriteLine("Input dodge");
            // First Attack
            ConsoleKeyInfo keyPressed = Console.ReadKey();
            if (keyPressed.Key == KeyToPress) //ConsoleKey.RightArrow
            {

                Console.WriteLine("Counter attack!");
                Console.WriteLine("You manage to get a blow in against Mike");
                enemyLives--;
            }
            else
            {
                Console.WriteLine("Mike knocks the wind out of you with a strong jab");
                lives--;
            }

            Console.WriteLine("Lives Left: " + lives);
            Console.WriteLine("Opponent Lives: " + enemyLives);
            Console.WriteLine("Mike gets into a fighting stance");
            Console.WriteLine("input dodge");


            // Second Attack
            ConsoleKeyInfo keyPressed1 = Console.ReadKey();
            if (keyPressed1.Key == KeyToPress1)
            {
                Console.WriteLine("Counter attack!");
                Console.WriteLine("You narrowly avoid the hit and get a strike in");
                enemyLives--;
            }
            else
            {
                Console.WriteLine("Mike uppercuts you and hits out your mouthguard");
                lives--;
            }

            Console.WriteLine("Lives Left: " + lives);
            Console.WriteLine("Opponent Lives: " + enemyLives);
            Console.WriteLine("Mike comes at you with terrifying speed");
            Console.WriteLine("input dodge");

            // third attack
            ConsoleKeyInfo keyPressed2 = Console.ReadKey();
            if (keyPressed2.Key == KeyToPress2)
            {
                Console.WriteLine("Counter attack!");
                Console.WriteLine("Mike swings wide and you dodge behind him for an attack");
                enemyLives--;
                bool isTrue = enemyLives == 0;
                if (isTrue == true)
                {
                    Console.Clear();
                    Console.WriteLine("#     # ###  #####  ####### ####### ######  #     #      ##          #         #   ##                      ");
                    Console.WriteLine("#     #  #  #     #    #    #     # #     #  #   #      #    ####   # #       # #    #               ####  ");
                    Console.WriteLine("#     #  #  #          #    #     # #     #   # #      #    #    # #   #     #   #    #             #    # ");
                    Console.WriteLine("#     #  #  #          #    #     # ######     #       #    #    #                    # ##### ##### #    # ");
                    Console.WriteLine(" #   #   #  #          #    #     # #   #      #       #    #    #                    #             #    # ");
                    Console.WriteLine("  # #    #  #     #    #    #     # #    #     #        #   #    #       ###         #              #    # ");
                    Console.WriteLine("   #    ###  #####     #    ####### #     #    #         ##  ####        ###       ##                ####  ");
                    Console.ReadKey();
                    return;
                }
            }
            else if (keyPressed2.Key == ConsoleKey.Q)
            {
                return;
            }
            else
            {
                Console.WriteLine("He slams into you like a freight train");
                lives--;
                bool isTrue = lives == 0;
                if (isTrue == true)
                {
                    Console.Clear();
                    Console.WriteLine("\n\n");
                    Console.WriteLine(" #####     #    #     # #######    ####### #     # ####### ######         #       #        ");
                    Console.WriteLine("#     #   # #   ##   ## #          #     # #     # #       #     #        #       #        ");
                    Console.WriteLine("#        #   #  # # # # #          #     # #     # #       #     #                         ");
                    Console.WriteLine("#  #### #     # #  #  # #####      #     # #     # #####   ######                          ");
                    Console.WriteLine("#     # ####### #     # #          #     #  #   #  #       #   #        #############      ");
                    Console.WriteLine("#     # #     # #     # #          #     #   # #   #       #    #       #           #      ");
                    Console.WriteLine(" #####  #     # #     # #######    #######    #    ####### #     #      #           #      ");
                    Console.ReadKey();
                    System.Environment.Exit(0);
                }
            }

            Console.WriteLine("Lives Left: " + lives);
            Console.WriteLine("Opponent Lives: " + enemyLives);
            Console.WriteLine("undeterred, Mike attacks with full force ");
            Console.WriteLine("input dodge");

            // fourth attack
            ConsoleKeyInfo keyPressed3 = Console.ReadKey();
            if (keyPressed3.Key == KeyToPress3)
            {
                Console.WriteLine("Counter attack!");
                Console.WriteLine("You barely manage to dodge the flurry of attacks and get a hit in");
                enemyLives--;
                bool isTrue = enemyLives == 0;
                if (isTrue == true)
                {
                    Console.Clear();
                    Console.WriteLine("#     # ###  #####  ####### ####### ######  #     #      ##          #         #   ##                      ");
                    Console.WriteLine("#     #  #  #     #    #    #     # #     #  #   #      #    ####   # #       # #    #               ####  ");
                    Console.WriteLine("#     #  #  #          #    #     # #     #   # #      #    #    # #   #     #   #    #             #    # ");
                    Console.WriteLine("#     #  #  #          #    #     # ######     #       #    #    #                    # ##### ##### #    # ");
                    Console.WriteLine(" #   #   #  #          #    #     # #   #      #       #    #    #                    #             #    # ");
                    Console.WriteLine("  # #    #  #     #    #    #     # #    #     #        #   #    #       ###         #              #    # ");
                    Console.WriteLine("   #    ###  #####     #    ####### #     #    #         ##  ####        ###       ##                ####  ");
                    Console.ReadKey();
                    return;
                }
            }
            else
            {
                Console.WriteLine("Mike hits you with a devastating flurry of blows");
                lives--;
                bool isTrue = lives == 0;
                if (isTrue == true)
                {
                    Console.Clear();
                    Console.WriteLine("\n\n");
                    Console.WriteLine(" #####     #    #     # #######    ####### #     # ####### ######         #       #        ");
                    Console.WriteLine("#     #   # #   ##   ## #          #     # #     # #       #     #        #       #        ");
                    Console.WriteLine("#        #   #  # # # # #          #     # #     # #       #     #                         ");
                    Console.WriteLine("#  #### #     # #  #  # #####      #     # #     # #####   ######                          ");
                    Console.WriteLine("#     # ####### #     # #          #     #  #   #  #       #   #        #############      ");
                    Console.WriteLine("#     # #     # #     # #          #     #   # #   #       #    #       #           #      ");
                    Console.WriteLine(" #####  #     # #     # #######    #######    #    ####### #     #      #           #      ");
                    Console.ReadKey();
                    System.Environment.Exit(0);
                }
            }


            Console.WriteLine("Lives Left: " + lives);
            Console.WriteLine("Opponent Lives: " + enemyLives);
            Console.WriteLine("on equal footing Mike faces you for the final time");
            Console.WriteLine("input dodge");

            // fifth attack
            ConsoleKeyInfo keyPressed4 = Console.ReadKey();
            if (keyPressed4.Key == KeyToPress4)
            {
                Console.WriteLine("Counter attack!");
                Console.WriteLine("You fight like one possesed and at the end you stand over the defeated Mike Typeson");
                enemyLives--;
                bool isTrue = enemyLives == 0;
                if (isTrue == true)
                {
                    Console.Clear();
                    Console.WriteLine("#     # ###  #####  ####### ####### ######  #     #      ##          #         #   ##                      ");
                    Console.WriteLine("#     #  #  #     #    #    #     # #     #  #   #      #    ####   # #       # #    #               ####  ");
                    Console.WriteLine("#     #  #  #          #    #     # #     #   # #      #    #    # #   #     #   #    #             #    # ");
                    Console.WriteLine("#     #  #  #          #    #     # ######     #       #    #    #                    # ##### ##### #    # ");
                    Console.WriteLine(" #   #   #  #          #    #     # #   #      #       #    #    #                    #             #    # ");
                    Console.WriteLine("  # #    #  #     #    #    #     # #    #     #        #   #    #       ###         #              #    # ");
                    Console.WriteLine("   #    ###  #####     #    ####### #     #    #         ##  ####        ###       ##                ####  ");
                    Console.ReadKey();
                    return;
                }
            }
            else
            {
                Console.WriteLine("With both of you beaten and bloody, the round ends when you finally faint from your bout.");
                Console.WriteLine("Having earned Mike Typeson's respect he comes to visit you while your recovering.");
                lives--;
                bool isTrue = lives == 0;
                if (isTrue == true)
                {
                    Console.Clear();
                    Console.WriteLine("\n\n");
                    Console.WriteLine(" #####     #    #     # #######    ####### #     # ####### ######         #       #        ");
                    Console.WriteLine("#     #   # #   ##   ## #          #     # #     # #       #     #        #       #        ");
                    Console.WriteLine("#        #   #  # # # # #          #     # #     # #       #     #                         ");
                    Console.WriteLine("#  #### #     # #  #  # #####      #     # #     # #####   ######                          ");
                    Console.WriteLine("#     # ####### #     # #          #     #  #   #  #       #   #        #############      ");
                    Console.WriteLine("#     # #     # #     # #          #     #   # #   #       #    #       #           #      ");
                    Console.WriteLine(" #####  #     # #     # #######    #######    #    ####### #     #      #           #      ");
                    Console.ReadKey();
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
        private ConsoleKey GiveMeThatButton(int v)
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
        private ConsoleKey GiveMeThoseButtons(int v)
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
        private ConsoleKey GiveMeTheirButton(int v)
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
        private ConsoleKey GiveMeHisButton(int v)
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
