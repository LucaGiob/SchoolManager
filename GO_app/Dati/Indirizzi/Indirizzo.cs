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
            id = '0';
            nome = string.Empty;
            piani = [];

            //ID già usati
            HashSet<char> usedIds = [.. progetto.indirizzi.Select(i => i.id)];

            //Tutte le lettere maiuscole
            List<char> availableIds = [.. Enumerable.Range('A', 26)
                .Select(x => (char)x)
                .Where(c => !usedIds.Contains(c))];

            if (availableIds.Count == 0)
                throw new InvalidOperationException("Tutte le lettere dell'alfabeto sono già state usate!");

            // Genera un indice casuale
            Random rnd = new Random();
            id = availableIds[rnd.Next(availableIds.Count)];
        }
    }
}
