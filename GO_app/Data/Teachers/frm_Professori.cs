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

namespace SM_app.Data.Teachers
{
    internal partial class Frm_Professori : Form
    {
        internal Progetto progetto;
        internal List<Professore> professori;
        internal List<string?> usedID;

        internal Frm_Professori(Progetto progettoIn)
        {
            InitializeComponent();

            progetto = progettoIn;
            professori = progetto.Professori;

            usedID = [.. professori.Select(c => c.Id)];

            this.Text = "Professori - " + progetto.Nome;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            var colID = new DataGridViewTextBoxColumn
            {
                HeaderText = "ID",
                Name = "ID",
                ReadOnly = true,
                Width = 60
            };
            data.Columns.Add(colID);

            var colNome = new DataGridViewTextBoxColumn
            {
                HeaderText = "Nome",
                Name = "Nome",
                Width = data.Width - 75 - 60 - 100
            };
            data.Columns.Add(colNome);

            var colOre = new DataGridViewTextBoxColumn
            {
                HeaderText = "Ore Extra",
                Name = "OreExtra",
                ValueType = typeof(int),
                Width = 100
            };
            data.Columns.Add(colOre);

            foreach (var p in professori)
            {
                if (p.Id is null || p.Id == "") { continue; }

                data.Rows.Add(p.Id, p.Nome, p.OreExtra);
            }
        }

        private void Form_Resize(object sender, EventArgs e)
        {
            //button
            btn_aggiungi.Width = Width - 40;

            //data
            data.Width = Width - 40;
            data.Height = Height - 110;
            data.Columns["Nome"].Width = data.Width - 235;
        }

        private void Form_Closing(object sender, EventArgs e)
        {
            professori.Clear();
            foreach (DataGridViewRow row in data.Rows)
            {
                professori.Add(new Professore
                {
                    Id = row.Cells["Id"].Value?.ToString(),
                    Nome = row.Cells["Nome"].Value?.ToString(),
                    OreExtra = int.TryParse(row.Cells["OreExtra"].Value?.ToString(), out int ore) ? ore : 0
                });
            }

            IO.SalvaProgetto(progetto);
        }

        private void Btn_aggiungi_Click(object sender, EventArgs e)
        {
            Professore profe = new(usedID);

            string? nuovoId = profe.Id;
            usedID.Add(nuovoId);

            data.Rows.Add(nuovoId, "", 0);
        }
    }
}
