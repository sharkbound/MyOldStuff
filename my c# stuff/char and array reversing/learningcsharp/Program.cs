using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace learningcsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Deleting System32....";
            string broadcast = "!nwot ni wohs tseb eht ot lla emoc eno emoc";
            char[] chararray = broadcast.ToCharArray();
            Array.Reverse(chararray);
            Console.WriteLine(chararray);
            Console.ReadLine();

        } 
    }
}