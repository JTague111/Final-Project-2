using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fisticode_try_5
{
    class Game
    {
        private int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        public void Start()
        {
            ConsoleKeyInfo keyPressed = ReadKey();
            int ReturnValue = RandomNumber(1, 5);
            string 1 = KeyPressed.Key == ConsoleKey.Enter;

            if(1)
            {

            }
        }
    }
}
