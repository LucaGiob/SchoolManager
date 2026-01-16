using System.Collections.Generic;
using GO_app.Dati;
using GO_app.Dati.Indirizzi;
using GO_app.Dati.Professori;
using GO_app.Dati.Classi;

namespace GO_app
{
    internal partial class Main : Form
    {
        internal Main()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            List<string> progetti = [.. IO.ProgettiEsistenti()
                .Where(x => x is not null)
                .Select(x => x!)];

            cmb_progetto.DataSource = progetti;

            btn_passage01A.Tag = (Func<Progetto, Form>)(p => new Frm_Indirizzi(p));
            btn_passage01B.Tag = (Func<Progetto, Form>)(p => new Frm_Professori(p));
            btn_passage01C.Tag = (Func<Progetto, Form>)(p => new Frm_Classi(p));
        }

        private void Btn_aggiungiProgetto_Click(object sender, EventArgs e)
        {
            if (cmb_progetto.Items.Cast<string>().Contains(cmb_progetto.Text))
            {
                MessageBox.Show("File già esistente", "Scegli un nome diverso o selezionalo dalla lista", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            Progetto progetto = new()
            {
                Nome = cmb_progetto.Text
            };
            IO.SalvaProgetto(progetto);

            MessageBox.Show("File creato con successo!", "Operazione completata", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Form_Load(sender, e);
        }

        private void Btn_Passage_Click(object sender, EventArgs e)
        {
            Progetto progetto = IO.CaricaProgetto(cmb_progetto.Text);

            if (sender is not Button btn)
                return;

            if (btn.Tag is not Func<Progetto, Form> creaForm)
                return;

            using (Form frm = creaForm(progetto))
            {
                Hide();
                frm.ShowDialog();
                Show();
            }
        }
    }
}
