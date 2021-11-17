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
    public partial class frmL01E01 : Form
    {
        private int[] _array;

        public frmL01E01()
        {
            InitializeComponent();
            _array = new int[6];
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                _array[0] = Convert.ToInt32(txtP0.Text);
                _array[1] = Convert.ToInt32(txtP1.Text);
                _array[2] = Convert.ToInt32(txtP2.Text);
                _array[3] = Convert.ToInt32(txtP3.Text);
                _array[4] = Convert.ToInt32(txtP4.Text);
                _array[5] = Convert.ToInt32(txtP5.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Operação cancelada!\nInsira apenas números inteiros!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string _mensagem = String.Empty;

            for (int i = 0; i < _array.Length; i++)
            {
                if (i % 2 == 0)
                    _mensagem += _array[i] + "  ";
            }

            MessageBox.Show(_mensagem, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
