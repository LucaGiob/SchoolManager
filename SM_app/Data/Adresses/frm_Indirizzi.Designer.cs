namespace SM_app.Data.Adresses
{
    partial class Frm_Indirizzi
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
            btn_Aggiungi = new Button();
            btn_Elimina = new Button();
            linea01 = new Panel();
            lbl_ID = new Label();
            lbl_nome = new Label();
            txb_nome = new TextBox();
            btn_aggiungiPiano = new Button();
            indirizzi = new ListBox();
            materie = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)materie).BeginInit();
            SuspendLayout();
            // 
            // btn_Aggiungi
            // 
            btn_Aggiungi.Location = new Point(10, 10);
            btn_Aggiungi.Name = "btn_Aggiungi";
            btn_Aggiungi.Size = new Size(80, 30);
            btn_Aggiungi.TabIndex = 0;
            btn_Aggiungi.Text = "Aggiungi";
            btn_Aggiungi.UseVisualStyleBackColor = true;
            btn_Aggiungi.Click += Btn_Aggiungi_Click;
            // 
            // btn_Elimina
            // 
            btn_Elimina.Location = new Point(100, 10);
            btn_Elimina.Name = "btn_Elimina";
            btn_Elimina.Size = new Size(80, 30);
            btn_Elimina.TabIndex = 1;
            btn_Elimina.Text = "Elimina";
            btn_Elimina.UseVisualStyleBackColor = true;
            btn_Elimina.Click += Btn_Elimina_Click;
            // 
            // linea01
            // 
            linea01.BackColor = SystemColors.GrayText;
            linea01.Location = new Point(190, 0);
            linea01.Name = "linea01";
            linea01.Size = new Size(1, 650);
            linea01.TabIndex = 2;
            // 
            // lbl_ID
            // 
            lbl_ID.Location = new Point(200, 10);
            lbl_ID.Name = "lbl_ID";
            lbl_ID.Size = new Size(50, 30);
            lbl_ID.TabIndex = 4;
            lbl_ID.Text = "ID:";
            lbl_ID.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_nome
            // 
            lbl_nome.Location = new Point(260, 10);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(60, 30);
            lbl_nome.TabIndex = 5;
            lbl_nome.Text = "Nome:";
            lbl_nome.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txb_nome
            // 
            txb_nome.Location = new Point(330, 10);
            txb_nome.Name = "txb_nome";
            txb_nome.Size = new Size(150, 27);
            txb_nome.TabIndex = 6;
            txb_nome.TextChanged += Txb_nome_TextChanged;
            // 
            // btn_aggiungiPiano
            // 
            btn_aggiungiPiano.Location = new Point(500, 10);
            btn_aggiungiPiano.Name = "btn_aggiungiPiano";
            btn_aggiungiPiano.Size = new Size(200, 30);
            btn_aggiungiPiano.TabIndex = 19;
            btn_aggiungiPiano.Text = "Aggiungi materia";
            btn_aggiungiPiano.UseVisualStyleBackColor = true;
            btn_aggiungiPiano.Click += Btn_aggiungiPiano_Click;
            // 
            // indirizzi
            // 
            indirizzi.FormattingEnabled = true;
            indirizzi.Location = new Point(10, 50);
            indirizzi.Name = "indirizzi";
            indirizzi.Size = new Size(170, 584);
            indirizzi.TabIndex = 20;
            indirizzi.SelectedIndexChanged += indirizzi_SelectedIndexChanged;
            // 
            // materie
            // 
            materie.AllowUserToAddRows = false;
            materie.AllowUserToResizeColumns = false;
            materie.AllowUserToResizeRows = false;
            materie.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            materie.EditMode = DataGridViewEditMode.EditOnEnter;
            materie.Location = new Point(200, 50);
            materie.Name = "materie";
            materie.RowHeadersWidth = 51;
            materie.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            materie.Size = new Size(500, 584);
            materie.TabIndex = 21;
            // 
            // Frm_Indirizzi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(707, 643);
            Controls.Add(materie);
            Controls.Add(indirizzi);
            Controls.Add(btn_aggiungiPiano);
            Controls.Add(txb_nome);
            Controls.Add(lbl_nome);
            Controls.Add(lbl_ID);
            Controls.Add(linea01);
            Controls.Add(btn_Elimina);
            Controls.Add(btn_Aggiungi);
            Name = "Frm_Indirizzi";
            StartPosition = FormStartPosition.CenterScreen;
            FormClosing += Frm_Indirizzi_Closing;
            Load += Frm_Indirizzi_Load;
            ((System.ComponentModel.ISupportInitialize)materie).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Aggiungi;
        private Button btn_Elimina;
        private Panel linea01;
        private Label lbl_ID;
        private Label lbl_nome;
        private TextBox txb_nome;
        private Button btn_aggiungiPiano;
        private ListBox indirizzi;
        private DataGridView materie;
    }
}