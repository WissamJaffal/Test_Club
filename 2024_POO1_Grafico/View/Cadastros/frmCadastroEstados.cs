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

        // Recebe o objeto Estados
        public override void ConhecaObj(object obj)
        {
            base.ConhecaObj(obj);
            oEstado = (Estados)obj;
        }

        // Configura o formulário de consulta de países
        public void SetConsultaPaises(object obj)
        {
            ofrmConsultaPais = (frmConsultaPaises)obj;
        }

        // Botão para pesquisar país
        private void btnPesquisarPais_Click(object sender, EventArgs e)
        {
            ofrmConsultaPais.ConhecaObj(oEstado.OPais);
            ofrmConsultaPais.ShowDialog();
            CarregaPaisSelecionado();
        }

        // Método para carregar os dados do país selecionado
        private void CarregaPaisSelecionado()
        {
            txtCodPais.Text = oEstado.OPais.Codigo.ToString();
            txtPais.Text = oEstado.OPais.Pais;
        }

        // Salvar dados no objeto e no banco
        public override void Salvar()
        {
            string msg;

            try
            {
                oEstado.Codigo = Convert.ToInt32(txtCodigo.Text);
                oEstado.Estado = txtEstado.Text;
                oEstado.Uf = txtUF.Text;
                oEstado.OPais.Codigo = Convert.ToInt32(txtCodPais.Text);

                msg = oEstado.Salvar();

                if (!string.IsNullOrEmpty(msg))
                {
                    MessageBox.Show("O estado " + oEstado.Estado + " foi salvo com o código " + oEstado.Codigo,
                                    "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para limpar os campos do formulário
        public override void LimpaTxt()
        {
            txtCodigo.Clear();
            txtCodigo.Text = "0";
            txtEstado.Clear();
            txtUF.Clear();
            txtCodPais.Clear();
            txtPais.Clear();
        }

        // Carrega os valores do objeto nos campos do formulário
        public override void CarregaTxt()
        {
            txtCodigo.Text = oEstado.Codigo.ToString();
            txtEstado.Text = oEstado.Estado;
            txtUF.Text = oEstado.Uf;
            txtCodPais.Text = oEstado.OPais.Codigo.ToString();
            txtPais.Text = oEstado.OPais.Pais;
        }

        // Bloqueia a edição dos campos
        public override void BloqueiaTxt()
        {
            txtCodigo.Enabled = false;
            txtEstado.Enabled = false;
            txtUF.Enabled = false;
            txtCodPais.Enabled = false;
            txtPais.Enabled = false;
            btnPesquisarPais.Enabled = false;
        }

        // Desbloqueia os campos
        public override void DesbloqueiaTxt()
        {
            txtCodigo.Enabled = true;
            txtEstado.Enabled = true;
            txtUF.Enabled = true;
            txtCodPais.Enabled = false; // Mantém bloqueado para evitar edição direta
            btnPesquisarPais.Enabled = true;
        }

        private void frmCadastroEstados_Load(object sender, EventArgs e)
        {
            // Inicialização, se necessário
        }

        private void txtCodPais_TextChanged(object sender, EventArgs e)
        {

        }
    }
}