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
    public partial class frmL02E01 : Form
    {
        // Declaração!
        private ArrayList lista;

        public frmL02E01()
        {
            InitializeComponent();
            lista = new ArrayList();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            lista.Add(txtNome.Text);
            txtNome.Clear();

            Mostrar();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            try
            {
                lista.RemoveAt(Convert.ToInt32(txtIndice.Text));
                txtIndice.Clear();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("O índice informado não existe!");
            }
            catch (FormatException)
            {
                MessageBox.Show("O índice deve ser um inteiro!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro desconhecido!\n" + ex.ToString());
            }


            Mostrar();
        }

        private void Mostrar()
        {
            listNomes.Items.Clear();
            foreach (object obj in lista)
                listNomes.Items.Add(obj.ToString());
        }

        private void listNomes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listNomes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                lista.RemoveAt(listNomes.SelectedIndex);
                txtIndice.Clear();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("O índice informado não existe!");
            }
            catch (FormatException)
            {
                MessageBox.Show("O índice deve ser um inteiro!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro desconhecido!\n" + ex.ToString());
            }


            Mostrar();
        }

    }
}
