using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SM_app.Table.Class
{
    public class ClassTable
    {
        public string Name { get; set; } = "";
        public string[,] Table { get; set; } = new string[6, 6];

        public ClassTable() { }
    }
}
