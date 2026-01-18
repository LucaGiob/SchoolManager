using GO_app.Dati.Classi;
using GO_app.Dati.Professori;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GO_app.Dati.Indirizzi
{
    internal partial class Frm_Indirizzi : Form
    {
        internal Progetto progetto;
        internal char actualID;
        internal Indirizzo actualIndirizzo;

        internal readonly List<Control> aggiunte;

        internal bool updating = false;
        internal bool firstLoad = true;
        internal bool updateList = true;

        internal Frm_Indirizzi(Progetto progetto)
        {
            InitializeComponent();
            this.progetto = progetto;

            aggiunte = [];

            this.Text = "Indirizzi - " + progetto.Nome;
            actualID = '0';
            actualIndirizzo = new(progetto);

            var colMateria = new DataGridViewTextBoxColumn
            {
                HeaderText = "Materia",
                Name = "Materia",
                ReadOnly = true,
                Width = 150
            };
            materie.Columns.Add(colMateria);

            for (int j = 1; j <= 5; j++)
            {
                var colProfessore = new DataGridViewTextBoxColumn
                {
                    HeaderText = j.ToString() + "°",
                    Name = j.ToString(),
                    Width = 50
                };
                materie.Columns.Add(colProfessore);
            }
        }

        private void Frm_Indirizzi_Load(object? sender, EventArgs e)
        {
            updating = true;

            if (updateList)
            {
                //button per indirizzi
                indirizzi.Items.Clear();
                for (int i = 0; i < progetto.Indirizzi.Count; i++)
                {
                    indirizzi.Items.Add(progetto.Indirizzi[i].Id + ") " + progetto.Indirizzi[i].Nome);

                }

                updateList = false;
            }

            //dati
            lbl_ID.Text = "ID: " + actualID;
            txb_nome.Text = actualIndirizzo.Nome;

            //materie
            materie.Rows.Clear();
            foreach (var p in actualIndirizzo.Piani)
            {
                int rowIndex = materie.Rows.Add();

                // Valore della TextBox
                materie.Rows[rowIndex].Cells["Materia"].Value = p.Nome;

                for (int i = 1; i <= 5; i++)
                {
                    materie.Rows[rowIndex].Cells[i].Value = p.Anni[i - 1];
                }
            }

            updating = false;
        }

        private void Frm_Indirizzi_Closing(object sender, EventArgs e)
        {
            SaveData(sender, e);
            IO.SalvaProgetto(progetto);
        }

        private void Btn_Aggiungi_Click(object sender, EventArgs e)
        {
            progetto.Indirizzi.Add(new(progetto));
            updateList = true;
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
                progetto.Indirizzi.Remove(actualIndirizzo);
                actualID = '0';
            }

            updateList = true;
            Frm_Indirizzi_Load(sender, e);
        }

        private void Txb_nome_TextChanged(object sender, EventArgs e)
        {
            if (updating) { return; }

            actualIndirizzo.Nome = txb_nome.Text;
            updateList = true;
            Frm_Indirizzi_Load(sender, e);
        }

        private void Btn_aggiungiPiano_Click(object sender, EventArgs e)
        {
            actualIndirizzo.Piani.Add(new());
            Frm_Indirizzi_Load(sender, e);
        }

        private void indirizzi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (updating) { return; }

            if (indirizzi.SelectedItem != null)
            {
                if (!firstLoad)
                {
                    SaveData(sender, e);
                }

                firstLoad = false;

                if (indirizzi.SelectedItem is not string value) { return; }

                char actualID = char.Parse(value.Split(')')[0]);
                this.actualID = actualID;

                foreach (Indirizzo indirizzo in progetto.Indirizzi)
                {
                    if (indirizzo.Id == actualID)
                    {
                        actualIndirizzo = indirizzo;
                        break;
                    }
                }

                Frm_Indirizzi_Load(sender, e);
            }            
        }

        private void SaveData(object sender, EventArgs e)
        {
            actualIndirizzo.Piani.Clear();

            foreach (DataGridViewRow r in materie.Rows)
            {
                if (!(r.Cells["Materia"].Value == null || (string)r.Cells["Materia"].Value == string.Empty))
                {
                    Piano p = new();

                    string value = (string)r.Cells["Materia"].Value;
                    p.Nome = value;

                    for (int i = 1; i <= 5; i++)
                    {
                        int hours = Convert.ToInt32(r.Cells[i].Value);

                        p.Anni[i - 1] = hours;
                    }

                    actualIndirizzo.Piani.Add(p);
                }
            }
        }
    }
}
