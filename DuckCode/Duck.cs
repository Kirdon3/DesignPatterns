using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckCode
{
    public abstract class Duck
    {
        protected IFlyBehavior flyBehavior;
        protected IQuackBehavior quackBehavior;

        public Duck()
        {
            
        }

        public void PerformFly()
        {
            flyBehavior.fly();
        }

        public void PerformQuack()
        {
            quackBehavior.quack();
        }

        public void Swim()
        {
            Console.WriteLine("All ducks fly, even decoys!");
        }
    }
}
