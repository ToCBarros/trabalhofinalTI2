using System;
using System.Collections.Generic;
using System.Web;

namespace MaouHeroLanding.Models
{
    public class Funcionarios
    {
        public int ID { get; set; }

        public string Nome { get; set; }

        public int Telemovel { get; set; }

        public string Email { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public ICollection<Encomendas> ListaDasEncomendas { get; set; }
    }
}
