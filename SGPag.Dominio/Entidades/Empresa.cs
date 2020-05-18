using System;
using System.Collections.Generic;
using System.Text;

namespace SGPag.Dominio.Entidades
{
    public class Empresa : Entidade
    {
        public int Id { get; set; }
        public string EmpresaCurto { get; set; }
        public string EmpresaLongo { get; set; }
        public int EmpresaAtivo { get; set; }

        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
