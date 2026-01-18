using SM_app.Data.Adresses;
using SM_app.Data.Teachers;
using SM_app.Data.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM_app.Data
{
    public class Progetto
    {
        public string Nome { get; set; } = "";
        public List<Indirizzo> Indirizzi { get; set; } = [];
        public List<Professore> Professori { get; set; } = [];
        public List<Classe> Classi { get; set; } = [];

        public Progetto() { }
    }
}
