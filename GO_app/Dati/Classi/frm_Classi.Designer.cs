namespace GO_app.Dati.Classi
{
    partial class Frm_Classi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            classi = new ListBox();
            data = new DataGridView();
            btn_aggiungi = new Button();
            txb_nome = new TextBox();
            lbl_nome = new Label();
            lbl_indirizzo = new Label();
            cmb_indirizzo = new ComboBox();
            btn_elimina = new Button();
            ((System.ComponentModel.ISupportInitialize)data).BeginInit();
            SuspendLayout();
            // 
            // classi
            // 
            classi.FormattingEnabled = true;
            classi.Location = new Point(10, 50);
            classi.Name = "classi";
            classi.Size = new Size(200, 364);
            classi.TabIndex = 0;
            classi.SelectedIndexChanged += classi_SelectedIndexChanged;
            // 
            // data
            // 
            data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data.Location = new Point(220, 50);
            data.Name = "data";
            data.RowHeadersWidth = 51;
            data.Size = new Size(570, 364);
            data.TabIndex = 1;
            // 
            // btn_aggiungi
            // 
            btn_aggiungi.Location = new Point(10, 10);
            btn_aggiungi.Name = "btn_aggiungi";
            btn_aggiungi.Size = new Size(200, 30);
            btn_aggiungi.TabIndex = 2;
            btn_aggiungi.Text = "Aggiungi classe";
            btn_aggiungi.UseVisualStyleBackColor = true;
            btn_aggiungi.Click += Btn_aggiungi_Click;
            // 
            // txb_nome
            // 
            txb_nome.Location = new Point(290, 11);
            txb_nome.Name = "txb_nome";
            txb_nome.Size = new Size(125, 27);
            txb_nome.TabIndex = 3;
            txb_nome.TextChanged += txb_nome_TextChanged;
            // 
            // lbl_nome
            // 
            lbl_nome.Location = new Point(220, 10);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(60, 30);
            lbl_nome.TabIndex = 4;
            lbl_nome.Text = "Nome";
            lbl_nome.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_indirizzo
            // 
            lbl_indirizzo.Location = new Point(430, 10);
            lbl_indirizzo.Name = "lbl_indirizzo";
            lbl_indirizzo.Size = new Size(70, 30);
            lbl_indirizzo.TabIndex = 5;
            lbl_indirizzo.Text = "Indirizzo";
            lbl_indirizzo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmb_indirizzo
            // 
            cmb_indirizzo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_indirizzo.FormattingEnabled = true;
            cmb_indirizzo.Location = new Point(510, 11);
            cmb_indirizzo.Name = "cmb_indirizzo";
            cmb_indirizzo.Size = new Size(160, 28);
            cmb_indirizzo.TabIndex = 6;
            cmb_indirizzo.SelectedIndexChanged += cmb_indirizzo_SelectedIndexChanged;
            // 
            // btn_elimina
            // 
            btn_elimina.Location = new Point(680, 10);
            btn_elimina.Name = "btn_elimina";
            btn_elimina.Size = new Size(110, 30);
            btn_elimina.TabIndex = 7;
            btn_elimina.Text = "Elimina";
            btn_elimina.UseVisualStyleBackColor = true;
            btn_elimina.Click += btn_elimina_Click;
            // 
            // Frm_Classi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 423);
            Controls.Add(btn_elimina);
            Controls.Add(cmb_indirizzo);
            Controls.Add(lbl_indirizzo);
            Controls.Add(lbl_nome);
            Controls.Add(txb_nome);
            Controls.Add(btn_aggiungi);
            Controls.Add(data);
            Controls.Add(classi);
            Name = "Frm_Classi";
            Text = "frm_Classi";
            FormClosing += Frm_Classi_Closing;
            Load += Frm_Classi_Load;
            ((System.ComponentModel.ISupportInitialize)data).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox classi;
        private DataGridView data;
        private Button btn_aggiungi;
        private TextBox txb_nome;
        private Label lbl_nome;
        private Label lbl_indirizzo;
        private ComboBox cmb_indirizzo;
        private Button btn_elimina;
    }
}