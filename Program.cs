using System;

namespace net_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TypedAntenna a = new TypedAntenna(10, "plastic", 400, "toroida");
            a.printInfo();
        }
    }
}
