using GO_app.Dati.Indirizzi;
using GO_app.Dati.Professori;
using GO_app.Dati.Classi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GO_app.Dati
{
    internal class Progetto
    {
        internal string Nome { get; set; } = "";
        internal List<Indirizzo> Indirizzi { get; set; } = [];
        internal List<Professore> Professori { get; set; } = [];
        internal List<Classe> Classi { get; set; } = [];

        internal Progetto() { }
    }
}
