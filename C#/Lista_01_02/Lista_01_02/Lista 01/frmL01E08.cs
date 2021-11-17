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
    public partial class frmL01E08 : Form
    {
        private Pessoa[] _pessoas;

        public frmL01E08()
        {
            InitializeComponent();
            _pessoas = new Pessoa[8];

            for (int i = 0; i < _pessoas.Length; i++)
                _pessoas[i] = new Pessoa();

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            int _linha = Convert.ToInt32(txtIndice.Value);

            _pessoas[_linha].Sexo = txtSexo.Text;

            try
            {
                _pessoas[_linha].Altura = Convert.ToDecimal(txtAltura.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Digite uma altura válida!");
                return;
            }

            if (txtIndice.Value < 7) txtIndice.Value++;
            else txtIndice.Value = 0;


            txtSexo.Clear();
            txtAltura.Clear();

            txtSexo.Focus();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int _qtd = 0;
            decimal _alturaAlto = Decimal.Zero;


            foreach (Pessoa _pessoa in _pessoas)
            {
                #region A quantidade de mulheres com menos de 1,70 m.

                if (_pessoa.Sexo == "F" && _pessoa.Altura < 1.70M)
                    _qtd++;

                #endregion

                #region A altura do homem mais alto.

                if (_pessoa.Sexo == "M" && _pessoa.Altura > _alturaAlto)
                    _alturaAlto = _pessoa.Altura;

                #endregion
            }

            MessageBox.Show("A quantidade de mulheres com menos de 1,70 m é: " + _qtd);

            MessageBox.Show("A altura do homem mais alto é :" + _alturaAlto);
        }
    }
}
