using System;
using System.Collections.Generic;
using System.Text;

namespace SGPag.Dominio.Entidades
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string User { get; set; }
        public string Email { get; set; }
        public virtual ICollection<Fornecedor> Fornecedores { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
