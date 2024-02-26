using System;
using System.Linq;

namespace HelloWorld
{
    class Program
    {
       static void Main(string[] args)
        {
            Car Ford = new Car("Mustang", 1994, "red");
            Car Toyota = new Car("Yaris", 2015, "white");

            Console.WriteLine(Ford.model);
            Console.WriteLine(Toyota.model);
            Console.WriteLine(Ford.year);
            Console.WriteLine(Toyota.year);
            Console.WriteLine(Ford.color);
            Console.WriteLine(Toyota.color);
        }

    }
}
