using System;
using System.Collections.Generic;
using System.Text;

namespace SGPag.Dominio.Entidades
{
    public class Empresa
    {
        public int Id { get; set; }
        public string EmpresaCurto { get; set; }
        public string EmpresaLongo { get; set; }
        public int EmpresaAtivo { get; set; }
    }
}
