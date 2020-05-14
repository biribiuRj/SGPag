using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SGPag.Dominio.Entidades
{
    public class Area
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50), MinLength(10)]
        public string AreaCurto { get; set; }
        [MinLength(10, ErrorMessage = "Name cannot be less than 10")]
        [MaxLength(50, ErrorMessage = "Name cannot be greater than 50")]
        public string AreaLongo { get; set; }
        public int AreaAtivo { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
