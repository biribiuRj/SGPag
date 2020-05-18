using System;
using System.Collections.Generic;
using System.Text;

namespace SGPag.Dominio.Entidades
{
    public class Usuario : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string User { get; set; }
        public string Email { get; set; }
        public int Ativo { get; set; }
        public virtual ICollection<Fornecedor> Fornecedores { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Email))
                AdicionarCritica("Email não foi informado");
            if (string.IsNullOrEmpty(Senha))
            {
                AdicionarCritica("Senha não informada");
            }

        }
    }
}
