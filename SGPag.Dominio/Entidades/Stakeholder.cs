using System;
using System.Collections.Generic;
using System.Text;

namespace SGPag.Dominio.Entidades
{
    public class Stakeholders
    {
        public int Id { get; set; }
        public virtual Fornecedor FornecedorId { get; set; }

    }
}
