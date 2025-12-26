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
        public char actualID;

        public frm_Indirizzi(Progetto progetto)
        {
            InitializeComponent();
            this.progetto = progetto;

            this.Text = "Indirizzi - " + progetto.nome;
            actualID = '0';
        }

        private void Frm_Indirizzi_Load(object? sender, EventArgs e)
        {
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
            }

            //id
            lbl_ID.Text = "ID: " + actualID;
        }

        private void Btn_Indirizzi_Click(object? sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                char actualID = char.Parse(btn.Text.Split(')')[0]);
                this.actualID = actualID;
            }

            Frm_Indirizzi_Load(sender, e);
        }

        private void Btn_Aggiungi_Click(object sender, EventArgs e)
        {
            progetto.indirizzi.Add(new(progetto));

            Frm_Indirizzi_Load(sender, e);
        }
    }
}
