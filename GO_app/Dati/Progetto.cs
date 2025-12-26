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
        public string nome;

        internal List<Indirizzo> indirizzi;

        public Progetto()
        {
            nome = string.Empty;
            indirizzi = [];
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            result.Append('{');

            result.Append("nome: ").Append(nome).Append(';');

            result.Append('}');

            return result.ToString();
        }

        public static Progetto Parse(string s)
        {
            var result = new Progetto();

            if (!string.IsNullOrEmpty(s) && s.StartsWith('{') && s.EndsWith('}'))
            {
                s = s[1..^1];
            }
            string[] parti = s.Split(';');

            //nome
            string nome = parti[0].Split(':')[1];
            result.nome = nome;

            return result;
        }
    }
}
