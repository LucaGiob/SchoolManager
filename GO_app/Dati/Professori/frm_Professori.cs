using System;
using System.Collections;
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

        private string actualID;

        public frm_Professori(Progetto progetto)
        {
            InitializeComponent();
            this.progetto = progetto;
            actualID = "000";

            this.Text = "Professori - " + progetto.Nome;
        }

        private void Frm_Professori_Load(object sender, EventArgs e)
        {
            if (progetto.Professori.Count == 0)
            {
                actualID = "000";

                return;
            }

            btn_prima.Enabled = false;
            btn_dopo.Enabled = false;
            btn_elimina.Enabled = false;

            tbx_nome.Enabled = false;
            tbx_oreExtra.Enabled = false;

            if (progetto.Professori.Count > 0 && actualID == "000")
            {
                actualID = progetto.Professori[0].Id;
            }

            var oggetto = progetto.Professori.First(x => x.Id == actualID);

            lbl_ID.Text = actualID;
            tbx_nome.Text = oggetto.Nome;
            tbx_nome.Text = oggetto.OreExtra.ToString();

            btn_elimina.Enabled = true;

            tbx_nome.Enabled = true;
            tbx_oreExtra.Enabled = true;

            if (!(progetto.Professori.IndexOf(oggetto) == 0))
            {
                btn_prima.Enabled = true;
            }

            if (!(progetto.Professori.IndexOf(oggetto) == progetto.Professori.Count - 1))
            {
                btn_dopo.Enabled = true;
            }
        }

        private void Frm_Professori_Closing(object sender, EventArgs e)
        {
            IO.SalvaProgetto(progetto);
        }
    }
}
