using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "( ͡° ͜ʖ ͡°)";
            engine v4 = new engine();
            v4.Size = "v4";
            v4.HorsePower = 200;
            v4.FuelUsageRate = 1.5;

            engine v6 = new engine();
            v6.Size = "v6";
            v6.HorsePower = 350;
            v6.FuelUsageRate = 3.0;
            
            engine v8 = new engine();
            v8.Size = "v8";
            v8.HorsePower = 500;
            v8.FuelUsageRate = 5.0;

            //auto myCar = new auto();
            //myCar.Engine = v8;

            Assembler Robot = new Assembler();
            auto myCar = Robot.carmaker("lexus grand vice", v6);
            Console.WriteLine("Car model: {0}, engine horse power: {1}", myCar.model.ToString(), myCar.Engine.HorsePower.ToString());
            Console.ReadLine();
            myCar.bob.lastname = "tabor";
            myCar.bob.address = "184 evermore st, neverland";
            myCar.bob.dateOfPurchase = DateTime.Now;

            Console.WriteLine("car owner lastname: {0}, owner address: {1}",
                myCar.bob.lastname, myCar.bob.address);
            Console.WriteLine("date of purchase: " + myCar.bob.dateOfPurchase);
            Console.ReadLine();
        }
    }
}
