using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ProgramUI
    {
        public void RunMainMenu()
        {
            int response = int.Parse(Console.ReadLine());
            switch (response)
            {
                case 1:
                    Console.WriteLine("I pressed 1");
                    break;
                case 2:
                    Console.WriteLine("I pressed 2");
                    break;
                default:
                    Console.WriteLine("enter a valid response.");
                    break;

            }
        }
    }
}
