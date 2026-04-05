using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM_app.Table.Blocks
{
    internal class Block
    {
        internal string Classe {  get; set; }
        internal string Materia { get; set; }
        internal string Professore { get; set; }

        internal Block(string classe, string materia, string professore)
        {
            Classe = classe;
            Materia = materia;
            Professore = professore;
        }
    }
}
