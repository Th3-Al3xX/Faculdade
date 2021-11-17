using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lista_01_02.Lista_01
{
    public partial class frmL01E07 : Form
    {
        private Pessoa[] _pessoas;

        public frmL01E07()
        {
            InitializeComponent();
            _pessoas = new Pessoa[10];

            for (int i = 0; i < _pessoas.Length; i++)
                _pessoas[i] = new Pessoa();

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            int _linha = Convert.ToInt32(txtIndice.Value);

            _pessoas[_linha].Nome = txtNome.Text;
            _pessoas[_linha].Sexo = txtSexo.Text;

            try
            {
                _pessoas[_linha].Idade = Convert.ToInt32(txtIdade.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Digite uma idade inteira válida!");
                return;
            }

            try
            {
                _pessoas[_linha].Altura = Convert.ToDecimal(txtAltura.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Digite uma altura válida!");
                return;
            }

            if (txtIndice.Value < 9) txtIndice.Value++;
            else txtIndice.Value = 0;


            txtNome.Clear();
            txtSexo.Clear();
            txtIdade.Clear();
            txtAltura.Clear();

            txtNome.Focus();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int _qtd = 0;
            int _indiceMaisVelha = 0;


            foreach(Pessoa _pessoa in _pessoas)
            {
                if (_pessoa.Sexo == "M" && _pessoa.Idade > _pessoas[9].Idade)
                    _qtd++;
            }

            for (int i = 0; i < _pessoas.Length; i++)
            {
                if (_pessoas[i].Idade > _pessoas[_indiceMaisVelha].Idade)
                    _indiceMaisVelha = i;
            }

            MessageBox.Show("A quantidade de homens com idade maior que a idade da última pessoa é: " + _qtd);
            
            MessageBox.Show("O sexo da pessoa mais velha é:" + _pessoas[_indiceMaisVelha].Sexo);

            MessageBox.Show("A altura do " + _pessoas[_indiceMaisVelha].Nome + " é:" + _pessoas[_indiceMaisVelha].Altura);

            MessageBox.Show("A altura da pessoa mais velha é:" + _pessoas[_indiceMaisVelha].Altura);
        }
    }
}
