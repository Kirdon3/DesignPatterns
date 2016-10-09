using System;

namespace DuckCode
{
    internal class Quack : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("quack");
        }
    }
}