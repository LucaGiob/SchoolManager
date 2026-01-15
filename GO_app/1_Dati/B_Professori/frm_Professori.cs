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
        private bool updating = false;

        public frm_Professori(Progetto progetto)
        {
            InitializeComponent();
            this.progetto = progetto;
            actualID = "000";

            this.Text = "Professori - " + progetto.Nome;
        }

        private void Frm_Professori_Load(object sender, EventArgs e)
        {
            updating = true;

            btn_prima.Enabled = false;
            btn_dopo.Enabled = false;
            btn_elimina.Enabled = false;

            tbx_nome.Enabled = false;
            tbx_oreExtra.Enabled = false;

            if (progetto.Professori.Count == 0)
            {
                actualID = "000";

                return;
            }

            if (progetto.Professori.Count > 0 && actualID == "000")
            {
                actualID = progetto.Professori[0].Id;
            }

            var oggetto = progetto.Professori.First(x => x.Id == actualID);

            lbl_ID.Text = actualID;
            tbx_nome.Text = oggetto.Nome;
            tbx_oreExtra.Text = oggetto.OreExtra.ToString();

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

            updating = false;
        }

        private void Frm_Professori_Closing(object sender, EventArgs e)
        {
            IO.SalvaProgetto(progetto);
        }

        private void Btn_prima_Click(object sender, EventArgs e)
        {
            var oggetto = progetto.Professori.First(x => x.Id == actualID);
            actualID = progetto.Professori[progetto.Professori.IndexOf(oggetto) - 1].Id;

            Frm_Professori_Load(sender, e);
        }

        private void Btn_dopo_Click(object sender, EventArgs e)
        {
            var oggetto = progetto.Professori.First(x => x.Id == actualID);
            actualID = progetto.Professori[progetto.Professori.IndexOf(oggetto) + 1].Id;

            Frm_Professori_Load(sender, e);
        }

        private void Btn_elimina_Click(object sender, EventArgs e)
        {
            var oggetto = progetto.Professori.First(x => x.Id == actualID);
            progetto.Professori.Remove(oggetto);

            actualID = "000";

            Frm_Professori_Load(sender, e);
        }

        private void Tbx_nome_TextChanged(object sender, EventArgs e)
        {
            if (updating) { return; }

            var oggetto = progetto.Professori.First(x => x.Id == actualID);
            progetto.Professori[progetto.Professori.IndexOf(oggetto)].Nome = tbx_nome.Text;
        }

        private void Tbx_oreExtra_TextChanged(object sender, EventArgs e)
        {
            if (updating) { return; }

            int value = int.Parse(tbx_oreExtra.Text);

            var oggetto = progetto.Professori.First(x => x.Id == actualID);
            progetto.Professori[progetto.Professori.IndexOf(oggetto)].OreExtra = value;
        }

        private void Btn_aggiungi_Click(object sender, EventArgs e)
        {
            Professore profe = new(progetto);
            progetto.Professori.Add(profe);

            actualID = profe.Id;

            Frm_Professori_Load(sender, e);
        }
    }
}
