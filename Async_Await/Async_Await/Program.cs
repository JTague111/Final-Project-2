using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async_Await
{
    class Program
    {
        static async Task  Main(string[] args)
        {
            Console.WriteLine("Press a key to create a meal.");
            Console.ReadKey();

            Kitchen kitchen = new Kitchen();

            Potato potato = new Potato();
            potato.Peel();

            var fries = await kitchen.FryPotatoesAsync(potato);

            var hamburger = kitchen.AssembleBurger();


            kitchen.ServeMeal(fries, hamburger);
            Console.ReadKey();
        }
    }
}
