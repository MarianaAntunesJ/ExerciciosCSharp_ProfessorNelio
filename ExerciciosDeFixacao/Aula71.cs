using System;

namespace ExerciciosCSharp_ProfessorNelio.ExerciciosDeFixacao
{
    class Aula71
    {
        private void Calcula()
        {
            int quant;
            do
            {
                quant = int.Parse(Console.ReadLine());
            } while (quant > 10 || quant < 0);

            Inquilino[] vect = new Inquilino[10];

            for (int i = 0; i < quant; i++)
            {
                Console.WriteLine($"\nRent #{i + 1}");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());
                vect[room] = new Inquilino
                {
                    Name = name,
                    Email = email,
                    Room = room
                };
            }

            Console.WriteLine("\nBusy rooms:");

            foreach (Inquilino inquilino in vect)
                if (inquilino != null)
                    Console.WriteLine(inquilino);
        }
    }
}
