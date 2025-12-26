using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
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
        public char actualID;
        public Indirizzo actualIndirizzo;

        private readonly List<Control> aggiunte;

        private bool updating = false;

        public frm_Indirizzi(Progetto progetto)
        {
            InitializeComponent();
            this.progetto = progetto;

            aggiunte = [];

            this.Text = "Indirizzi - " + progetto.nome;
            actualID = '0';
            actualIndirizzo = new(progetto);
        }

        private void Frm_Indirizzi_Load(object? sender, EventArgs e)
        {
            updating = true;

            //reset
            foreach (Control obj in aggiunte)
            {
                this.Controls.Remove(obj);
            }
            btn_aggiungiPiano.Location = new Point(200, 90);

            //button per indirizzi
            for (int i = 0; i < progetto.indirizzi.Count; i++)
            {
                Button btn = new()
                {
                    Text = progetto.indirizzi[i].id + ") " + progetto.indirizzi[i].nome,
                    Size = new Size(170, 30),
                    Location = new Point(10, 60 + i * 40)
                };
                btn.Click += Btn_Indirizzi_Click;
                this.Controls.Add(btn);
                aggiunte.Add(btn);
            }

            //dati
            lbl_ID.Text = "ID: " + actualID;
            txb_nome.Text = actualIndirizzo.nome;

            //materie
            for (int i = 0; i < actualIndirizzo.piani.Count; i++)
            {
                TextBox textBox = new()
                {
                    Location = new Point(200, 80 + i * 35 + 4),
                    Text = actualIndirizzo.piani[i].nome,
                    Size = new Size(240, 27)
                };
                Controls.Add(textBox);
                aggiunte.Add(textBox);

                for (int j = 0; j < 5; j++)
                {
                    TextBox textBox2 = new()
                    {
                        Location = new Point(450 + j * 50 + 5, 80 + i * 35 + 4),
                        Text = actualIndirizzo.piani[i].anni[j].ToString(),
                        Size = new Size(40, 27)
                    };
                    Controls.Add(textBox2);
                    aggiunte.Add(textBox2);
                }

                btn_aggiungiPiano.Location = new Point(btn_aggiungiPiano.Location.X, btn_aggiungiPiano.Location.Y + 35);

                Panel panel = new()
                {
                    BackColor = SystemColors.GrayText,
                    Location = new Point(200, 80 + 35 * (i + 1)),
                    Size = new Size(500, 1)
                };
                Controls.Add(panel);
                aggiunte.Add(panel);
            }

            updating = false;
        }

        private void Btn_Indirizzi_Click(object? sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                char actualID = char.Parse(btn.Text.Split(')')[0]);
                this.actualID = actualID;

                foreach (Indirizzo indirizzo in progetto.indirizzi)
                {
                    if (indirizzo.id == actualID)
                    {
                        actualIndirizzo = indirizzo;
                        break;
                    }
                }
            }

            Frm_Indirizzi_Load(sender, e);
        }

        private void Btn_Aggiungi_Click(object sender, EventArgs e)
        {
            progetto.indirizzi.Add(new(progetto));

            Frm_Indirizzi_Load(sender, e);
        }

        private void Btn_Elimina_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Vuoi davvero eliminare questo elemento?",
                "Conferma eliminazione",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                progetto.indirizzi.Remove(actualIndirizzo);
                actualID = '0';
            }

            Frm_Indirizzi_Load(sender, e);
        }

        private void Txb_nome_TextChanged(object sender, EventArgs e)
        {
            if(updating) { return; }

            actualIndirizzo.nome = txb_nome.Text;
            Frm_Indirizzi_Load(sender, e);
        }

        private void Btn_aggiungiPiano_Click(object sender, EventArgs e)
        {
            actualIndirizzo.piani.Add(new());

            Frm_Indirizzi_Load(sender, e);
        }
    }
}
