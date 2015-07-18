using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo info;
            Console.TreatControlCAsInput = true;
            person p = new person();
            List<string> namelist = new List<string>() { "jane", "joe", "james", "juliet" };
            namelist.Add("Daniel");
            namelist.Reverse();
            Console.WriteLine(p.SayHello(namelist, 1));
            do
            {
                info = Console.ReadKey();
                Console.WriteLine("  ------- you pressed: {0}, modifiers pressed: {1}", info.Key.ToString(), info.Modifiers);
            } while (info.Key != ConsoleKey.Escape);

        }
    }
}
