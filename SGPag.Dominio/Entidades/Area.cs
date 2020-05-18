using System;

namespace SGPag.Dominio.Entidades
{
    public class Area : Entidade
    {
        public int Id { get; set; }
        public string AreaCurto { get; set; }
        public string AreaLongo { get; set; }
        public int AreaAtivo { get; set; }

        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
