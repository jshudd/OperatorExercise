using System;

namespace OperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 17;
            var b = 4;

            var sum = a + b;
            Console.WriteLine(sum);

            var diff = a - b;
            Console.WriteLine(diff);

            var mult = a * b;
            Console.WriteLine(mult);

            var quotient = a / b;
            Console.WriteLine(quotient);

            var remainder = a % b;
            Console.WriteLine(remainder);
        }
    }
}
