using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GO_app.Dati.Professori
{
    public partial class frm_Professori : Form
    {
        public Progetto progetto;

        public frm_Professori(Progetto progetto)
        {
            InitializeComponent();
            this.progetto = progetto;
        }
    }
}
