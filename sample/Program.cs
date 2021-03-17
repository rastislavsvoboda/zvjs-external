using System;

namespace sample
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = new sample.lib.Class1();
            Console.WriteLine($"Hello World! ver {x.Version}");
        }
    }
}
