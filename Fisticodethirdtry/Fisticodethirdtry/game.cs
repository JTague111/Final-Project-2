using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fisticodethirdtry
{
    class game
    {
        Console.WriteLine("The game is starting!");
            Console.WriteLine("Press enter to continue");

            ConsoleKeyInfo keyPressed = Console.ReadKey();

            if (keyPressed.Key == ConsoleKey.Enter)
            {
                Console.WriteLine("First opponent =Blocky= ");
            }
            else
            {
                Console.WriteLine("Press enter");
            }

Console.WriteLine("Blocky prepares to hit you");
Console.WriteLine("Input dodge");

if (keyPressed.Key == ConsoleKey.R)
{
    Console.WriteLine("Counter attack!");
    Console.WriteLine("You sock Blocky in the jaw");
}
else if (keyPressed.Key == ConsoleKey.L)
{
    Console.WriteLine("Blocky hits you with a devestating left hook!");
}
else if (keyPressed.Key == ConsoleKey.D)
{
    Console.WriteLine("Blocky hits you with a devestating left hook!");
}
else
{
    Console.WriteLine("You were indecisive and Blocky hit you");
}

Console.ReadKey(true);
    }
}
