using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_10
{
    class Program
    {
        static decimal primeiraNota = 1;
        static decimal segundaNota = 1;

        static int frequencia = 1;
        static void Main(string[] args)
        {
            Console.WriteLine("Informe seu nome: ");
            var nome = Console.ReadLine();

            Console.WriteLine("Informe seu RA: ");
            var ra = Console.ReadLine();

            Console.WriteLine("Informe a nota do primeiro semestre:");
            decimal.TryParse(Console.ReadLine(), out primeiraNota);

            Console.WriteLine("Informe a nota do segundo semestre:");
            decimal.TryParse(Console.ReadLine(), out segundaNota);

            Console.WriteLine("Em quantas aulas você veio ?");
            int.TryParse(Console.ReadLine(), out frequencia);

            Console.WriteLine(ObterMedia(nome, primeiraNota, segundaNota));

            Console.WriteLine(ObterFrequencia(frequencia));
        }

        private static string ObterMedia(string nome, decimal PrimeiraNota, decimal SegundaNota)
        {
            var media = (PrimeiraNota + SegundaNota) / 2;

            if (media >= 7)
            {
                return $"Sua média é: {media}. Média aprovada !";
            }
            else
            {
                return $"Sua média é: {media}. Média reprovada !";
            }

        }

        private static string ObterFrequencia(int frequencia)
        {
            decimal frequenciaAprovada = (25.0m / 100.0m) * 40;

            if (frequencia > frequenciaAprovada)
            {
                return $"Número de presenças: {frequencia}.Frequência aprovada !";
            }
            else
            {
                return $"Número de presenças: {frequencia}.Frequencia reprovada !";
            }
        }

    }
}
