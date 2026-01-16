using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GO_app.Dati.Professori
{
    public class Professore
    {
        public string? Id { get; set; }
        public string? Nome { get; set; }
        public int OreExtra { get; set; }

        public Professore(List<string?> usedID)
        {
            Nome = string.Empty;
            OreExtra = 0;

            string AllowedChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random Random = new();

            int maxCombinations = (int)Math.Pow(AllowedChars.Length, 3);

            if (usedID.Count >= maxCombinations)
                throw new InvalidOperationException("Tutti i codici possibili sono già stati usati.");

            string id;
            do
            {
                id = new string([.. Enumerable.Range(0, 3).Select(_ => AllowedChars[Random.Next(AllowedChars.Length)])]);
            }
            while (usedID.Contains(id));

            Id = id;
        }

        public Professore()
        {
            Id = "000";
            Nome = string.Empty;
            OreExtra = 0;
        }
    }
}
