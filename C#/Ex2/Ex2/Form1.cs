using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ex2
{
    public partial class frmEx2 : Form
    {
        public frmEx2()
        {
            InitializeComponent();
        }

        private void frmEx2_Load(object sender, EventArgs e)
        {

            cboMoedaEnt.Items.Add("Dólar");
            cboMoedaEnt.Items.Add("Euro");
            cboMoedaEnt.Items.Add("Real");
            cboMoedaSaida.Items.Add("Dólar");
            cboMoedaSaida.Items.Add("Euro");
            cboMoedaSaida.Items.Add("Real");

        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            double _Valor = 0.00;
            double _Dolar = 1.6640;
            double _Euro = 2.3366;

            try
            {
                _Valor = Convert.ToDouble(txtValor.Text);
            }
            catch(FormatException)
            {
                MessageBox.Show("Valor Inválido! Tente Novamente", "Erro");
            }

            double _resultado = _Valor;

            if (cboMoedaEnt.Text=="Real")
            {
                if (cboMoedaSaida.Text == "Dólar")
                    _resultado = _Valor * _Dolar;
                else if (cboMoedaSaida.Text == "Euro")
                    _resultado = _Valor * _Euro;
            }
            else if (cboMoedaEnt.Text=="Dólar")
            {
                if (cboMoedaSaida.Text == "Real")
                    _resultado = _Valor / _Dolar;
                else if (cboMoedaSaida.Text == "Euro")
                    _resultado = (_Valor / _Dolar) * _Euro;
            }
            else if (cboMoedaEnt.Text=="Euro")
            {
                if (cboMoedaSaida.Text == "Real")
                    _resultado = _Valor / _Euro;
                else if (cboMoedaSaida.Text == "Dólar")
                    _resultado = (_Valor / _Euro) * _Dolar;
            }

            txtResult.Text = _resultado.ToString("#0.00");
        }

    }
}