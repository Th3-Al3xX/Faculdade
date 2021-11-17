using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cadastro
{
    public partial class Form1 : Form
    {
        Funcionario f = new Funcionario();
        Endereco end = new Endereco();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCriarFormulario_Click(object sender, EventArgs e)
        {
            f.Codigo = int.Parse(txtCodigo.Text);
            f.Nome = txtNome.Text;

            gbEndereco.Enabled = true;
            txtRua.Focus();

            Width = 302;
            Height = 246;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtCodigo.Text = Convert.ToString(f.Codigo);
            txtNome.Text = f.Nome;
            txtRua.Text = end.Rua;
            txtNumero.Text = Convert.ToString(end.Numero);

            Width = 302;
            Height = 154;
        }

        private void btnCriarEndereco_Click(object sender, EventArgs e)
        {
            end.Rua = txtRua.Text;
            end.Numero = int.Parse(txtNumero.Text);

            Width = 302;
            Height = 279;

            btnAtribuirEndereco.Enabled = true;
            btnAtribuirEndereco.Focus();

        }

        private void btnAtribuirEndereco_Click(object sender, EventArgs e)
        {
            gbInformacoes.Enabled = true;

            f.Endereco = end;

            txtCodigo1.Text = Convert.ToString(f.Codigo);
            txtNome1.Text = f.Nome;
            txtRua1.Text = f.Endereco.Rua;
            txtNumero1.Text = Convert.ToString(f.Endereco.Numero);

            Width = 302;
            Height = 434;

            btnLimpar.Focus();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtRua.Clear();
            txtNumero.Clear();

            txtCodigo1.Clear();
            txtNome1.Clear();
            txtRua1.Clear();
            txtNumero1.Clear();

            gbEndereco.Enabled = false;
            gbInformacoes.Enabled = false;
            btnAtribuirEndereco.Enabled = false;

            Width = 302;
            Height = 154;

            txtCodigo.Focus();
        }

    }
}
