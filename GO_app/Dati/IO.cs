using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GO_app.Dati
{
    internal class IO
    {
        public static List<string?> ProgettiEsistenti()
        {
            string exeFolder = AppContext.BaseDirectory;

            List<string?> list = [];

            list = Directory
                .EnumerateFiles(exeFolder, "*.gop")
                .Select(Path.GetFileNameWithoutExtension)
                .ToList();

            return list;
        }

        public static void CreaProgetto(string nome)
        {
            Progetto progetto = new()
            {
                nome = nome
            };

            string content = progetto.ToString();

            string folder = AppContext.BaseDirectory;
            string path = Path.Combine(folder, $"{nome}.gop");

            File.WriteAllText(path, content);
        }

        public static Progetto CaricaProgetto(string nome)
        {
            string folder = AppContext.BaseDirectory;
            string path = Path.Combine(folder, $"{nome}.gop");

            if (!File.Exists(path))
                throw new FileNotFoundException("File progetto non trovato.", path);

            string content = File.ReadAllText(path);
            
            return Progetto.Parse(content);
        }
    }
}
