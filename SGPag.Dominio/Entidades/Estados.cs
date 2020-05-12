using System;
using System.Collections.Generic;
using System.Text;

namespace SGPag.Dominio.Enumerados
{
    public class Estados
    {
        public int Id { get; set; }
        public string UF { get; set; }
        public string NomeEstado { get; set; }
        public ICollection<Contratos> Contratos { get; set; }
    }
}
