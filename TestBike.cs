using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class TestBike : Bike
    {
        
        public override double GetToSpeed()
        {
            return 100;
        }
        static void Main()
        {

           TestBike obj = new TestBike();

            obj.StartEngine();
            obj.AddGas(15);
            obj.Drive(5, 20);
            double speed = obj.GetToSpeed();
            Console.WriteLine("Top speed is {0}", speed);
        }
    }
}

   