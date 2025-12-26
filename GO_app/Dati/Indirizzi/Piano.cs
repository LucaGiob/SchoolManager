using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GO_app.Dati.Indirizzi
{
    public class Piano
    {
        public string Nome { get; set; } = "";
        public int[] Anni { get; set; } = new int[5];

        public Piano() { }
    }
}
