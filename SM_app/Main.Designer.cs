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
            projectsLabel = new Label();
            linea01 = new Panel();
            projectsAdd = new Button();
            lbl_passage01B = new Label();
            btn_passage01B = new Button();
            btn_passage01C = new Button();
            lbl_passage01C = new Label();
            remove = new Button();
            projectsList = new ListBox();
            nameLabel = new Label();
            nameBox = new TextBox();
            SuspendLayout();
            // 
            // lbl_passage01A
            // 
            lbl_passage01A.Location = new Point(240, 50);
            lbl_passage01A.Name = "lbl_passage01A";
            lbl_passage01A.Size = new Size(50, 30);
            lbl_passage01A.TabIndex = 0;
            lbl_passage01A.Text = "1A";
            lbl_passage01A.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_passage01A
            // 
            btn_passage01A.Location = new Point(300, 50);
            btn_passage01A.Name = "btn_passage01A";
            btn_passage01A.Size = new Size(240, 30);
            btn_passage01A.TabIndex = 1;
            btn_passage01A.Text = "Indirizzi";
            btn_passage01A.UseVisualStyleBackColor = true;
            btn_passage01A.Click += Btn_Passage_Click;
            // 
            // projectsLabel
            // 
            projectsLabel.Location = new Point(10, 10);
            projectsLabel.Name = "projectsLabel";
            projectsLabel.Size = new Size(100, 30);
            projectsLabel.TabIndex = 2;
            projectsLabel.Text = "Progetti";
            projectsLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // linea01
            // 
            linea01.BackColor = SystemColors.GrayText;
            linea01.Location = new Point(230, 0);
            linea01.Name = "linea01";
            linea01.Size = new Size(1, 410);
            linea01.TabIndex = 11;
            // 
            // projectsAdd
            // 
            projectsAdd.Location = new Point(120, 10);
            projectsAdd.Name = "projectsAdd";
            projectsAdd.Size = new Size(100, 30);
            projectsAdd.TabIndex = 5;
            projectsAdd.Text = "Aggiungi";
            projectsAdd.UseVisualStyleBackColor = true;
            projectsAdd.Click += ProjectsAdd_Click;
            // 
            // lbl_passage01B
            // 
            lbl_passage01B.Location = new Point(240, 90);
            lbl_passage01B.Name = "lbl_passage01B";
            lbl_passage01B.Size = new Size(50, 30);
            lbl_passage01B.TabIndex = 6;
            lbl_passage01B.Text = "1B";
            lbl_passage01B.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_passage01B
            // 
            btn_passage01B.Location = new Point(300, 90);
            btn_passage01B.Name = "btn_passage01B";
            btn_passage01B.Size = new Size(240, 30);
            btn_passage01B.TabIndex = 7;
            btn_passage01B.Text = "Professori";
            btn_passage01B.UseVisualStyleBackColor = true;
            btn_passage01B.Click += Btn_Passage_Click;
            // 
            // btn_passage01C
            // 
            btn_passage01C.Location = new Point(300, 130);
            btn_passage01C.Name = "btn_passage01C";
            btn_passage01C.Size = new Size(240, 30);
            btn_passage01C.TabIndex = 9;
            btn_passage01C.Text = "Classi";
            btn_passage01C.UseVisualStyleBackColor = true;
            btn_passage01C.Click += Btn_Passage_Click;
            // 
            // lbl_passage01C
            // 
            lbl_passage01C.Location = new Point(240, 130);
            lbl_passage01C.Name = "lbl_passage01C";
            lbl_passage01C.Size = new Size(50, 30);
            lbl_passage01C.TabIndex = 8;
            lbl_passage01C.Text = "1C";
            lbl_passage01C.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // remove
            // 
            remove.Location = new Point(550, 10);
            remove.Name = "remove";
            remove.Size = new Size(100, 30);
            remove.TabIndex = 10;
            remove.Text = "Rimuovi";
            remove.UseVisualStyleBackColor = true;
            remove.Click += remove_Click;
            // 
            // projectsList
            // 
            projectsList.FormattingEnabled = true;
            projectsList.Location = new Point(10, 50);
            projectsList.Name = "projectsList";
            projectsList.Size = new Size(210, 344);
            projectsList.TabIndex = 12;
            projectsList.SelectedIndexChanged += projectsList_SelectedIndexChanged;
            // 
            // nameLabel
            // 
            nameLabel.Location = new Point(240, 10);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(100, 30);
            nameLabel.TabIndex = 13;
            nameLabel.Text = "Nome";
            nameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // nameBox
            // 
            nameBox.Location = new Point(350, 11);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(190, 27);
            nameBox.TabIndex = 14;
            nameBox.TextChanged += nameBox_TextChanged;
            nameBox.Leave += NameBox_Leave;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(662, 403);
            Controls.Add(nameBox);
            Controls.Add(nameLabel);
            Controls.Add(projectsList);
            Controls.Add(remove);
            Controls.Add(btn_passage01C);
            Controls.Add(lbl_passage01C);
            Controls.Add(btn_passage01B);
            Controls.Add(lbl_passage01B);
            Controls.Add(projectsAdd);
            Controls.Add(linea01);
            Controls.Add(projectsLabel);
            Controls.Add(btn_passage01A);
            Controls.Add(lbl_passage01A);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestione orario";
            Load += Form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_passage01A;
        private Button btn_passage01A;
        private Label projectsLabel;
        private Panel linea01;
        private Button projectsAdd;
        private Label lbl_passage01B;
        private Button btn_passage01B;
        private Button btn_passage01C;
        private Label lbl_passage01C;
        private Button remove;
        private ListBox projectsList;
        private Label nameLabel;
        private TextBox nameBox;
    }
}
