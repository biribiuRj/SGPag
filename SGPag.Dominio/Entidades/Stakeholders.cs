using System;
using System.Collections.Generic;
using System.Text;

namespace SGPag.Dominio.Entidades
{
    public class Stakeholders
    {
        public int Id { get; set; }
        public Fornecedores FornecedorId { get; set; }
        public string Tipo { get; set; }
        public string Nome { get; set; }
        public string Telefone1 { get; set; }
        public string Email { get; set; }
    }
}
