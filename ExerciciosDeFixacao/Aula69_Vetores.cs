using System;
using System.Globalization;
using System.Threading;

namespace ExerciciosCSharp_ProfessorNelio.ExerciciosDeFixacao
{
    class Aula69_Vetores
    {
        private void Calcula()
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            int quantidade = int.Parse(Console.ReadLine());

            double[] vetor = new double[quantidade];
            double soma = 0;

            for (int i = 0; i < quantidade; i++)
            {
                vetor[i] = double.Parse(Console.ReadLine());
                soma += vetor[i];
            }

            Console.WriteLine($"AVERAGE HEIGHT {(soma / quantidade).ToString("F2")}");
        }
    }
}
