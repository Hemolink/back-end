﻿namespace Hemolink.Models
{
    public class CreateDoadorDto
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public string Senha { set; get; }
        public string SangueId { set; get; }
        public int CPF { get; set; }
        public DateTime UltimaDoacao { set; get; }
        public string Sexo { set; get; }
        public float Peso { set; get; }

    }
}