namespace _2024_POO1_Grafico
{
    partial class frmCadastroEstados
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
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblUF = new System.Windows.Forms.Label();
            this.lblCodPais = new System.Windows.Forms.Label();
            this.lblPais = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.txtCodPais = new System.Windows.Forms.TextBox();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.btnPesquisarPais = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(77, 9);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(40, 13);
            this.lblEstado.TabIndex = 6;
            this.lblEstado.Text = "Estado";
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(245, 9);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(21, 13);
            this.lblUF.TabIndex = 7;
            this.lblUF.Text = "UF";
            // 
            // lblCodPais
            // 
            this.lblCodPais.AutoSize = true;
            this.lblCodPais.Location = new System.Drawing.Point(300, 9);
            this.lblCodPais.Name = "lblCodPais";
            this.lblCodPais.Size = new System.Drawing.Size(40, 13);
            this.lblCodPais.TabIndex = 8;
            this.lblCodPais.Text = "Codigo";
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(356, 9);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(27, 13);
            this.lblPais.TabIndex = 9;
            this.lblPais.Text = "Pais";
            // 
            // txtEstado
            // 
            this.txtEstado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEstado.Location = new System.Drawing.Point(80, 25);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(113, 20);
            this.txtEstado.TabIndex = 10;
            // 
            // txtUF
            // 
            this.txtUF.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUF.Location = new System.Drawing.Point(240, 25);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(40, 20);
            this.txtUF.TabIndex = 11;
            // 
            // txtCodPais
            // 
            this.txtCodPais.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodPais.Location = new System.Drawing.Point(303, 25);
            this.txtCodPais.Name = "txtCodPais";
            this.txtCodPais.Size = new System.Drawing.Size(32, 20);
            this.txtCodPais.TabIndex = 12;
            // 
            // txtPais
            // 
            this.txtPais.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPais.Location = new System.Drawing.Point(359, 25);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(100, 20);
            this.txtPais.TabIndex = 13;
            // 
            // btnPesquisarPais
            // 
            this.btnPesquisarPais.Location = new System.Drawing.Point(478, 22);
            this.btnPesquisarPais.Name = "btnPesquisarPais";
            this.btnPesquisarPais.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisarPais.TabIndex = 14;
            this.btnPesquisarPais.Text = "Pesquisar";
            this.btnPesquisarPais.UseVisualStyleBackColor = true;
            this.btnPesquisarPais.Click += new System.EventHandler(this.btnPesquisarPais_Click);
            // 
            // frmCadastroEstados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPesquisarPais);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.txtCodPais);
            this.Controls.Add(this.txtUF);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.lblPais);
            this.Controls.Add(this.lblCodPais);
            this.Controls.Add(this.lblUF);
            this.Controls.Add(this.lblEstado);
            this.Name = "frmCadastroEstados";
            this.Controls.SetChildIndex(this.lblCodigo, 0);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.lblEstado, 0);
            this.Controls.SetChildIndex(this.lblUF, 0);
            this.Controls.SetChildIndex(this.lblCodPais, 0);
            this.Controls.SetChildIndex(this.lblPais, 0);
            this.Controls.SetChildIndex(this.txtEstado, 0);
            this.Controls.SetChildIndex(this.txtUF, 0);
            this.Controls.SetChildIndex(this.txtCodPais, 0);
            this.Controls.SetChildIndex(this.txtPais, 0);
            this.Controls.SetChildIndex(this.btnPesquisarPais, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.Label lblCodPais;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.TextBox txtCodPais;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Button btnPesquisarPais;
    }
}
