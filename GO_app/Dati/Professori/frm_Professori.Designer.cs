using System.Windows.Forms;

namespace GO_app.Dati.Professori
{
    partial class Frm_Professori
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
            data = new DataGridView();
            btn_aggiungi = new Button();
            ((System.ComponentModel.ISupportInitialize)data).BeginInit();
            SuspendLayout();
            // 
            // data
            // 
            data.AllowUserToAddRows = false;
            data.AllowUserToResizeColumns = false;
            data.AllowUserToResizeRows = false;
            data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data.EditMode = DataGridViewEditMode.EditOnEnter;
            data.Location = new Point(10, 50);
            data.Name = "data";
            data.RowHeadersWidth = 51;
            data.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            data.Size = new Size(500, 500);
            data.TabIndex = 9;
            // 
            // btn_aggiungi
            // 
            btn_aggiungi.Location = new Point(10, 10);
            btn_aggiungi.Name = "btn_aggiungi";
            btn_aggiungi.Size = new Size(500, 30);
            btn_aggiungi.TabIndex = 0;
            btn_aggiungi.Text = "Aggiungi";
            btn_aggiungi.UseVisualStyleBackColor = true;
            btn_aggiungi.Click += Btn_aggiungi_Click;
            // 
            // Frm_Professori
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 563);
            Controls.Add(data);
            Controls.Add(btn_aggiungi);
            MinimumSize = new Size(400, 200);
            Name = "Frm_Professori";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frm_Professori";
            FormClosing += Form_Closing;
            Load += Form_Load;
            Resize += Form_Resize;
            ((System.ComponentModel.ISupportInitialize)data).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView data;
        private Button btn_aggiungi;
    }
}