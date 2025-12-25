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
    }
}
