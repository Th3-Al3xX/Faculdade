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
    public partial class frmL01E06 : Form
    {
        private decimal[,] _notas;

        public frmL01E06()
        {
            InitializeComponent();
            _notas = new decimal[12, 3];
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            int _linha = Convert.ToInt32(txtIndice.Value);

            _notas[_linha, 0] = Convert.ToDecimal(txtN1.Text);
            _notas[_linha, 1] = Convert.ToDecimal(txtN2.Text);
            _notas[_linha, 2] = Convert.ToDecimal(txtN3.Text);


            #region Ignore.
            if (txtIndice.Value < 11)
                txtIndice.Value++;
            else
                txtIndice.Value = 0;
            #endregion

            txtN1.Clear();
            txtN2.Clear();
            txtN3.Clear();

            txtN1.Focus();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            decimal _media = Decimal.Zero;
            decimal _soma = Decimal.Zero;
            int _count = 0;

            #region Calculo da média da turma.
            
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 3; j++)
                    _soma += _notas[i, j];
            }

            _media = (_soma / 3) / 12;

            #endregion

            #region Contagem de alunos acima da media!
            for (int i = 0; i < 12; i++)
            {
                if ((_notas[i, 0] + _notas[i, 1] + _notas[i, 2]) / 3 > _media)
                    _count++;
            }
            #endregion
            
            MessageBox.Show(String.Format("A media é : {0}\nA quantidade de alunos acima da media é: {1}", _media.ToString("#0.00"), _count));

        }
    }
}
