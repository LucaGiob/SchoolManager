using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GO_app.Dati.Indirizzi
{
    public class Indirizzo
    {
        public char Id { get; set; }
        public string Nome { get; set; }
        public List<Piano> Piani { get; set; } = [];

        // Costruttore, assegna ID progressivo basato sugli indirizzi già presenti
        public Indirizzo(Progetto progetto)
        {
            Nome = string.Empty;
            Piani = [];

            // Prendi gli ID già usati
            HashSet<char> usedIds = [.. progetto.Indirizzi.Select(i => i.Id)];

            // Trova la prima lettera libera da A a Z
            for (char c = 'A'; c <= 'Z'; c++)
            {
                if (!usedIds.Contains(c))
                {
                    Id = c;
                    break;
                }
            }

            if (usedIds.Contains(Id))
                throw new InvalidOperationException("Tutte le lettere dell'alfabeto sono già state usate!");
        }

        // Costruttore vuoto (utile per deserializzazione)
        public Indirizzo()
        {
            Nome = string.Empty;
            Piani = [];
        }
    }
}
