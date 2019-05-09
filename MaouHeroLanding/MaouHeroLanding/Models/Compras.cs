using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace MaouHeroLanding.Models
{
    public class Compras
    {
        [ForeignKey("Encomendas")]
        public int EncomendaFK { get; set; }
        public Encomendas Encomenda { get; set; }

        [ForeignKey("Artigo")]
        public int ArtigoFK { get; set; }
        public Artigos Artigo { get; set; }
    }
}
