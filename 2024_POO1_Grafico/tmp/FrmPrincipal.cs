using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2024_POO1_Grafico
{
    public partial class FrmPrincipal : Form
    {
        Interfaces aInter;
        Paises oPais;
        Estados oEstado;

        public FrmPrincipal()
        {
            aInter = new Interfaces(); 
            oPais = new Paises();
            oEstado = new Estados();
            InitializeComponent();
        }

        private void paisesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aInter.PecaPaises(oPais);
        }

        private void estadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aInter.PecaEstados(oEstado);
        }

        private void cidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aInter.PecaCidades();
        }
    }
}
