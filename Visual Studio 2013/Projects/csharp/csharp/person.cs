using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string name { get; set; }
        public void SayHello(person personal)
        {
            Console.WriteLine("hello, {0} {1}", personal.FirstName, personal.LastName);
        }
        public string SayHello(params string[] names)
        {
            return "hello " + string.Join("\n", names);
          //  StringBuilder build = new StringBuilder();
          //  string temp = "";
          //  foreach (string data in names)
          //  {
          //      build.Append(data + ", ");
          //  }
          // temp = build.ToString();
          // temp = temp.Remove(temp.LastIndexOf(","));
          // //int number = temp.LastIndexOf(",");
          //// temp = temp.Remove(number, 1);
          //string final = "hello " + temp;
          //return final;
        }
        public string SayHello(List<string> names, int num)
        {
            return "hello there " + string.Join(", ", names) + "\ni am number: " + num;
        }
    }
}
