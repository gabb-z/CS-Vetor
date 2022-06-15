using System;
using System.Globalization;

namespace Vetor3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu nome completo: ");
            string nomeCompleto = Console.ReadLine();

            Console.Write("Quantos quartos tem na sua casa: ");
            int quartosCasa = int.Parse(Console.ReadLine());

            Console.Write("Digite o preço de um produto: ");
            double precoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite seu último nome, idade e altura: ");
            string[] dados = Console.ReadLine().Split(' ');
            string ultimoNome = dados[0];
            int idade = int.Parse(dados[1]);
            double altura = double.Parse(dados[2], CultureInfo.InvariantCulture);
            Console.WriteLine();

            Console.WriteLine("DADOS DIGITADOS: ");

            Console.WriteLine("\n" + nomeCompleto);
            Console.WriteLine(quartosCasa);
            Console.WriteLine(precoProduto.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(ultimoNome + " " + idade + " " + altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
