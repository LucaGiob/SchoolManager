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
            ((System.ComponentModel.ISupportInitialize)data).BeginInit();
            SuspendLayout();
            // 
            // classi
            // 
            classi.FormattingEnabled = true;
            classi.Location = new Point(10, 10);
            classi.Name = "classi";
            classi.Size = new Size(200, 364);
            classi.TabIndex = 0;
            // 
            // data
            // 
            data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data.Location = new Point(220, 10);
            data.Name = "data";
            data.RowHeadersWidth = 51;
            data.Size = new Size(570, 364);
            data.TabIndex = 1;
            // 
            // Frm_Classi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 383);
            Controls.Add(data);
            Controls.Add(classi);
            Name = "Frm_Classi";
            Text = "frm_Classi";
            Load += Frm_Classi_Load;
            ((System.ComponentModel.ISupportInitialize)data).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox classi;
        private DataGridView data;
    }
}