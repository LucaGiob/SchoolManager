namespace SM_app
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_passage01A = new Label();
            btn_passage01A = new Button();
            lbl_progetto = new Label();
            cmb_progetto = new ComboBox();
            linea01 = new Panel();
            btn_aggiungiProgetto = new Button();
            lbl_passage01B = new Label();
            btn_passage01B = new Button();
            btn_passage01C = new Button();
            lbl_passage01C = new Label();
            SuspendLayout();
            // 
            // lbl_passage01A
            // 
            lbl_passage01A.Location = new Point(10, 60);
            lbl_passage01A.Name = "lbl_passage01A";
            lbl_passage01A.Size = new Size(50, 30);
            lbl_passage01A.TabIndex = 0;
            lbl_passage01A.Text = "1A";
            lbl_passage01A.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_passage01A
            // 
            btn_passage01A.Location = new Point(70, 60);
            btn_passage01A.Name = "btn_passage01A";
            btn_passage01A.Size = new Size(240, 30);
            btn_passage01A.TabIndex = 1;
            btn_passage01A.Text = "Indirizzi";
            btn_passage01A.UseVisualStyleBackColor = true;
            btn_passage01A.Click += Btn_Passage_Click;
            // 
            // lbl_progetto
            // 
            lbl_progetto.Location = new Point(8, 9);
            lbl_progetto.Name = "lbl_progetto";
            lbl_progetto.Size = new Size(70, 30);
            lbl_progetto.TabIndex = 2;
            lbl_progetto.Text = "Progetto";
            lbl_progetto.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmb_progetto
            // 
            cmb_progetto.FormattingEnabled = true;
            cmb_progetto.Location = new Point(90, 10);
            cmb_progetto.Name = "cmb_progetto";
            cmb_progetto.Size = new Size(180, 28);
            cmb_progetto.TabIndex = 3;
            // 
            // linea01
            // 
            linea01.BackColor = SystemColors.GrayText;
            linea01.Location = new Point(0, 50);
            linea01.Name = "linea01";
            linea01.Size = new Size(330, 1);
            linea01.TabIndex = 4;
            // 
            // btn_aggiungiProgetto
            // 
            btn_aggiungiProgetto.Location = new Point(280, 10);
            btn_aggiungiProgetto.Name = "btn_aggiungiProgetto";
            btn_aggiungiProgetto.Size = new Size(30, 30);
            btn_aggiungiProgetto.TabIndex = 5;
            btn_aggiungiProgetto.Text = "+";
            btn_aggiungiProgetto.UseVisualStyleBackColor = true;
            btn_aggiungiProgetto.Click += Btn_aggiungiProgetto_Click;
            // 
            // lbl_passage01B
            // 
            lbl_passage01B.Location = new Point(10, 100);
            lbl_passage01B.Name = "lbl_passage01B";
            lbl_passage01B.Size = new Size(50, 30);
            lbl_passage01B.TabIndex = 6;
            lbl_passage01B.Text = "1B";
            lbl_passage01B.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_passage01B
            // 
            btn_passage01B.Location = new Point(70, 100);
            btn_passage01B.Name = "btn_passage01B";
            btn_passage01B.Size = new Size(240, 30);
            btn_passage01B.TabIndex = 7;
            btn_passage01B.Text = "Professori";
            btn_passage01B.UseVisualStyleBackColor = true;
            btn_passage01B.Click += Btn_Passage_Click;
            // 
            // btn_passage01C
            // 
            btn_passage01C.Location = new Point(70, 140);
            btn_passage01C.Name = "btn_passage01C";
            btn_passage01C.Size = new Size(240, 30);
            btn_passage01C.TabIndex = 9;
            btn_passage01C.Text = "Classi";
            btn_passage01C.UseVisualStyleBackColor = true;
            btn_passage01C.Click += Btn_Passage_Click;
            // 
            // lbl_passage01C
            // 
            lbl_passage01C.Location = new Point(10, 140);
            lbl_passage01C.Name = "lbl_passage01C";
            lbl_passage01C.Size = new Size(50, 30);
            lbl_passage01C.TabIndex = 8;
            lbl_passage01C.Text = "1C";
            lbl_passage01C.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(322, 183);
            Controls.Add(btn_passage01C);
            Controls.Add(lbl_passage01C);
            Controls.Add(btn_passage01B);
            Controls.Add(lbl_passage01B);
            Controls.Add(btn_aggiungiProgetto);
            Controls.Add(linea01);
            Controls.Add(cmb_progetto);
            Controls.Add(lbl_progetto);
            Controls.Add(btn_passage01A);
            Controls.Add(lbl_passage01A);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestione orario";
            Load += Form_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label lbl_passage01A;
        private Button btn_passage01A;
        private Label lbl_progetto;
        private ComboBox cmb_progetto;
        private Panel linea01;
        private Button btn_aggiungiProgetto;
        private Label lbl_passage01B;
        private Button btn_passage01B;
        private Button btn_passage01C;
        private Label lbl_passage01C;
    }
}
