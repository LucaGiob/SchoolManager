using System.Collections.Generic;
using GO_app.Dati;
using GO_app.Dati.Indirizzi;

namespace GO_app
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            List<string> progetti = [.. IO.ProgettiEsistenti()
                .Where(x => x is not null)
                .Select(x => x!)];

            cmb_progetto.DataSource = progetti;
        }

        private void Btn_aggiungiProgetto_Click(object sender, EventArgs e)
        {
            if (cmb_progetto.Items.Cast<string>().Contains(cmb_progetto.Text))
            {
                MessageBox.Show("File già esistente", "Scegli un nome diverso o selezionalo dalla lista", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            IO.CreaProgetto(cmb_progetto.Text);

            MessageBox.Show("File creato con successo!", "Operazione completata", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Main_Load(sender, e);
        }

        private void Btn_passage01A_Click(object sender, EventArgs e)
        {
            Progetto progetto = IO.CaricaProgetto(cmb_progetto.Text);

            frm_Indirizzi indirizzi = new(progetto);

            Hide();

            using (indirizzi)
            {
                indirizzi.ShowDialog();
            }

            Show();
        }
    }
}
