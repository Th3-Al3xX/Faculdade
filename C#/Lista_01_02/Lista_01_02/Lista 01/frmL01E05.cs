using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lista_01_e_02.Lista_01
{
    public partial class frmL01E05 : Form
    {
        private decimal[] _array;

        public frmL01E05()
        {
            InitializeComponent();
            _array = new decimal[10];
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            int _indice;

            try
            {
                _indice = Convert.ToInt32(txtindice.Value);
            }
            catch (FormatException)
            {
                MessageBox.Show("Digite um índice valido!");
                return;
            }


            try
            {
                _array[_indice] = Convert.ToDecimal(txtValor.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Digite um valor valido!");
            }
            
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            decimal _menor = _array[0];

            foreach (decimal _valor in _array)
            {
                if (_valor < _menor)
                    _menor = _valor;
            }


            MessageBox.Show("O menor valor é: " + _menor);
        }
    }
}
