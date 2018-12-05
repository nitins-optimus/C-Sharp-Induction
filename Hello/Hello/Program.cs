using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name");
            String name = Console.ReadLine();

            Console.WriteLine("Hello, " + name);

            Console.WriteLine("Hours of sleep u had?");

            int hrsOfSleep = int.Parse( Console.ReadLine());

            if(hrsOfSleep > 8)
            {
                Console.WriteLine("U had a good sleep");
            } else
            {
                Console.WriteLine("Take rest");
            }



        }
    }
}
