

namespace UsuarioEx.Models

{
    public class Turmas
    {
        public int Id { get; set; }
        public int Ano { get; set; }
        public string Sigla { get; set; }
        public virtual ICollection<Alunos> Alunos { get; set; }
        public virtual ICollection<Professores> Professores { get; set; }
        public virtual ICollection<Disciplinas> Disciplinas{ get; set; }
    }
}