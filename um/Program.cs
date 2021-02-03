using System;

namespace um
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] km = Console.ReadLine().Split(" ");

            int horas = Int32.Parse(km[0]);
            int velocidade = Int32.Parse(km[1]);

            double autonomia= 12;
            double litro = (horas * velocidade);
            double total = litro / autonomia;

            Console.WriteLine(total.ToString("N3"));

        }
    }
}
