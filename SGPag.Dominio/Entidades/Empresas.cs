using System;
using System.Collections.Generic;
using System.Text;

namespace SGPag.Dominio.Entidades
{
    public class Empresas
    {
        public int Id { get; set; }
        public string EmpresaCurto { get; set; }
        public string EmpresaLongo { get; set; }
        public string EmpresaAtivo { get; set; }
        public ICollection<Contratos> Contratos { get; set; }
    }
}
