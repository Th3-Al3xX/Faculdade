using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Lista_01_e_02
{
    public partial class frmL02E03 : Form
    {
        private Stack pilha;

        public frmL02E03()
        {
            InitializeComponent();
            pilha = new Stack();
        }

        private void btnInsere_Click(object sender, EventArgs e)
        {
            try
            {
                pilha.Push(Convert.ToInt32(txtNome.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("Digite um inteiro!");
            }

            txtNome.Clear();

            Mostrar();
        }

        private void btnRetira_Click(object sender, EventArgs e)
        {

            try
            {
                pilha.Pop();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("A pilha já esta vazia!");
            }

            Mostrar();
        }

        private void Mostrar()
        {
            listBox1.Items.Clear();

            foreach (object item in pilha)
                listBox1.Items.Add(item.ToString());
        }
    }
}
