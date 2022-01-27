using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async_Await
{
    public class Kitchen
    {
        SoundPlayer dingFriesAreDone = new SoundPlayer();
        // Always put the word Asyncat the end of an Async method
        // b/c sometimes we can have both synchronous and asynchronous methods
        public async Task<Fries> FryPotatoesAsync(Potato potato)
        {
            // we check if potato is peeled
            if (potato.IsPeeled)
            {
                PrettyPrint("Dropping in the fries.",14);
                // Await is special that
                // we don't want this method to be done completed before moving on to
                // something else,
                await Task.Delay(5000);
                PrettyPrint("Fries are frying",14);
                await Task.Delay(5000);
                PrettyPrint("Ding, Fries are done",14);
                dingFriesAreDone.SoundLocation = @
                dingFriesAreDone.Play;
                return new Fries(potato);
            }
            else
            {
                Console.WriteLine("This Potato isn't peeled.");
                return null;
            }
        }

        public Hamburger AssembleBurger()
        {
            var time = 1000;
            PrettyPrint("Assembling the burger", 13);
            PrettyPrint("Setting the bun down", 4);
            Task.Delay(time).Wait();
            PrettyPrint("Set the patty down gently",12);
            Task.Delay(time).Wait();
            PrettyPrint("Placing down some cheese",14);
            Task.Delay(time).Wait();
            PrettyPrint("Lettuce is there noe",10);
            Task.Delay(time).Wait();
            PrettyPrint("Remember the pickles",2);
            Task.Delay(time).Wait();
            PrettyPrint("Adding the sauce",12);
            Task.Delay(time).Wait();
            PrettyPrint("Slap as bun on there",4);
            PrettyPrint("Burger Assembled!!!",13);
            return new Hamburger();

        }

        public bool ServeMeal(Fries fries, Hamburger hamburger)
        {
            if (fries == null)
            {
                PrettyPrint("The Fries aren't ready", 4);
                return false;
            }
            else
            {
                PrettyPrint("You combine the burger and fries and serve the meal", 15);
                return true;
            }
        }

        // helper method
        public void PrettyPrint(string message, int color)
        {
            //casting to console color
            //Black       0
            //DarkBlue    1
            //DarkGreen   2
            //DarkCyan    3
            //DarkRed     4
            //DarkMagenta 5
            //DarkYellow  6
            //Gray        7
            //DarkGray    8
            //Blue        9
            //Green      10
            //Cyan       11
            //Red        12
            //Magenta    13
            //Yellow     14
            //White      15

            Console.ForegroundColor = (ConsoleColor)color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
