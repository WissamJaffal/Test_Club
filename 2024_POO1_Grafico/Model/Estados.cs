using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_POO1_Grafico
{
    public class Estados : Pai
    {
        // Atributos privados
        private string estado;
        private string uf;
        private Paises oPais;

        // Construtor padrão
        public Estados() : base()
        {
            this.estado = "";
            this.uf = "";
            this.oPais = new Paises();
        }

        // Construtor com parâmetros
        public Estados(int codigo, string datCad, string datUltAlt, string estado, string uf, Paises oPais)
            : base(codigo, datCad, datUltAlt)
        {
            this.Estado = estado; // Validação na propriedade
            this.Uf = uf;
            this.OPais = oPais;
        }

        // Propriedades com validação
        public string Estado
        {
            get => estado;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("O nome do estado não pode ser vazio.");
                estado = value;
            }
        }

        public string Uf
        {
            get => uf;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length != 2)
                    throw new ArgumentException("A UF deve ter exatamente 2 caracteres.");
                uf = value.ToUpper();
            }
        }

        public Paises OPais
        {
            get => oPais;
            set
            {
                if (value == null)
                    throw new ArgumentException("O país não pode ser nulo.");
                oPais = value;
            }
        }

        // Método Clone
        public Estados Clone()
        {
            return new Estados(this.codigo, this.datCad, this.datUltAlt, this.estado, this.uf, this.oPais.Clone());
        }

        // Método para salvar no banco
        public override string Salvar()
        {
            string resultado = "";
            string mSql;

            try
            {
                using (var cnn = Banco.Abrir())
                {
                    if (this.codigo == 0)
                    {
                        mSql = "INSERT INTO estados (estado, uf, codigo_pais) VALUES (@estado, @uf, @codigo_pais)";
                    }
                    else
                    {
                        mSql = "UPDATE estados SET estado = @estado, uf = @uf, codigo_pais = @codigo_pais WHERE codigo = @codigo";
                    }

                    using (SqlCommand cmd = new SqlCommand(mSql, cnn))
                    {
                        cmd.Parameters.AddWithValue("@estado", this.estado);
                        cmd.Parameters.AddWithValue("@uf", this.uf);
                        cmd.Parameters.AddWithValue("@codigo_pais", this.oPais.Codigo);
                        cmd.Parameters.AddWithValue("@codigo", this.codigo);

                        int affectedRows = cmd.ExecuteNonQuery();

                        if (this.codigo == 0)
                        {
                            cmd.CommandText = "SELECT @@IDENTITY";
                            resultado = cmd.ExecuteScalar()?.ToString() ?? "0";
                            this.codigo = Convert.ToInt32(resultado);
                        }

                        if (affectedRows > 0)
                            return "Registro salvo com sucesso.";
                        else
                            return "Nenhum registro foi alterado.";
                    }
                }
            }
            catch (Exception ex)
            {
                return "Erro ao salvar: " + ex.Message;
            }
        }

        // Método para excluir do banco
        public override string Excluir()
        {
            if (this.codigo == 0)
                throw new InvalidOperationException("O registro ainda não foi salvo no banco.");

            try
            {
                using (var cnn = Banco.Abrir())
                {
                    string mSql = "DELETE FROM estados WHERE codigo = @codigo";
                    using (SqlCommand cmd = new SqlCommand(mSql, cnn))
                    {
                        cmd.Parameters.AddWithValue("@codigo", this.codigo);
                        cmd.ExecuteNonQuery();
                    }
                }

                return "Registro excluído com sucesso.";
            }
            catch (Exception ex)
            {
                return "Erro ao excluir: " + ex.Message;
            }
        }
    }
}
