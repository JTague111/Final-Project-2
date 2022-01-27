using System;

namespace Fisticode_try4
{
    class Program
    {
        static void Main(string[] args)
        {
            Game myGame = new Game();
            myGame.Start();
            Game2 thisGame = new Game2();
            thisGame.Start();
            Game3 thatGame = new Game3();
            thatGame.Start();
            Game4 theirGame = new Game4();
            theirGame.Start();
        }
    }
}
