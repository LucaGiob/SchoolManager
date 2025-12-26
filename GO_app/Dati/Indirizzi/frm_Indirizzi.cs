using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GO_app.Dati.Indirizzi
{
    public partial class frm_Indirizzi : Form
    {
        public Progetto progetto;

        public frm_Indirizzi(Progetto progetto)
        {
            InitializeComponent();
            this.progetto = progetto;

            this.Text = progetto.nome;
        }
    }
}
