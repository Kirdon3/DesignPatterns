using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DuckCode.FlyBehaviors;

namespace DuckCode.Ducks
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new Quack();
        }

        public void display()
        {
            Console.WriteLine("I'm a model duck");
        }
    }
}
