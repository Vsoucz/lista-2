using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2erx11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nota P1: ");
            double p1 = double.Parse(Console.ReadLine());

            // Cálculo: (p1 + 2*p2)/3 >= 5
            double p2 = (15 - p1) / 2;

            if (p2 > 10)
                Console.WriteLine("Impossível atingir média 5");
            else if (p2 < 0)
                Console.WriteLine("Aluno já aprovado");
            else
                Console.WriteLine($"Precisa de {p2:F2} na P2");
        }
    }
}
