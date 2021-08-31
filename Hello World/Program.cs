using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
                // the purpose of the program is to name the ghost that appears

            Console.WriteLine("Hello World!");
            Console.WriteLine(" .-.");
            Console.WriteLine(" (o o)");
            Console.WriteLine(" | O |");
            Console.WriteLine(" |   |");
            Console.WriteLine(" '~~~'");
            Console.WriteLine("Please Press Enter To Continue");
            string enter = Console.ReadLine();
            Console.WriteLine("Please enter a name for the ghost.");
            string name = Console.ReadLine();
            Console.WriteLine($"The ghosts name is {name}");

        // more comments
            // .--.-.--___.._.--.__

            Console.ReadKey();
        }
    }
}
