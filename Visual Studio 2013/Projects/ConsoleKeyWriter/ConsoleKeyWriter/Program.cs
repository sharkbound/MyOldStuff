using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleKeyWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo key;
            Console.TreatControlCAsInput = true;
            Console.WriteLine("press any key or press ctl, shift or alt + a key...");
            do
            {
                key = Console.ReadKey();
                Console.Write(" --- you pressed ");
                if ((key.Modifiers & ConsoleModifiers.Alt) != 0)
                {
                    Console.Write("Alt+");
                }
                if ((key.Modifiers & ConsoleModifiers.Shift) != 0)
                {
                    Console.Write("Shift+");
                }
                if ((key.Modifiers & ConsoleModifiers.Control) != 0)
                {
                    Console.Write("Ctl+");
                }
                Console.WriteLine(key.Key.ToString());
            } while (key.Key != ConsoleKey.Escape);
        }
    }
}
