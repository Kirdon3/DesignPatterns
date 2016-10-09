using System;

namespace DuckCode
{
    internal class FlyWithWings : IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I'm flying!");
        }
    }
}