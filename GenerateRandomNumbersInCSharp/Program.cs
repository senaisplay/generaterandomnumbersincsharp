using System;

namespace GenerateRandomNumbersInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var messages = new[]
            {
                "Olá, como vai você?",
                "Em que podemos ajudá-lo?",
                "Precisa de alguma ajuda?",
            };
            var random = new Random();
            var message = messages[random.Next(0, messages.Length)];
            Console.WriteLine(message);
        }
    }
}
