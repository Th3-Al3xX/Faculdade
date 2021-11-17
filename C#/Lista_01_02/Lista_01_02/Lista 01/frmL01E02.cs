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
    public partial class frmL01E02 : Form
    {
        private int[] _array;

        public frmL01E02()
        {
            InitializeComponent();
            _array = new int[6];
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string _mensagem = String.Empty;

            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i] % 2 != 0)
                    _mensagem += _array[i] + "  ";
            }

            MessageBox.Show(_mensagem, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                _array[Convert.ToInt32(txtIndice.Value)] = Convert.ToInt32(txtValor.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Operação cancelada!\nInsira apenas números inteiros!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
