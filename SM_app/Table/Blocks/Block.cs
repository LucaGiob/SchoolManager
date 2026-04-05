using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM_app.Table.Blocks
{
    public class Block
    {
        public string Classe {  get; set; }
        public string Materia { get; set; }
        public string? Professore { get; set; }

        public Block(string classe, string materia, string? professore)
        {
            Classe = classe;
            Materia = materia;
            Professore = professore;
        }
    }
}
