using System.Collections.Generic;
using SM_app.Data;
using SM_app.Data.Adresses;
using SM_app.Data.Teachers;
using SM_app.Data.Classes;
using System.Data.Common;

namespace SM_app
{
    internal partial class Main : Form
    {
        internal List<string> projects = [];

        private bool updating = false;
        private readonly string newProjectText = "New project";

        private List<Control> controls = [];

        internal Main()
        {
            InitializeComponent();

            projects = IO.ProgettiEsistenti();

            btn_passage01A.Tag = (Func<Progetto, Form>)(p => new Frm_Indirizzi(p));
            btn_passage01B.Tag = (Func<Progetto, Form>)(p => new Frm_Professori(p));
            btn_passage01C.Tag = (Func<Progetto, Form>)(p => new Frm_Classi(p));

            controls.AddRange([nameBox, remove, btn_passage01A, btn_passage01B, btn_passage01C]);
        }

        private void Form_Load(object sender, EventArgs e)
        {
            foreach (var p in projects)
            {
                projectsList.Items.Add(p);
            }

            Form_Update(sender, e);
        }

        private void Form_Update(object sender, EventArgs e)
        {
            updating = true;

            bool itemSelected = projectsList.SelectedItems.Count > 0;

            foreach (var c in controls)
            {
                c.Enabled = itemSelected;
            }

            if (sender is Button btn && btn.Name == "projectsAdd")
            {
                projectsList.Items.Add(newProjectText);
                projectsList.SelectedItem = newProjectText;
            }

            if (sender is TextBox tb && tb.Name == "nameBox")
            {
                projectsList.Items[projectsList.SelectedIndex] = projects[projectsList.SelectedIndex];
            }

            nameBox.Text = projectsList.Text;

            updating = false;
        }

        private void ProjectsAdd_Click(object sender, EventArgs e)
        {
            if (projects.Contains(newProjectText))
            {
                MessageBox.Show("Nuovo progetto già esistente", "Ripetizione", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Progetto progetto = new()
            {
                Nome = newProjectText
            };

            projects.Add(progetto.Nome);

            IO.SalvaProgetto(progetto);

            Form_Update(sender, e);
        }

        private void Btn_Passage_Click(object sender, EventArgs e)
        {
            Progetto progetto = IO.CaricaProgetto(projectsList.Text);

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

        private void projectsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form_Update(sender, e);
        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {
            if (updating) { return; }

            string value = nameBox.Text;
            string old = projects[projectsList.SelectedIndex];

            if (old == value) { return; }

            string allowed = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-_#@?!|";
            string newText = new([.. value.Where(c => allowed.Contains(c))]);

            if (value != newText)
            {
                MessageBox.Show("Il nome del progetto non può contere caratteri speciali (ad eccezione di -, _, #, @, ?, !, |)!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nameBox.Text = old;
                return;
            }

            IO.RinominaProgetto(old, value);
            projects[projectsList.SelectedIndex] = value;
            projectsList.Items[projectsList.SelectedIndex] = projects[projectsList.SelectedIndex];

            nameBox.Focus();
            nameBox.SelectionStart = nameBox.Text.Length;
        }

        private void NameBox_Leave(object sender, EventArgs e)
        {
            if (updating) { return; }

            string value = nameBox.Text;
            string old = projects[projectsList.SelectedIndex];

            if (old == value) { return; }

            if (string.IsNullOrEmpty(value))
            {
                MessageBox.Show("Il nome del progetto deve esistere!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nameBox.Text = old;
                return;
            }

            Form_Update(sender, e);
        }

        private void remove_Click(object sender, EventArgs e)
        {
            updating = true;

            string name = nameBox.Text;
            projects.RemoveAt(projectsList.SelectedIndex);
            projectsList.Items.RemoveAt(projectsList.SelectedIndex);
            IO.EliminaProgetto(name);

            updating = false;
        }
    }
}
