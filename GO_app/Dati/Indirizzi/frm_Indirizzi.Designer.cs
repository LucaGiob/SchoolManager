namespace GO_app.Dati.Indirizzi
{
    partial class frm_Indirizzi
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
            linea02 = new Panel();
            lbl_ID = new Label();
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
            // 
            // linea01
            // 
            linea01.BackColor = SystemColors.GrayText;
            linea01.Location = new Point(190, 0);
            linea01.Name = "linea01";
            linea01.Size = new Size(1, 450);
            linea01.TabIndex = 2;
            // 
            // linea02
            // 
            linea02.BackColor = SystemColors.GrayText;
            linea02.Location = new Point(0, 50);
            linea02.Name = "linea02";
            linea02.Size = new Size(190, 1);
            linea02.TabIndex = 3;
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
            // frm_Indirizzi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 453);
            Controls.Add(lbl_ID);
            Controls.Add(linea02);
            Controls.Add(linea01);
            Controls.Add(btn_Elimina);
            Controls.Add(btn_Aggiungi);
            Name = "frm_Indirizzi";
            Load += Frm_Indirizzi_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Aggiungi;
        private Button btn_Elimina;
        private Panel linea01;
        private Panel linea02;
        private Label lbl_ID;
    }
}