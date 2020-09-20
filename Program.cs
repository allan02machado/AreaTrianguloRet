using System;

namespace AreaTrianguloRet
{
    class Program
    {
        static void Main(string[] args)
        {
            double primeiroNumero;
            double segundoNumero;
            const double terceiroNumero = 2;

            Console.WriteLine("Bem-vindo ao calcula triângulo retângulo");
            Console.WriteLine("Pressione uma tecla para continuar...");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Digite os valores a serem calculados: ");

            Console.Write("1o. numero: ");
            primeiroNumero = Convert.ToDouble(Console.ReadLine());

            Console.Write("2o. numero: ");
            segundoNumero = Convert.ToDouble(Console.ReadLine());

            double resultado = (primeiroNumero * segundoNumero) / terceiroNumero;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"O resultado é {resultado:N1}");
            Console.ResetColor();

        }
    }
}
