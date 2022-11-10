namespace UsuarioEx.Models
{
    public class Disciplinas : Professores
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cargahoraria { get; set; }
        public virtual Turmas Turmas { get; set; }
    }
}