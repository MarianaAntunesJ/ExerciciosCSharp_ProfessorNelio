using System;
using System.Text;

namespace ExerciciosCSharp_ProfessorNelio.ExerciciosDeFixacao
{
    class Aula81
    {
        private void Calcula()
        {
            var m = int.Parse(Console.ReadLine());
            var n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[m, n];

            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    matriz[i, j] = int.Parse(Console.ReadLine());

            var x = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i, j] == x)
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.Append($"Position {i},{j}:\n");
                        if (j > 0)
                            sb.Append($"Left: {matriz[i, j - 1]}\n");
                        if (j < (m - 1))
                            sb.Append($"Right: {matriz[i, j + 1]}\n");
                        if (i > 0)
                            sb.Append($"Up: {matriz[i - 1, j]}\n");
                        if (i < n)
                            sb.Append($"Down: {matriz[i + 1, j]}\n");

                        Console.WriteLine(sb.ToString());
                    }
                }
            }
        }
    }
}
