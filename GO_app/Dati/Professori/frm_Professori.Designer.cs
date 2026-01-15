namespace GO_app.Dati.Professori
{
    partial class frm_Professori
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
            btn_aggiungi = new Button();
            btn_prima = new Button();
            lbl_ID = new Label();
            btn_dopo = new Button();
            lbl_nome = new Label();
            lbl_extra = new Label();
            tbx_nome = new TextBox();
            textBox2 = new TextBox();
            btn_elimina = new Button();
            SuspendLayout();
            // 
            // btn_aggiungi
            // 
            btn_aggiungi.Location = new Point(10, 10);
            btn_aggiungi.Name = "btn_aggiungi";
            btn_aggiungi.Size = new Size(220, 30);
            btn_aggiungi.TabIndex = 0;
            btn_aggiungi.Text = "Aggiungi";
            btn_aggiungi.UseVisualStyleBackColor = true;
            // 
            // btn_prima
            // 
            btn_prima.Location = new Point(240, 10);
            btn_prima.Name = "btn_prima";
            btn_prima.Size = new Size(30, 30);
            btn_prima.TabIndex = 1;
            btn_prima.Text = "-";
            btn_prima.UseVisualStyleBackColor = true;
            // 
            // lbl_ID
            // 
            lbl_ID.Location = new Point(280, 10);
            lbl_ID.Name = "lbl_ID";
            lbl_ID.Size = new Size(50, 30);
            lbl_ID.TabIndex = 2;
            lbl_ID.Text = "0";
            lbl_ID.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_dopo
            // 
            btn_dopo.Location = new Point(340, 10);
            btn_dopo.Name = "btn_dopo";
            btn_dopo.Size = new Size(30, 30);
            btn_dopo.TabIndex = 3;
            btn_dopo.Text = "+";
            btn_dopo.UseVisualStyleBackColor = true;
            // 
            // lbl_nome
            // 
            lbl_nome.Location = new Point(10, 50);
            lbl_nome.Name = "lbl_nome";
            lbl_nome.Size = new Size(70, 30);
            lbl_nome.TabIndex = 4;
            lbl_nome.Text = "Nome";
            lbl_nome.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_extra
            // 
            lbl_extra.Location = new Point(240, 50);
            lbl_extra.Name = "lbl_extra";
            lbl_extra.Size = new Size(70, 30);
            lbl_extra.TabIndex = 5;
            lbl_extra.Text = "Ore extra";
            lbl_extra.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbx_nome
            // 
            tbx_nome.Location = new Point(90, 50);
            tbx_nome.Name = "tbx_nome";
            tbx_nome.Size = new Size(140, 27);
            tbx_nome.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(320, 50);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(140, 27);
            textBox2.TabIndex = 7;
            // 
            // btn_elimina
            // 
            btn_elimina.Location = new Point(380, 10);
            btn_elimina.Name = "btn_elimina";
            btn_elimina.Size = new Size(80, 30);
            btn_elimina.TabIndex = 8;
            btn_elimina.Text = "Elimina";
            btn_elimina.UseVisualStyleBackColor = true;
            // 
            // frm_Professori
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 93);
            Controls.Add(btn_elimina);
            Controls.Add(textBox2);
            Controls.Add(tbx_nome);
            Controls.Add(lbl_extra);
            Controls.Add(lbl_nome);
            Controls.Add(btn_dopo);
            Controls.Add(lbl_ID);
            Controls.Add(btn_prima);
            Controls.Add(btn_aggiungi);
            Name = "frm_Professori";
            Text = "frm_Professori";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_aggiungi;
        private Button btn_prima;
        private Label lbl_ID;
        private Button btn_dopo;
        private Label lbl_nome;
        private Label lbl_extra;
        private TextBox tbx_nome;
        private TextBox textBox2;
        private Button btn_elimina;
    }
}