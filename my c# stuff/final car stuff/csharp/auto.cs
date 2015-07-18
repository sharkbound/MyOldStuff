using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class auto
    {
        private string make;
        public string model;
        public int year;
        public string color;
        public int miles;
        private int speed;
        public engine Engine;

        public Customer bob = new Customer();
        public class Customer
        {
            public string lastname;
            public string address;
            public DateTime dateOfPurchase;

        }

        public string Make
        {
            get { return make; }
            set {
                switch (value)
                {
                    case "old smoker v2":
                        make = value;
                        break;
                    default:
                        throw new Exception("not correct make");
                }
            }
        }

        public int accelerate(int increase)
        {
            Speed += increase;
            //Console.WriteLine("current speed: {0}", speed.ToString());
            writeLine("current speed:  " + speed);
            return Speed;
        }

        public int decelerate(int decrease)
        {
            Speed -= decrease;
            //Console.WriteLine("current speed: {0}", speed.ToString());
            return Speed;
        }
        
        public string speedlimitviolation(string undermsg,string overmsg,int speedlimit )
        {
            string message = "";
            if (Speed > speedlimit)
                message = overmsg + "going to fast";
            else
                message = undermsg + "your a-ok dude ;)";

            return message;
        }

        public int Speed
        {
            get { return speed; }
            set 
            {
                if (value < 0)
                    speed = 0;
                    
                else if (value > 100)
                    speed = 100;
                else
                    speed = value;
            }
        }

        public void writeLine(string message)
        {
            Console.WriteLine(message);
        }
        public void read()
        {
        Console.ReadLine();
        }
        
    }
}
