using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Util.Entidades;
using BussinessRules;
using Util;

namespace Camadas.Cadastros
{
    public partial class frmCurso : frmBase
    {
        public Curso _entidade;

        public frmCurso()
        {
            InitializeComponent();
            this.Titulo = "Cadastro de Curso";
            _entidade = new Curso();

        }

        #region Members frmBase.

        public override void Gravar()
        {
            if (txtCodigo.Enabled) this._entidade.Codigo = int.Parse(txtCodigo.Text);

            this._entidade.Decricao = txtDescricao.Text;
            this._entidade.DtAbertura = dtAbertura.Value;

            string _retorno = new CursoBR().Gravar(_entidade);
            if (!String.IsNullOrEmpty(_retorno))
            {
                MessageBox.Show(_retorno, "Cadastro de Cursos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            AjustaTela(false);
            LimpaTela();
        }

        #endregion

        #region Metodos.

        private void PreencheCampos()
        {
            txtDescricao.Text = this._entidade.Decricao;
            dtAbertura.Value = this._entidade.DtAbertura;
        }

        private void AjustaTela(bool pNovo)
        {
            txtCodigo.Enabled = !pNovo;
            txtDescricao.Enabled = pNovo;
            dtAbertura.Enabled = pNovo;

            btnGravar.Enabled = pNovo;
        }

        private void LimpaTela()
        {
            txtCodigo.Clear();
            txtDescricao.Clear();
            dtAbertura.Value = DateTime.Now;
        }

        #endregion
        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            _entidade.Codigo = int.Parse(txtCodigo.Text);
            new CursoBR().Consulta(_entidade);

            if (_entidade.Estado == Linha.Atualiza)
            {
                txtDescricao.Text = _entidade.Decricao;
                dtAbertura.Value = _entidade.DtAbertura;
            }
            else if (_entidade.Estado == Linha.Nova)
            {
                LimpaTela();
            }

            AjustaTela(true);
            txtDescricao.Focus();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Se apertar enter, aciono o botao pesquisar.
            if (e.KeyChar == 13)
                this.btnPesquisar_Click(this, new EventArgs());
        }
    }
}
