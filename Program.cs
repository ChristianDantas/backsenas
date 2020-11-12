using System;

namespace projeto1
{
    class Program
    {
        static void Main(string[] args)
        {
      Console.WriteLine("digite o primeiro número: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("digite o segundo número: ");
            int n2 = int.Parse(Console.ReadLine());
            int soma = n1 + n2;
            Console.WriteLine("resultado= " + soma);
        }
    }
}
