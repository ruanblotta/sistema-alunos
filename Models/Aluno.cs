using System.Collections.Generic;

namespace CadastroAlunos.Models
{
    public class Aluno
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public static List<Aluno> Alunos { get; set; } = new List<Aluno>();
    }
}
