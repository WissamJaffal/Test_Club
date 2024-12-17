using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _2024_POO1_Grafico
{
    public partial class frmCadastroEstados : _2024_POO1_Grafico.frmCadastros
    {
        frmConsultaPaises ofrmConsultaPais;
        Estados oEstado;
        public frmCadastroEstados()
        {
            InitializeComponent();
        }
        public override void ConhecaObj(object obj)
        {
            base.ConhecaObj(obj);
            oEstado = (Estados)obj;
        }
        public void SetConsultaPaises(Object obj)
        {
            ofrmConsultaPais = (frmConsultaPaises)obj;
        }

        private void btnPesquisarPais_Click(object sender, EventArgs e)
        {
            ofrmConsultaPais.ConhecaObj(oEstado.OPais);
            ofrmConsultaPais.ShowDialog();
        }
    }
}
