using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GO_app.Dati.Classi
{
    internal class Classe
    {
        internal string Nome { get; set; }
        internal char Indirizzo { get; set; }
        internal int Anno { get; set; }
        internal List<string?> Professori { get; set; }

        internal Classe()
        {
            Nome = string.Empty;
            Indirizzo = '0';
            Professori = [];
        }
    }
}
