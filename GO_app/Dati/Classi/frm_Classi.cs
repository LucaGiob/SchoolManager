using GO_app.Dati;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GO_app.Dati.Classi
{
    public partial class Frm_Classi : Form
    {
        public Progetto progetto;
        public Frm_Classi(Progetto progettoIn)
        {
            InitializeComponent();

            progetto = progettoIn;
        }

        private void Frm_Classi_Load(object sender, EventArgs e)
        {

        }
    }
}
