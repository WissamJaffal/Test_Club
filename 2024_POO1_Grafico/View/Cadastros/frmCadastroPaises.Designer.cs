namespace _2024_POO1_Grafico
{
    partial class frmCadastroPaises
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
            this.txtMoeda = new System.Windows.Forms.TextBox();
            this.txtDDI = new System.Windows.Forms.TextBox();
            this.txtSigla = new System.Windows.Forms.TextBox();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.lblMoeda = new System.Windows.Forms.Label();
            this.lblDDI = new System.Windows.Forms.Label();
            this.lblSigla = new System.Windows.Forms.Label();
            this.lblPais = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.TabIndex = 6;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            // 
            // txtMoeda
            // 
            this.txtMoeda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMoeda.Location = new System.Drawing.Point(411, 25);
            this.txtMoeda.MaxLength = 4;
            this.txtMoeda.Name = "txtMoeda";
            this.txtMoeda.Size = new System.Drawing.Size(43, 20);
            this.txtMoeda.TabIndex = 4;
            // 
            // txtDDI
            // 
            this.txtDDI.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDDI.Location = new System.Drawing.Point(355, 25);
            this.txtDDI.MaxLength = 4;
            this.txtDDI.Name = "txtDDI";
            this.txtDDI.Size = new System.Drawing.Size(44, 20);
            this.txtDDI.TabIndex = 3;
            // 
            // txtSigla
            // 
            this.txtSigla.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSigla.Location = new System.Drawing.Point(273, 25);
            this.txtSigla.MaxLength = 4;
            this.txtSigla.Name = "txtSigla";
            this.txtSigla.Size = new System.Drawing.Size(34, 20);
            this.txtSigla.TabIndex = 2;
            // 
            // txtPais
            // 
            this.txtPais.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPais.Location = new System.Drawing.Point(78, 25);
            this.txtPais.MaxLength = 55;
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(189, 20);
            this.txtPais.TabIndex = 1;
            // 
            // lblMoeda
            // 
            this.lblMoeda.AutoSize = true;
            this.lblMoeda.Location = new System.Drawing.Point(408, 9);
            this.lblMoeda.Name = "lblMoeda";
            this.lblMoeda.Size = new System.Drawing.Size(40, 13);
            this.lblMoeda.TabIndex = 14;
            this.lblMoeda.Text = "Moeda";
            // 
            // lblDDI
            // 
            this.lblDDI.AutoSize = true;
            this.lblDDI.Location = new System.Drawing.Point(352, 9);
            this.lblDDI.Name = "lblDDI";
            this.lblDDI.Size = new System.Drawing.Size(26, 13);
            this.lblDDI.TabIndex = 13;
            this.lblDDI.Text = "DDI";
            // 
            // lblSigla
            // 
            this.lblSigla.AutoSize = true;
            this.lblSigla.Location = new System.Drawing.Point(270, 9);
            this.lblSigla.Name = "lblSigla";
            this.lblSigla.Size = new System.Drawing.Size(30, 13);
            this.lblSigla.TabIndex = 9;
            this.lblSigla.Text = "Sigla";
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(75, 9);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(27, 13);
            this.lblPais.TabIndex = 11;
            this.lblPais.Text = "Pais";
            // 
            // frmCadastroPaises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtMoeda);
            this.Controls.Add(this.txtDDI);
            this.Controls.Add(this.txtSigla);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.lblMoeda);
            this.Controls.Add(this.lblDDI);
            this.Controls.Add(this.lblSigla);
            this.Controls.Add(this.lblPais);
            this.Name = "frmCadastroPaises";
            this.Text = "Cadastro Paises";
            this.Load += new System.EventHandler(this.frmCadastroPaises_Load);
            this.Controls.SetChildIndex(this.lblCodigo, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.lblPais, 0);
            this.Controls.SetChildIndex(this.lblSigla, 0);
            this.Controls.SetChildIndex(this.lblDDI, 0);
            this.Controls.SetChildIndex(this.lblMoeda, 0);
            this.Controls.SetChildIndex(this.txtPais, 0);
            this.Controls.SetChildIndex(this.txtSigla, 0);
            this.Controls.SetChildIndex(this.txtDDI, 0);
            this.Controls.SetChildIndex(this.txtMoeda, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMoeda;
        private System.Windows.Forms.TextBox txtDDI;
        private System.Windows.Forms.TextBox txtSigla;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.Label lblMoeda;
        private System.Windows.Forms.Label lblDDI;
        protected System.Windows.Forms.Label lblSigla;
        protected System.Windows.Forms.Label lblPais;
    }
}
