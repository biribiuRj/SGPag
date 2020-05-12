using System;
using System.Collections.Generic;
using System.Text;

namespace SGPag.Dominio.Entidades
{
    public class Areas
    {
        public int Id { get; set; }
        public string AreaCurto { get; set; }
        public string AreaLongo { get; set; }
        public string AreaAtivo { get; set; }
        public ICollection<Contratos> Contratos { get; set; }
    }
}
