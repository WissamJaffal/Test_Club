using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _2024_POO1_Grafico
{
    public partial class frmCadastroPaises : _2024_POO1_Grafico.frmCadastros
    {
        Paises oPais;
        public frmCadastroPaises()
        {
            InitializeComponent();
        }

        public override void ConhecaObj(object obj)
        {
            base.ConhecaObj(obj);
            oPais = (Paises)obj;
        }

        public override void Salvar()
        {
            oPais.Codigo = Convert.ToInt32(txtCodigo.Text);
            oPais.Pais =  this.txtPais.Text;
            oPais.Sigla = txtSigla.Text;
            oPais.Ddi = txtDDI.Text;
            oPais.Moeda = txtMoeda.Text;
        }
        public override void LimpaTxt()
        {
            this.txtCodigo.Clear();
            this.txtPais.Clear();
            this.txtSigla.Clear();
            this.txtDDI.Clear();
            this.txtMoeda.Clear();
        }
        public override void CarregaTxt()
        {
            this.txtCodigo.Text = "0";
            this.txtPais.Text   = oPais.Pais;
            this.txtSigla.Text  = oPais.Sigla;
            this.txtDDI.Text    = oPais.Ddi;
            this.txtMoeda.Text  = oPais.Moeda;
        }
        public override void BloqueiaTxt()
        {
            this.txtCodigo.Enabled = false;
            this.txtPais.Enabled = false;
            this.txtSigla.Enabled = false;
            this.txtDDI.Enabled = false;
            this.txtMoeda.Enabled = false;
        }

        public override void DesbloqueiaTxt()
        {
            this.txtCodigo.Enabled = true;
            this.txtPais.Enabled = true;
            this.txtSigla.Enabled = true;
            this.txtDDI.Enabled = true;
            this.txtMoeda.Enabled=true;
        }

    }
}
