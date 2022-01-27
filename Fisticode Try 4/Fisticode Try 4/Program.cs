using System;

namespace Fisticode_Try_4
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
        }
    }
}
