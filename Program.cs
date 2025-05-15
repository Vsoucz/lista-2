using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2erx3
{
    internal class Program
    {
        private const string V = " o maior numero é:";

        static void Main(string[] args)
        {
            Console.WriteLine("digite o primeiro numero");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("digite o segundo numero");
            int numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("digite o terceiro numero");
            int numero3 = int.Parse(Console.ReadLine());

            int maior = Math.Max(numero1,
            Math.Max(numero2, numero3));
            Console.WriteLine("o numero maior é´:" + maior);

        }
    }
}
