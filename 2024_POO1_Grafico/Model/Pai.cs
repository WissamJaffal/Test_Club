using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_POO1_Grafico
{
    public class Pai
    {
        protected int codigo;
        protected string datCad;
        protected string datUltAlt;
        protected SqlConnection cnn;


        public Pai()
        {
            this.codigo = 0;
            this.datCad = null;
            this.datUltAlt = null;
            this.cnn = Banco.Abrir();
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


        public virtual string Salvar()
        {
            return "";
        }
        public virtual string Excluir()
        {
            return "";
        }

    }
}
