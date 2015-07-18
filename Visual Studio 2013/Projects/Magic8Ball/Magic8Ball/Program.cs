using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Magic8Ball
{
    class Program
    {
        static void Main(string[] args)
        {
            int good = 0,
                bad = 0,
                maybe = 0;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to my Magic8Ball application!");
            bool loop = true;
            WhileLoop:
            #region While Loop
            while (loop == true)
            {
                loop = false;
                Console.WriteLine("Please enter your question...\nThen press enter/return!");
                Console.ForegroundColor = ConsoleColor.Cyan;
                string question = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Green;
                if (string.IsNullOrEmpty(question) == true || string.IsNullOrWhiteSpace(question) == true)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Le sigh.. enter a question this time plz\n And while your at it give me money cause this definity isnt begging");
                    for (int i = 1; i < 10; i++)
                    {
                        if (Console.ForegroundColor != ConsoleColor.Red)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        Console.WriteLine("HAHAHAHAHAHAHAHHAHAHAHAHAHHAHAHAA");
                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    goto WhileLoop;
                }
                if (string.IsNullOrEmpty(question) == false)
                {
                reroll:
                    Console.WriteLine("your question was: {0}", question);
                    Console.WriteLine("i am calculating your awnser...");
                    Thread.Sleep(1500);
                    Random RandomReply = new Random();
                    int RandomNumber = RandomReply.Next(17);
                    switch (RandomNumber)
                    {
                        case 0:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("NOPE NOPE NOPE AND NOPE!");
                            Console.ForegroundColor = ConsoleColor.Green;
                            bad++;
                            break;
                        case 1:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Illuminati says: Yes, with a illuminati on top");
                            Console.ForegroundColor = ConsoleColor.Green;
                            good++;
                            break;
                        case 2:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Never gonna give you up\nNever gonna let you down\nNever gonna run around and desert you\n");
                            Console.WriteLine("Never gonna make you cry\nNever gonna say goodbye\nNever gonna tell a lie and hurt you");
                            Console.WriteLine("so basically the awnser is no");
                            Console.ForegroundColor = ConsoleColor.Green;
                            bad++;
                            break;
                        case 3:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("YOU SHALL NOT PASS ME TO GET TO YES (no)");
                            Console.ForegroundColor = ConsoleColor.Green;
                            bad++;
                            break;
                        case 4:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("dude, definity no, why would u even ask me dat bro!?!?!?");
                            Console.ForegroundColor = ConsoleColor.Green;
                            bad++;
                            break;
                        case 5:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("possibly brah, possible");
                            Console.ForegroundColor = ConsoleColor.Green;
                            maybe++;
                            break;
                        case 6:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Pikkkaaaaa, pikaaachu! Translation:\"PIkachu says: maybe\"");
                            Console.ForegroundColor = ConsoleColor.Green;
                            maybe++;
                            break;
                        case 7:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("this was a triumph, Im making a note here \"huge success\"\t (yes)");
                            Console.ForegroundColor = ConsoleColor.Green;
                            good++;
                            break;
                        case 8:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("thats a stupid question, NO");
                            Console.ForegroundColor = ConsoleColor.Green;
                            bad++;
                            break;
                        case 9:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("your face is ugly, NO");
                            Console.ForegroundColor = ConsoleColor.Green;
                            bad++;
                            break;
                        case 10:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("i love your shoes, YES");
                            Console.ForegroundColor = ConsoleColor.Green;
                            good++;
                            break;
                        case 11:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("*bro fist*, YES");
                            Console.ForegroundColor = ConsoleColor.Green;
                            good++;
                            break;
                        case 12:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("its quite possible, but then again... yea still possible!");
                            Console.ForegroundColor = ConsoleColor.Green;
                            maybe++;
                            break;
                        case 13:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("one does not simply say no, (yes)");
                            Console.ForegroundColor = ConsoleColor.Green;
                            good++;
                            break;
                        case 14:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("The future is not written, your chances are good! (possibly)");
                            Console.ForegroundColor = ConsoleColor.Green;
                            maybe++;
                            break;
                        case 15:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("The great Gandolf says no");
                            Console.ForegroundColor = ConsoleColor.Green;
                            bad++;
                            break;
                        case 16:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("The creepy guy behind you says yes");
                            Console.ForegroundColor = ConsoleColor.Green;
                            good++;
                            break;
                    }
                 exitConfirm:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Would u like to exit the application? enter [y/n]\n or enter r to reroll the question!\n Or enter l to see all the results so far!");
                    Console.ForegroundColor = ConsoleColor.Green;
                    ConsoleKeyInfo yesOrNo = Console.ReadKey();
                    Console.WriteLine(string.Empty);
                    if (yesOrNo.Key == ConsoleKey.Y)
                    {
                        goto end;
                    }
                    else if (yesOrNo.Key == ConsoleKey.N)
                    {
                        loop = true;
                        goto WhileLoop;
                    }
                    else if (yesOrNo.Key == ConsoleKey.R)
                    {
                        goto reroll;
                    }
                    else if (yesOrNo.Key == ConsoleKey.L)
                    {
                        Console.WriteLine("maybe: {0}\tyes's: {1}\tNo's: {2}", maybe, good, bad);
                        goto exitConfirm;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("please enter a valid selection...");
                        Console.ForegroundColor = ConsoleColor.Green;
                        goto exitConfirm;
                    }
                }
            }
            #endregion
        end:
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("press any key to exit the application...");
        Console.ReadKey();
        
        }
    }
}
