using System;
using System.Globalization;

namespace Vetor2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            double[] vetor;

            N = int.Parse(Console.ReadLine());
            vetor = new double[N];
            string[] s = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {
                vetor[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
            }

            for (int i = 0; i < N; i++)
            {
                Console.Write(vetor[i].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }

            Console.WriteLine();

            double soma = 0.0;

            for (int i = 0; i < N; i++)
            {
                soma += vetor[i];
            }

            double media = soma / N;

            Console.WriteLine(soma.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
