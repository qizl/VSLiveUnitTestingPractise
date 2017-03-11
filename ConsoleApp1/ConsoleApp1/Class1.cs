using System;

namespace ConsoleApp1
{
    public class Class1
    {
        private int _i = 10;

        public void SayHello()
        {
            this._i = 0;
            var j = 123 / this._i;

            Console.Write("hello!");
        }

        public void SayHelloAgain()
        {
            Console.Write("hello!");
        }
    }
}
