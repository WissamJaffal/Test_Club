using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _2024_POO1_Grafico
{
    public partial class frmCadastros : _2024_POO1_Grafico.Frm
    {
        public frmCadastros()
        {
            InitializeComponent();
        }
        public virtual void Salvar()
        {
            
        }
        public virtual void LimpaTxt()
        { 
            this.txtCodigo.Clear();
        }
        public virtual void CarregaTxt()
        {
            this.txtCodigo.Text = "0";
        }
        public virtual void BloqueiaTxt()
        { 
            this.txtCodigo.Enabled = false;
        }

        public virtual void DesbloqueiaTxt()
        {
            this.txtCodigo.Enabled = true;
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }
    }
}
