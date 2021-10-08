using System;

namespace GitExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva sua mensagem: ");
            string input = Console.ReadLine();
            Console.WriteLine($"Sua mensagem {input}");
            Console.ReadKey()
        }
    }
}
