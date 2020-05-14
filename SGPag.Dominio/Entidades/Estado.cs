using SGPag.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGPag.Dominio.Entidades
{
    public class Estado
    {
        public int Id { get; set; }
        public string UF { get; set; }
        public string NomeEstado { get; set; }
        public virtual ICollection<Fornecedor> Fornecedores{ get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
