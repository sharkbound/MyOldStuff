﻿using System;
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
            int currentSpeed = 0;
            int replyAccelerate;
            int replyDecelerate;

            auto mycar = new auto();

            mycar.speed = 0;
            mycar.make = "old smoker v2";
            mycar.year = 1987;
            mycar.color = "yellow";
            mycar.model = "oldee";
            mycar.miles = 10000;

            Console.WriteLine("my cars make::{0}, my cars model::{1}", mycar.make, mycar.model);
            Console.WriteLine("enter amount to speedup by...");
            replyAccelerate = int.Parse(Console.ReadLine());
            Console.WriteLine("enter amount to slowdown by...");
            replyDecelerate = int.Parse(Console.ReadLine());
            
            

            currentSpeed = mycar.accelerate(replyAccelerate);
            currentSpeed = mycar.decelerate(replyDecelerate);

              string message = mycar.speedlimitviolation("encouraging message:  ","warning:  ",20);

            Console.WriteLine("my current speed: {0}  {1}",currentSpeed.ToString(),message);
            
            Console.ReadLine();

        }

    }
}
