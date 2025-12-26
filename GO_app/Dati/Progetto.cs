using GO_app.Dati.Indirizzi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GO_app.Dati
{
    public class Progetto
    {
        public string Nome { get; set; } = "";
        public List<Indirizzo> Indirizzi { get; set; } = [];

        public Progetto() { }
    }
}
