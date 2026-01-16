using GO_app.Dati;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GO_app.Dati.Classi
{
    public partial class Frm_Classi : Form
    {
        public Progetto progetto;
        public List<Classe> listaClassi;
        public Classe? classeOra;

        private bool updating = false;

        public Frm_Classi(Progetto progettoIn)
        {
            InitializeComponent();

            progetto = progettoIn;
            listaClassi = progetto.Classi;
        }

        private void Frm_Classi_Load(object sender, EventArgs e)
        {
            foreach (var c in listaClassi)
            {
                classi.Items.Add(c.Nome);
            }

            foreach (var i in progetto.Indirizzi)
            {
                cmb_indirizzo.Items.Add(i.Nome);
            }

            Form_Update(sender, e);
            Data_Initialize(sender, e);
        }

        private void Frm_Classi_Closing(object sender, EventArgs e)
        {
            IO.SalvaProgetto(progetto);
        }

        private void Data_Initialize(object sender, EventArgs e)
        {
            var colMateria = new DataGridViewTextBoxColumn
            {
                HeaderText = "Materia",
                Name = "Materia",
                ReadOnly = true,
                Width = 150
            };
            data.Columns.Add(colMateria);

            var colProfessore = new DataGridViewComboBoxColumn
            {
                HeaderText = "Professore",
                Name = "Professore",
                Width = data.Width - colMateria.Width - 75
            };
            data.Columns.Add(colProfessore);
        }

        private void Form_Update(object sender, EventArgs e)
        {
            updating = true;

            bool nothing = classeOra == null;
            txb_nome.Enabled = !nothing;
            cmb_indirizzo.Enabled = !nothing;
            nud_anno.Enabled = !nothing;
            btn_elimina.Enabled = !nothing;

            data.Enabled = false;

            if (classeOra != null)
            {
                txb_nome.Text = classeOra.Nome;

                if (classeOra.Indirizzo != '0')
                {
                    char IDindirizzo = classeOra.Indirizzo;
                    cmb_indirizzo.Text = progetto.Indirizzi.First(c => c.Id == IDindirizzo).Nome;
                }
                else
                {
                    cmb_indirizzo.SelectedIndex = -1;
                }

                if (classeOra.Anno != 0)
                {
                    nud_anno.Value = classeOra.Anno;
                } else
                {
                    nud_anno.Value = 0;
                }

                if (classeOra.Indirizzo != '0' && classeOra.Anno != 0)
                {
                    data.Enabled = true;
                }
            }

            updating = false;
        }

        private void Btn_aggiungi_Click(object sender, EventArgs e)
        {
            Classe classe = new()
            {
                Nome = "XXX"
            };

            classi.Items.Add(classe.Nome);
            listaClassi.Add(classe);
        }

        private void classi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (classi.SelectedItem != null)
            {
                classeOra = listaClassi[classi.SelectedIndex];
            }

            Form_Update(sender, e);
        }

        private void txb_nome_TextChanged(object sender, EventArgs e)
        {
            if (classeOra != null)
            {
                classeOra.Nome = txb_nome.Text;

                classi.Items[classi.SelectedIndex] = txb_nome.Text;
            }
        }

        private void cmb_indirizzo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (updating) { return; }

            if (classeOra != null)
            {
                classeOra.Indirizzo = progetto.Indirizzi[cmb_indirizzo.SelectedIndex].Id;
            }
        }

        private void btn_elimina_Click(object sender, EventArgs e)
        {
            if (classeOra != null)
            {
                listaClassi.Remove(classeOra);
                classi.Items.Remove(classeOra.Nome);

                classeOra = null;
                Form_Update(sender, e);
            }
        }

        private void nud_anno_ValueChanged(object sender, EventArgs e)
        {
            if (updating) { return; }

            if (classeOra != null)
            {
                classeOra.Anno = (int)nud_anno.Value;
            }
        }
    }
}
