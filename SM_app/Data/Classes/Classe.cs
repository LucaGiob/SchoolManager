using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM_app.Data.Classes
{
    public class Classe
    {
        public string Nome { get; set; }
        public char Indirizzo { get; set; }
        public int Anno { get; set; }
        public List<string?> Professori { get; set; }

        public Classe()
        {
            Nome = string.Empty;
            Indirizzo = '0';
            Professori = [];
        }
    }
}
