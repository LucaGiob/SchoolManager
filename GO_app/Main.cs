using System.Collections.Generic;
using GO_app.Dati;

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
            List<string> progetti = IO.ProgettiEsistenti()
                .Where(x => x is not null)
                .Select(x => x!)
                .ToList();

            cmb_progetto.DataSource = progetti;
        }

        private void btn_aggiungiProgetto_Click(object sender, EventArgs e)
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
    }
}
