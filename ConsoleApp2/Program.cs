using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número");
            var numero = int.Parse(Console.ReadLine());
            for (int index = numero; index >= 1; index--)
            {
                Console.WriteLine($"Numero = {index} ");
        
                
            }
            Console.ReadKey();
           
        }
    }
}
