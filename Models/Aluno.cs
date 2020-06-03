using System.Collections.Generic;

namespace SmartSchool.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Telefone { get; set; }
        public virtual IEnumerable<AlunoDisciplina> AlunoDisciplinas { get; set; }

        public Aluno() { }

        public Aluno(int id, string nome, string sobreNome, string telefone)
        {
            this.Id = id;
            this.Nome = nome;
            this.SobreNome = sobreNome;
            this.Telefone = telefone;

        }

    }
}