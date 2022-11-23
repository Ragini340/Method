using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    abstract class Bike
    {
        //Anyone can call this
        public void StartEngine() { }

        //Only derived classes can call this
        protected void AddGas(int v) { }

        //Derived classes can override the base class implementation
        public virtual int Drive(int miles, int speed)
        {
            return 1;
        }

        //Derived classes must implement this
        public abstract double GetToSpeed();
    }
}

