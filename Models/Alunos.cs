﻿namespace UsuarioEx.Models
{
    public class Alunos:Pessoas
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string DataNascimento { get; set; }
        public virtual Turmas Turmas { get; set; }
    }
}