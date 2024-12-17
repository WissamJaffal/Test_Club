using System;
using System.Data.SqlClient;

namespace _2024_POO1_Grafico
{
    public class Paises : Pai
    {
        // Atributos privados com propriedades públicas
        private string pais;
        private string sigla;
        private string ddi;
        private string moeda;

        // Construtor padrão
        public Paises() : base()
        {
            this.pais = "";
            this.sigla = "";
            this.ddi = "";
            this.moeda = "";
        }

        // Construtor com parâmetros
        public Paises(int codigo, string datCad, string datUltAlt, string pais, string sigla, string ddi, string moeda)
            : base(codigo, datCad, datUltAlt)
        {
            this.Pais = pais;  // Validação acontece na propriedade
            this.Sigla = sigla;
            this.Ddi = ddi;
            this.Moeda = moeda;
        }

        // Propriedades com validação
        public string Pais
        {
            get => pais;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("O nome do país não pode ser vazio.");
                pais = value;
            }
        }

        public string Sigla
        {
            get => sigla;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length != 2)
                    throw new ArgumentException("A sigla deve ter exatamente 2 caracteres.");
                sigla = value.ToUpper();
            }
        }

        public string Ddi
        {
            get => ddi;
            set
            {
                if (!int.TryParse(value, out _) || value.Length > 5)
                    throw new ArgumentException("O DDI deve ser numérico e ter no máximo 5 dígitos.");
                ddi = value;
            }
        }

        public string Moeda
        {
            get => moeda;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("A moeda não pode ser vazia.");
                moeda = value;
            }
        }

        // Método para clonar o objeto
        public Paises Clone()
        {
            return new Paises(this.codigo, this.datCad, this.datUltAlt, this.pais, this.sigla, this.ddi, this.moeda);
        }

        // Método para salvar no banco
        public override string Salvar()
        {
            string resultado = "";
            string mSql;

            // Abrir conexão
            using (var cnn = Banco.Abrir())
            {
                if (this.codigo == 0)
                {
                    mSql = "INSERT INTO paises (pais, sigla, ddi, moeda) VALUES (@pais, @sigla, @ddi, @moeda)";
                }
                else
                {
                    mSql = "UPDATE paises SET pais = @pais, sigla = @sigla, ddi = @ddi, moeda = @moeda WHERE codigo = @codigo";
                }

                using (SqlCommand cmd = new SqlCommand(mSql, cnn))
                {
                    // Adicionar parâmetros
                    cmd.Parameters.AddWithValue("@pais", this.pais);
                    cmd.Parameters.AddWithValue("@sigla", this.sigla);
                    cmd.Parameters.AddWithValue("@ddi", this.ddi);
                    cmd.Parameters.AddWithValue("@moeda", this.moeda);
                    cmd.Parameters.AddWithValue("@codigo", this.codigo);

                    cmd.ExecuteNonQuery();

                    // Caso seja um novo registro, recuperar o ID gerado
                    if (this.codigo == 0)
                    {
                        cmd.CommandText = "SELECT @@IDENTITY";
                        resultado = cmd.ExecuteScalar()?.ToString() ?? "0";
                        this.codigo = Convert.ToInt32(resultado);
                    }
                }
            }

            return resultado;
        }

        // Método para excluir do banco
        public override string Excluir()
        {
            if (this.codigo == 0)
                throw new InvalidOperationException("O registro ainda não foi salvo no banco.");

            using (var cnn = Banco.Abrir())
            {
                string mSql = "DELETE FROM paises WHERE codigo = @codigo";
                using (SqlCommand cmd = new SqlCommand(mSql, cnn))
                {
                    cmd.Parameters.AddWithValue("@codigo", this.codigo);
                    cmd.ExecuteNonQuery();
                }
            }

            return "Registro excluído com sucesso.";
        }
    }
}
