using System;

namespace Fisticode_Second_Try
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
