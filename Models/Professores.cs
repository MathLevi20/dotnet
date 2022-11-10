using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace UsuarioEx.Models

{
    public class Professores : Pessoas
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Salario { get; set; }
        public double Formação { get; set; }
        public virtual Turmas Turmas { get; set; }
    }
}