namespace _2024_POO1_Grafico
{
    partial class frmConsultaPaises
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
            this.codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pais = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sigla = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ddi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Moeda = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // LView
            // 
            this.LView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.codigo,
            this.Pais,
            this.Sigla,
            this.Ddi,
            this.Moeda});
            this.LView.View = System.Windows.Forms.View.Details;
            // 
            // codigo
            // 
            this.codigo.Text = "Código";
            // 
            // Pais
            // 
            this.Pais.Text = "Pais";
            this.Pais.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Pais.Width = 200;
            // 
            // Sigla
            // 
            this.Sigla.Text = "Sigla";
            this.Sigla.Width = 40;
            // 
            // Ddi
            // 
            this.Ddi.Text = "DDI";
            this.Ddi.Width = 40;
            // 
            // Moeda
            // 
            this.Moeda.Text = "Moeda";
            // 
            // frmConsultaPaises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "frmConsultaPaises";
            this.Text = "Consultas Paises";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader codigo;
        private System.Windows.Forms.ColumnHeader Pais;
        private System.Windows.Forms.ColumnHeader Sigla;
        private System.Windows.Forms.ColumnHeader Ddi;
        private System.Windows.Forms.ColumnHeader Moeda;
    }
}
