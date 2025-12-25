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
    }
}
