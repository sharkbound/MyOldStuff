using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learningcsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("type your name then press return");
            string UserValue;
            UserValue = Console.ReadLine();
            Console.WriteLine("u entered:" + UserValue);
            Console.WriteLine("if this is correct type yes, if not type no");
            string userReply = Console.ReadLine();
            if ((userReply == "1337") && (UserValue == "l33t"))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("********************************************************************************");
                Console.WriteLine("                              <   illuminati     >                   ");
                Console.WriteLine("********************************************************************************");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("I see u have found out a secret, we have special plans for u, MAHAHAHAHAHAHA");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("********************************************************************************");
                Console.WriteLine("                               </  illuminati       >                 ");
                Console.WriteLine("********************************************************************************");
            }
            else if (userReply == "yes")
            {
                Console.WriteLine("u have entered it correctly");
            }
            
            else if (userReply == "no")
            {
                Console.WriteLine("u entered wrong");
            }
            
            else if (userReply == "1337")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("welcome back {0}, the meeting is about to begin", UserValue);
            }
            else
            {
                Console.WriteLine("{0} is a invalid value", userReply);
            }
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("press any key to terminate application...");
            Console.ReadLine();

            }
    }
}