using SM_app.Data;
using SM_app.Data.Adresses;
using SM_app.Data.Teachers;
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

namespace SM_app.Data.Classes
{
    internal partial class Frm_Classi : Form
    {
        internal Progetto progetto;
        internal List<Classe> listaClassi;
        internal Classe? classeOra;

        private bool updating = false;
        private bool firstLoad = true;

        internal Frm_Classi(Progetto progettoIn)
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
            SaveData(sender, e);
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
                DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox,
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

                Data_Update(sender, e);
            }

            updating = false;
        }

        private void Data_Update(object sender, EventArgs e)
        {
            data.Enabled = false;
            data.Rows.Clear();

            if (classeOra != null)
            {
                if (classeOra.Indirizzo != '0' && classeOra.Anno != 0)
                {
                    data.Enabled = true;

                    List<string?> professori = [.. progetto.Professori.Select(p => p.Nome)];

                    foreach (Piano p in progetto.Indirizzi.First(c => c.Id == classeOra.Indirizzo).Piani)
                    {
                        if (p.Anni[classeOra.Anno - 1] == 0) { continue; }

                        int rowIndex = data.Rows.Add();

                        // Valore della TextBox
                        data.Rows[rowIndex].Cells["Materia"].Value = p.Nome;

                        // ComboBox: assegni le opzioni
                        var comboCell = (DataGridViewComboBoxCell)data.Rows[rowIndex].Cells["Professore"];

                        comboCell.DataSource = professori;

                        if (!(classeOra.Professori.Count > rowIndex))
                        {
                            comboCell.Value = null;
                            continue;
                        }

                        if (classeOra.Professori[rowIndex] == null || classeOra.Professori[rowIndex] == string.Empty || classeOra.Professori[rowIndex] == "000")
                        {
                            comboCell.Value = null;
                        } else
                        {
                            comboCell.Value = progetto.Professori.First(c => c.Id == classeOra.Professori[rowIndex]).Nome;
                        }
                    }
                }
            }
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
            if (updating) { return; }

            if (classi.SelectedItem != null)
            {
                if (!firstLoad)
                {
                    SaveData(sender, e);
                }

                firstLoad = false;

                classeOra = listaClassi[classi.SelectedIndex];

                Form_Update(sender, e);
            }
        }

        private void txb_nome_TextChanged(object sender, EventArgs e)
        {
            if (updating) { return; }

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
                Data_Update(sender, e);
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
                int value = (int)nud_anno.Value;

                classeOra.Anno = value;
                Data_Update(sender, e);
            }
        }

        private void SaveData(object sender, EventArgs e)
        {
            List<string?> professori = [.. progetto.Professori.Select(p => p.Nome)];
            List<string?> professoriID = [.. progetto.Professori.Select(p => p.Id)];

            if (classeOra != null)
            {
                classeOra.Professori.Clear();

                foreach (DataGridViewRow r in data.Rows)
                {
                    if (r.Cells["Professore"].Value == null || (string)r.Cells["Professore"].Value == string.Empty)
                    {
                        classeOra.Professori.Add("000");
                    } else
                    {
                        string value = (string)r.Cells["Professore"].Value;
                        classeOra.Professori.Add(professoriID[professori.IndexOf(value)]);
                    }
                }
            }
        }
    }
}
