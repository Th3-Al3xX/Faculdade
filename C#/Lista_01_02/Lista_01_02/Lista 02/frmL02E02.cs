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
    public partial class frmL02E02 : Form
    {
        private Queue fila;

        public frmL02E02()
        {
            InitializeComponent();
            fila = new Queue();
        }

        private void btnInsere_Click(object sender, EventArgs e)
        {
            fila.Enqueue(txtNome.Text);

            txtNome.Clear();

            Mostrar();
        }

        private void btnRetira_Click(object sender, EventArgs e)
        {

            try
            {
                fila.Dequeue();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("A fila já esta vazia!");
            }

            Mostrar();
        }

        private void Mostrar()
        {
            listBox1.Items.Clear();

            foreach (object item in fila)
                listBox1.Items.Add(item.ToString());
        }
    }
}
