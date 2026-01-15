using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GO_app.Dati.Professori
{
    public class Professore
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public int OreExtra { get; set; }

        public Professore(Progetto progetto)
        {
            Nome = string.Empty;
            OreExtra = 0;

            // Prendi gli ID già usati
            HashSet<string> usedIds = [.. progetto.Professori.Select(i => i.Id)];

            // Scorri tutti gli ID da AAA a ZZZ
            for (char a = 'A'; a <= 'Z'; a++)
            {
                for (char b = 'A'; b <= 'Z'; b++)
                {
                    for (char c = 'A'; c <= 'Z'; c++)
                    {
                        string candidate = $"{a}{b}{c}";

                        if (!usedIds.Contains(candidate))
                        {
                            Id = candidate;
                            return;
                        }
                    }
                }
            }

            throw new InvalidOperationException(
                "Tutte le combinazioni da AAA a ZZZ sono già state usate!"
            );
        }

        public Professore()
        {
            Id = "000";
            Nome = string.Empty;
            OreExtra = 0;
        }
    }
}
