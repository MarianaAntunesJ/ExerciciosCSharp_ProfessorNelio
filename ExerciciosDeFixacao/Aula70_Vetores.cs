using System;
using System.Threading;

namespace ExerciciosCSharp_ProfessorNelio.ExerciciosDeFixacao
{
    class Aula70_Vetores
    {
        private void Calcula()
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            int quant = int.Parse(Console.ReadLine());

            Produto[] vect = new Produto[quant];

            double sum = 0;

            for (int i = 0; i < quant; i++)
            {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine());
                vect[i] = new Produto
                {
                    Nome = nome,
                    Preco = preco
                };
                sum += vect[i].Preco;
            }

            Console.WriteLine($"AVERAGE PRICE = {sum / quant:F2}");
        }
    }
}
