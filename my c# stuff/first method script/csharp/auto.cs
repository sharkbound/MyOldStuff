using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class auto
    {
        public string make;
        public string model;
        public int year;
        public string color;
        public int miles;
        public int speed;

        public int accelerate(int increase)
        {
            speed += increase;
            //Console.WriteLine("current speed: {0}", speed.ToString());
            return speed;
        }

        public int decelerate(int decrease)
        {
            speed -= decrease;
            //Console.WriteLine("current speed: {0}", speed.ToString());
            return speed;
        }
        
        public string speedlimitviolation(string undermsg,string overmsg,int speedlimit )
        {
            string message = "";
            if (speed > speedlimit)
                message = overmsg + "going to fast";
            else if (speed < 0)
                message = "how is it possible to go " + speed + " miles?!?!!?";

            else
                message = undermsg + "your a-ok dude ;)";

            return message;
        }
        

    }
}
