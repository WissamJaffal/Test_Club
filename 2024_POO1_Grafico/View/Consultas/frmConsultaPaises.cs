using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _2024_POO1_Grafico
{
    public partial class frmConsultaPaises : _2024_POO1_Grafico.FrmConsultas
    {
        frmCadastroPaises oFrmCadPaises;
        Paises oPais;

        public frmConsultaPaises()
        {
            InitializeComponent();
        }
        public override void Incluir()
        {
            base.Incluir();
            oFrmCadPaises.LimpaTxt();
            oFrmCadPaises.ConhecaObj(oPais);
            oFrmCadPaises.ShowDialog();
            this.CarregaLV();
        }
        public override void Alterar()
        {
            base.Alterar();
            oFrmCadPaises.ConhecaObj(oPais);
            oFrmCadPaises.LimpaTxt();
            oFrmCadPaises.CarregaTxt();
            oFrmCadPaises.ShowDialog();
        }
        public override void Excluir()
        { 
            base.Excluir();
            oFrmCadPaises.ConhecaObj(oPais);
            oFrmCadPaises.LimpaTxt();
            oFrmCadPaises.CarregaTxt();
            oFrmCadPaises.BloqueiaTxt();
            oFrmCadPaises.ShowDialog();
            oFrmCadPaises.DesbloqueiaTxt();
        }
        public override void CarregaLV()
        {
            base.CarregaLV();
            ListViewItem item = new ListViewItem(Convert.ToString(oPais.Codigo));
            item.SubItems.Add(oPais.Pais);
            item.SubItems.Add(oPais.Sigla);
            item.SubItems.Add(oPais.Ddi);
            item.SubItems.Add(oPais.Moeda);
            this.LView.Items.Add(item);
        }
        public override void setCadastro(object obj)
        {
            oFrmCadPaises = (frmCadastroPaises)obj;
        }
        public override void ConhecaObj(object obj)
        {
            base.ConhecaObj(obj);
            oPais = (Paises)obj;
        }

        private void frmConsultaPaises_Load(object sender, EventArgs e)
        {

        }
    }
}
