using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2exr1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite o primeiro numero:");
            var numero1 =
            int.Parse(Console.ReadLine());

            Console.WriteLine("digite o segundo numero");
            int numero2 =
            int.Parse(Console.ReadLine());

            if (numero1 != numero2)
            {
                Console.WriteLine("o maior numero é: " + (numero1 > numero2 ? numero1 : numero2));
            }
        }
    }
}
