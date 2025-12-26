using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GO_app.Dati.Indirizzi
{
    internal class Indirizzo
    {
        public char id;
        public string nome;

        public List<Piano> piani;

        public Indirizzo()
        {
            id = '0';
            nome = string.Empty;
            piani = [];
        }
    }
}
