using System;

namespace pokemonBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            //testing access to variable definitions
            int explicitVariable = 10;
            Console.WriteLine(explicitVariable.GetType()); // prints System.String
            var implicitVariable = 20;
            // Console.WriteLine(implicitVariable.GetType()); // prints System.String
            // implicitVariable = "Carlitos";
            // Console.WriteLine(implicitVariable.GetType()); // prints System.String

            //Math
            int firstValue = 10, secondValue = 5;                       
            double pi = 3.14;
            Console.WriteLine("addition: " + firstValue + secondValue);

            Console.WriteLine("Substraction: " + (firstValue - secondValue));

            Console.WriteLine("product: " + firstValue * secondValue);

            Console.WriteLine("divide: " + firstValue / secondValue);

            Console.WriteLine($"Module {firstValue}" + firstValue % secondValue);

            Console.WriteLine(256*2);

        }
    }
}
