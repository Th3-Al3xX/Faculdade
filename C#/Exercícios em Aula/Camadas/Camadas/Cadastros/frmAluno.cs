using System;
using System.Windows.Forms;
using Util;
using BussinessRules;

namespace Camadas
{
    public partial class frmAluno : frmBase
    {
        private Aluno _entidade;

        public frmAluno()
        {
            InitializeComponent();
            this.Titulo = "Cadastro de Alunos";
            _entidade = new Aluno();
        }

        public frmAluno(int pCodigo)
        {
            InitializeComponent();
            this.Titulo = "Cadastro de Alunos";
            _entidade = new Aluno();
            txtCodigo.Text = pCodigo.ToString();
            btnPesquisar_Click(null, new EventArgs());
        }

        #region Members frmBase.

        public override void Gravar()
        {
            if (txtCodigo.Enabled) this._entidade.Codigo = int.Parse(txtCodigo.Text);

            this._entidade.Nome = txtNome.Text;
            this._entidade.Sexo = rbMasculino.Checked ? Genero.Masculino : Genero.Feminino;
            this._entidade.DataNascimento = dtNascimento.Value;

            string _retorno = new AlunoBR().Gravar(_entidade);
            if (!String.IsNullOrEmpty(_retorno))
            {
                MessageBox.Show(_retorno, "Cadastro de Cursos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            AjustaTela(false);
            LimpaTela();
        }

        #endregion

        #region Eventos.

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Se apertar enter, aciono o botao pesquisar.
            if (e.KeyChar == 13)
                this.btnPesquisar_Click(this, new EventArgs());
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            _entidade.Codigo = int.Parse(txtCodigo.Text);
            new AlunoBR().Consulta(_entidade);

            if (_entidade.Estado == Linha.Atualiza)
            {
                txtNome.Text = _entidade.Nome;
                dtNascimento.Value = _entidade.DataNascimento;

                if (_entidade.Sexo == Genero.Masculino)
                    rbMasculino.Checked = true;
                else
                    rbFeminino.Checked = true;
            }
            else if (_entidade.Estado == Linha.Nova)
            {
                LimpaTela();
            }

            AjustaTela(true);
            txtNome.Focus();
        }

        #endregion

        #region Metodos.

        private void PreencheCampos()
        {
            txtNome.Text = this._entidade.Nome;
            dtNascimento.Value = this._entidade.DataNascimento;
            if (this._entidade.Sexo == Genero.Masculino)
                rbMasculino.Checked = true;
            else
                rbFeminino.Checked = true;
        }

        private void AjustaTela(bool pNovo)
        {
            txtCodigo.Enabled = !pNovo;
            txtNome.Enabled = pNovo;
            dtNascimento.Enabled = pNovo;
            groupBox1.Enabled = pNovo;

            btnGravar.Enabled = pNovo;
        }

        private void LimpaTela()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            dtNascimento.Value = DateTime.Now;
            rbMasculino.Checked = true;
        }

        #endregion
    }
}
