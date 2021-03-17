namespace ExerciciosCSharp_ProfessorNelio.ExerciciosDeFixacao
{
    class Inquilino
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Room { get; set; }

        public override string ToString() => ($"{Room}: {Name}, {Email}");
    }
}
