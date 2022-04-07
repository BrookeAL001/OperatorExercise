using System;

namespace OperatorExercise
{
    class Program
    {
        public static void Main(string[] args)
        {
            var a = 17;
            var b = 4;

            var div = a / b;
            var mod = a % b;

            Console.WriteLine($"{a}/{b} is {div} remainder {mod}");

            var r = 20;
            var pi = Math.PI;

            var areaOfCircle = pi * (r * r);

            if (a == 17 && b == 4)

            { Console.WriteLine($"The area of a circle with a radius of {r} is {areaOfCircle}"); }
        }

    }
}
