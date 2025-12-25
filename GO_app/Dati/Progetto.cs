using GO_app.Dati.Indirizzi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GO_app.Dati
{
    internal class Progetto
    {
        public string nome;

        public List<Indirizzo> indirizzi;

        public Progetto()
        {
            nome = string.Empty;
            indirizzi = [];
        }
    }
}
