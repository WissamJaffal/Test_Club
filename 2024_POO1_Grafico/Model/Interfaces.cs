using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_POO1_Grafico
{
    internal class Interfaces
    {
        protected frmConsultaPaises ofrmConPaises;
        protected frmConsultasEstados ofrmConEstados;
        protected frmConsultasCidades ofrmConCidades;

        protected frmCadastroPaises ofrmCadPaises;
        protected frmCadastroEstados ofrmCadEstados;
        public Interfaces()
        {
            ofrmConEstados = new frmConsultasEstados(); 
            ofrmConPaises = new frmConsultaPaises();
            ofrmConCidades = new frmConsultasCidades();

            ofrmCadPaises = new frmCadastroPaises();
            ofrmCadEstados = new frmCadastroEstados();

            ofrmConPaises.setCadastro(ofrmCadPaises);
            ofrmConEstados.setCadastro(ofrmCadEstados);

            ofrmCadEstados.SetConsultaPaises(ofrmConPaises);
           
        }
        public void PecaPaises(Paises oPais)
        { 
           ofrmConPaises.ConhecaObj(oPais);
           ofrmConPaises.ShowDialog();
        }

        public void PecaEstados(Estados oEstado)
        {
            ofrmConEstados.ConhecaObj(oEstado);
            ofrmConEstados.ShowDialog();
        }
        public void PecaCidades()
        { 
            ofrmConCidades.ShowDialog();
        }
    }
}
