using System;

namespace Challenge_1_Take_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var menu = new Menu(1, "Steak&Eggs", "Medium rare Steak with sunny side eggs", "Steak, Eggs", 12);
            Console.WriteLine(menu.Number);
            Console.WriteLine(menu.Name);
            Console.WriteLine(menu.Description);
            Console.WriteLine(menu.Ingredients);
            Console.WriteLine(menu.Price);
        }
    }
}
