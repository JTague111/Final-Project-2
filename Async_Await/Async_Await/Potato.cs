using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async_Await
{
    public class Potato
    {
        public bool IsPeeled { get; set; }
        public Potato() { }
        public Potato(bool isPeeled)
        {
            IsPeeled = isPeeled;
        }

        // synchronous method
        public bool Peel()
        {
            Console.WriteLine("You start peeling the potato");
            // we want to simulate peeling the potato
            Task.Delay(3000).Wait();
            Console.WriteLine("You peeled the potato.");
            return true;
        }
    }
}
