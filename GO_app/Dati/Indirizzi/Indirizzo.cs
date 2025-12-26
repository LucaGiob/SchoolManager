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

        public Indirizzo(Progetto progetto)
        {
            nome = string.Empty;
            piani = [];

            // Prendi gli ID già usati
            HashSet<char> usedIds = [.. progetto.indirizzi.Select(i => i.id)];

            // Genera ID progressivo: dalla A fino a Z
            for (char c = 'A'; c <= 'Z'; c++)
            {
                if (!usedIds.Contains(c))
                {
                    id = c;
                    break;
                }
            }

            // Se tutte le lettere sono già usate
            if (usedIds.Contains(id))
                throw new InvalidOperationException("Tutte le lettere dell'alfabeto sono già state usate!");
        }
    }
}
