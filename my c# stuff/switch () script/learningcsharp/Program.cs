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
            Console.WriteLine("Decide your fate!");
            Console.WriteLine("enter 1, 2 or 3");
            string reply = Console.ReadLine();
            string msg = "";
            switch (reply)
            {
                case "1":
                    msg ="u have won a whale!";
                    break;
                case "2":
                    msg = "u have won a nuke!";
                    break;
                case "3":
                    msg = "u have won a trip to paris";
                    break;
                case "1337":
                    msg = "u really are persistant in looking for us arnt u, well anyway we have special plans for u!";
                    break;
                default:
                    msg ="that is not a valid awnser, try again!";
                    break;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(msg);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("press any key to terminate the application...");
            Console.ReadLine();


        } 
    }
}