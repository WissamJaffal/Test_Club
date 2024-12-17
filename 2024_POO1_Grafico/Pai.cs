using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_POO1_Grafico
{
    internal class Pai
    {
        protected int codigo;
        protected string datCad;
        protected string datUltAlt;
       

        public Pai()
        {
            this.codigo = 0;
            this.datCad = null;
            this.datUltAlt = null;
        }
        public Pai(int codigo, string datCad, string datUltAlt)
        {
            this.codigo = codigo;
            this.datCad = datCad;
            this.datUltAlt = datUltAlt;
        }
        public int Codigo
        {
            get
            {
                return this.codigo;
            }
            set
            {
                this.codigo = value;
            }
        }
        public string DatCad
        {
            get => this.datCad;
            set => this.datCad = value;
        }
        public string DatUltAlt
        {
            get => this.datUltAlt;
            set => this.datUltAlt = value;
        }
    }
}
