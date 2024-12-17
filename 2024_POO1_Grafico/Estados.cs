using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_POO1_Grafico
{
    internal class Estados : Pai
    {
        protected string estado;
        protected string uf;
        protected Paises oPais;

        public Estados() : base()
        {
            this.estado = "";
            this.uf = "";
            this.oPais = new Paises();

        }

        public Estados(int codigo, string datCad, string datUltAlt, string estado, string uf, Paises oPais):base(codigo, datCad, datUltAlt)
        {
            this.estado = estado;
            this.uf = uf;
            this.oPais = oPais;
        }
        public string Estado
        {
            get => estado;
            set => estado = value;

        }
        public string Uf
        {
            get => uf;
            set => uf = value;
        }
        public Paises OPais
        {   
            get => oPais;
            set => oPais = value; 
        }

    }

}
