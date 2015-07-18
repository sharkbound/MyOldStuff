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
            string[] names = { "josh", "Daniel", "Melanie", "jack", "\"(im not here go away)\"" };
            List<string> ListNames = new List<string>(names);
            var test = new Dictionary<string,string>();
            test.Add("password", "josh");
           person p = new person();
           string text = p.SayHello(names);
           Console.WriteLine(text);
           Console.ReadKey();
        }
    }
}
