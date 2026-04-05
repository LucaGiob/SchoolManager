using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SM_app.Data
{
    internal class IO
    {
        internal static readonly string extension = "smp";

        internal static List<string> ProgettiEsistenti()
        {
            string exeFolder = AppContext.BaseDirectory;

            List<string> list = [.. Directory
                .EnumerateFiles(exeFolder, $"*.{extension}")
                .Select(Path.GetFileNameWithoutExtension)
                .OfType<string>()];

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
            string path = Path.Combine(folder, $"{progetto.Nome}.{extension}");

            string content = JsonSerializer.Serialize(progetto, options: GetOptions());
            File.WriteAllText(path, content);
        }

        internal static Progetto CaricaProgetto(string nome)
        {
            string folder = AppContext.BaseDirectory;
            string path = Path.Combine(folder, $"{nome}.{extension}");

            if (!File.Exists(path))
                throw new FileNotFoundException("File progetto non trovato.", path);

            string content = File.ReadAllText(path);

            return JsonSerializer.Deserialize<Progetto>(content)!;
        }

        internal static void RinominaProgetto(string vecchioNome, string nuovoNome)
        {
            if (string.IsNullOrWhiteSpace(vecchioNome))
                throw new ArgumentException("Il vecchio nome non può essere vuoto.", nameof(vecchioNome));

            if (string.IsNullOrWhiteSpace(nuovoNome))
                throw new ArgumentException("Il nuovo nome non può essere vuoto.", nameof(nuovoNome));

            string folder = AppContext.BaseDirectory;
            string vecchioPath = Path.Combine(folder, $"{vecchioNome}.{extension}");
            string nuovoPath = Path.Combine(folder, $"{nuovoNome}.{extension}");

            if (!File.Exists(vecchioPath))
                throw new FileNotFoundException("File progetto originale non trovato.", vecchioPath);

            if (File.Exists(nuovoPath))
                throw new IOException("Esiste già un progetto con questo nome.");

            string content = File.ReadAllText(vecchioPath);
            Progetto progetto = JsonSerializer.Deserialize<Progetto>(content)!;
            progetto.Nome = nuovoNome;
            string newContent = JsonSerializer.Serialize(progetto, options: GetOptions());
            File.WriteAllText(nuovoPath, newContent);
            File.Delete(vecchioPath);
        }

        internal static void EliminaProgetto(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new ArgumentException("Il nome del progetto non può essere vuoto.", nameof(nome));

            string folder = AppContext.BaseDirectory;
            string path = Path.Combine(folder, $"{nome}.{extension}");

            if (!File.Exists(path))
                throw new FileNotFoundException("File progetto non trovato.", path);

            File.Delete(path);
        }
    }
}
