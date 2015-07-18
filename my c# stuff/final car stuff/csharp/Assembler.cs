using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    class Assembler
    {
        public auto carmaker(string model, engine engineType)
        {
            auto newCar = new auto();
            newCar.model = model;
            newCar.Engine = engineType;

            return newCar;
        }
    }
}
