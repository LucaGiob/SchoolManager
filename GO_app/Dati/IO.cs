using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GO_app.Dati
{
    internal class IO
    {
        internal static List<string?> ProgettiEsistenti()
        {
            string exeFolder = AppContext.BaseDirectory;

            List<string?> list = [];

            list = [.. Directory
                .EnumerateFiles(exeFolder, "*.gop")
                .Select(Path.GetFileNameWithoutExtension)];

            return list;
        }

        internal static JsonSerializerOptions GetOptions()
        {
            return new JsonSerializerOptions
            {
                WriteIndented = true
            };
        }

        internal static void SalvaProgetto(Progetto progetto)
        {
            string folder = AppContext.BaseDirectory;
            string path = Path.Combine(folder, $"{progetto.Nome}.gop");

            string content = JsonSerializer.Serialize(progetto, options: GetOptions());
            File.WriteAllText(path, content);
        }

        internal static Progetto CaricaProgetto(string nome)
        {
            string folder = AppContext.BaseDirectory;
            string path = Path.Combine(folder, $"{nome}.gop");

            if (!File.Exists(path))
                throw new FileNotFoundException("File progetto non trovato.", path);

            string content = File.ReadAllText(path);

            return JsonSerializer.Deserialize<Progetto>(content)!;
        }
    }
}
