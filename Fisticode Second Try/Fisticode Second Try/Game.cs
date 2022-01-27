using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fisticode_Second_Try
{
    class Game
    {
        public void  Start()
        {
            Console.WriteLine("         #######    ###     #####     #######    ###              #####     #######    ######     ####### ");
            Console.WriteLine("         #           #     #     #       #        #              #     #    #     #    #     #    #       ");
            Console.WriteLine("         #           #     #             #        #     #####    #          #     #    #     #    #       ");
            Console.WriteLine("         #####       #      #####        #        #              #          #     #    #     #    #####   ");
            Console.WriteLine("         #           #           #       #        #     #####    #          #     #    #     #    #       ");
            Console.WriteLine("         #           #     #     #       #        #              #     #    #     #    #     #    #       ");
            Console.WriteLine("         #          ###     #####        #       ###              #####     #######    ######     ####### ");
            Console.WriteLine("========================================================================================================================\n\n\n");
            Console.WriteLine("           Weighing in at 64 bytes and standing at a whopping 20 lines of code, our challenger CONSWOLE!!!");
            Console.WriteLine("           Fight through 2 expeienced boxers before you face the undefeated Keyboard Champion of the Computer,                                                                       MIKE TYPSON!!!");
            Console.WriteLine("           Your opponents will try to hit you with one of three attacks, and its up to you to guess the right dodge");
            Console.WriteLine("           your options are to type right, or duck into the console. Be careful though, while the first two fighters                                             might be easy, Mike is a force to be reckoned with. ");
            Console.WriteLine("           You and your opponent will each recieve three lives at the beginning of the bout so make sure to figure                                                             out their moves fast.");
            Console.WriteLine("                         Now, without further ado, press enter to face you first opponent Blocky.");
            ConsoleKeyInfo keyPressed = Console.ReadKey();

            if (keyPressed.Key == ConsoleKey.Enter)
            {
                Console.WriteLine("First opponent =Blocky= ");
            }
            else
            {
                Console.WriteLine("Press enter");
            }
            Console.ReadKey(true);
        }
    }
}
