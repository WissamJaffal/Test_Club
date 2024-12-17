using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _2024_POO1_Grafico
{
    public partial class FrmConsultas : _2024_POO1_Grafico.Frm
    {
        public FrmConsultas()
        {
            InitializeComponent();
        }
        public virtual void Incluir()
        { 
        }
        public virtual void Alterar()
        { 
        
        }
        public virtual void Excluir()
        {

        }
        public virtual void CarregaLV()
        {

        }
        public virtual void setCadastro(object obj)
        { 
        
        }
        private void btnIncluir_Click(object sender, EventArgs e)
        {
            Incluir();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Alterar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Excluir();
        }
    }
}
