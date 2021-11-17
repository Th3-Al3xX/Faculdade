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
    public partial class frmL02E04 : Form
    {
        private Hashtable hash;

        public frmL02E04()
        {
            InitializeComponent();
            hash = new Hashtable();
        }

        private void btnInsere_Click(object sender, EventArgs e)
        {
            try
            {
                hash.Add(txtNome.Text, Convert.ToDouble(txtValor.Text));
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Esta key já existe!");
            }

            catch (FormatException)
            {
                MessageBox.Show("Digite um double!");
            }

            txtNome.Clear();
            txtValor.Clear();

            Mostrar();
        }

        private void btnRetira_Click(object sender, EventArgs e)
        {

            hash.Remove(txtNome.Text);

            Mostrar();
        }

        private void Mostrar()
        {
            listBox1.Items.Clear();

            foreach (DictionaryEntry item in hash)
                listBox1.Items.Add(item.Key.ToString() + " - " + item.Value.ToString());
        }
    }
}
