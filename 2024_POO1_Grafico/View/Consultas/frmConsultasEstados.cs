using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _2024_POO1_Grafico
{
    public partial class frmConsultasEstados : _2024_POO1_Grafico.FrmConsultas
    {
        frmCadastroEstados ofrmCadastroEstado;
        Estados oEstado;
        public override void ConhecaObj(object obj)
        {
            base.ConhecaObj(obj);
            oEstado = (Estados)obj;
        }
        public frmConsultasEstados()
        {
            InitializeComponent();
        }
        public override void Incluir()
        {
            base.Incluir();
            ofrmCadastroEstado.ConhecaObj(oEstado);
            ofrmCadastroEstado.ShowDialog();
        }
        public override void Alterar()
        {
            base.Alterar();
            ofrmCadastroEstado.ConhecaObj(oEstado);
            ofrmCadastroEstado.ShowDialog();
        }
        public override void Excluir()
        {
            base.Excluir();
            ofrmCadastroEstado.ShowDialog();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {

        }
        public void setCadastro(Object obj)
        {
            ofrmCadastroEstado = (frmCadastroEstados)obj;
        }

        private void frmConsultasEstados_Load(object sender, EventArgs e)
        {

        }
    }
}
