using System;

namespace IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, p, i;
            
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n=== Índice de Massa Corporal ===\n");
            Console.ResetColor();

            Console.WriteLine("Indique a altura em metros e o\npeso em kg, para calcular o IMC.\n");

            Console.Write("Altura...: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Peso.....: ");
            p = Convert.ToDouble(Console.ReadLine());

            i = p / Math.Pow(a, 2);

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\n=== IMC ===\n");
            Console.ResetColor();

            Console.WriteLine($"IMC......: {i:N1} kg/m²\n");

        }
    }
}
