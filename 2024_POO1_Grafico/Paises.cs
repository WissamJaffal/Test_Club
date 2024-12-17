using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_POO1_Grafico
{
    internal class Paises:Pai
    {
        protected string pais;
        protected string sigla;
        protected string ddi;
        protected string moeda;
        public Paises():base()
        {
            this.pais = "";
            this.sigla = "";
            this.ddi = "";
            this.moeda = "";
        }
        public Paises(int codigo, string datCad, string datUltAlt,string pais, string sigla, string ddi, string moeda):base(codigo, datCad, datUltAlt)
        {
            this.pais = pais;
            this.sigla = sigla;
            this.ddi = ddi;
            this.moeda = moeda;
        }
        public string Pais
        {
            get => this.pais;
            set => this.pais = value;

        }
        public string Sigla
        {
            get => this.sigla;
            set => this.sigla = value;
        }
        public string Ddi
        {
            get => this.ddi;
            set => this.ddi = value;
        }
        public string Moeda
        {
            get => this.moeda;
            set => this.moeda = value;
        }
        public Paises Clone()
        {
            Paises oPais = new Paises(this.codigo, this.datCad, this.datUltAlt, this.pais, this.sigla, this.ddi, this.moeda);
            return oPais;
        }
    }
}
