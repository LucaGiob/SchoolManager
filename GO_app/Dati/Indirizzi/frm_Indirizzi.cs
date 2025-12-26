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

            this.Text = "Indirizzi - " + progetto.nome;
        }

        private void frm_Indirizzi_Load(object sender, EventArgs e)
        {
            //button per indirizzi
            for (int i = 0; i < progetto.indirizzi.Count; i++)
            {
                Button btn = new()
                {
                    Text = progetto.indirizzi[i].nome,
                    Size = new Size(170, 30),
                    Location = new Point(10, 60 + i * 40)
                };
                btn.Click += btn_Indirizzi_Click;
                this.Controls.Add(btn);
            }
        }

        private void btn_Indirizzi_Click(object? sender, EventArgs e)
        {

        }

        private void btn_Aggiungi_Click(object sender, EventArgs e)
        {
            progetto.indirizzi.Add(new());

            frm_Indirizzi_Load(sender, e);
        }
    }
}
