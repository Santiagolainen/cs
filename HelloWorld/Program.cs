using System;
using System.Linq;

namespace HelloWorld
{
    class Program
    {
        class Car {

            public string model;

            public Car(string modelName) {
                model = modelName;
            }

            static void Main(string[] args) {
                Car Ford = new Car("Mustang");
                Car Toyota = new Car("Yaris");
                Console.WriteLine(Ford.model);
                Console.WriteLine(Toyota.model);
            }
        }

    }
}
