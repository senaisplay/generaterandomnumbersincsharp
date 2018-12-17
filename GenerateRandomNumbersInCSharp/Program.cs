using System;

namespace GenerateRandomNumbersInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            // This variable holds the random number
            var randomNumber = random.Next();
            Console.WriteLine(randomNumber);
        }
    }
}
