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
            person p = new person();
           string text = p.SayHello("josh", "Daniel", "Melanie","jack","\"(im not here go away)\"");
           Console.WriteLine(text);
           Console.ReadKey();
        }
    }
}
