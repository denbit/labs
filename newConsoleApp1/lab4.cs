using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace newConsoleApp1
{
    abstract class Point
    {
        public abstract void Print();
        public abstract bool MoveTo(double[] coord);
        public abstract bool Scale(int rate);
    }
    class Triange : Point
    {
        public override bool MoveTo(double[] coord)
        {
            throw new NotImplementedException();
        }

        public override void Print()
        {
            throw new NotImplementedException();
        }

        public override bool Scale(int rate)
        {
            throw new NotImplementedException();
        }
    }
    class Rectangle : Point
    {
        public override bool MoveTo(double[] coord)
        {
            throw new NotImplementedException();
        }

        public override void Print()
        {
            throw new NotImplementedException();
        }

        public override bool Scale(int rate)
        {
            throw new NotImplementedException();
        }
    }

    class lab4
    {
    }
  
}
