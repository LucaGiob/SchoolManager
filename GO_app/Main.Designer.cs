namespace GO_app
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
            SuspendLayout();
            // 
            // lbl_passage01A
            // 
            lbl_passage01A.Location = new Point(10, 10);
            lbl_passage01A.Name = "lbl_passage01A";
            lbl_passage01A.Size = new Size(50, 30);
            lbl_passage01A.TabIndex = 0;
            lbl_passage01A.Text = "1A";
            lbl_passage01A.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_passage01A
            // 
            btn_passage01A.Location = new Point(70, 10);
            btn_passage01A.Name = "btn_passage01A";
            btn_passage01A.Size = new Size(200, 30);
            btn_passage01A.TabIndex = 1;
            btn_passage01A.Text = "Indirizzi";
            btn_passage01A.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(282, 153);
            Controls.Add(btn_passage01A);
            Controls.Add(lbl_passage01A);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestione orario";
            ResumeLayout(false);
        }

        #endregion

        private Label lbl_passage01A;
        private Button btn_passage01A;
    }
}
