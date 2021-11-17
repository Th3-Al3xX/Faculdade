using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Coleções
{
    public partial class frmSortedList : Form
    {
        private SortedList lista;

        public frmSortedList()
        {
            InitializeComponent();
            lista = new SortedList();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Livro liv = new Livro();
            liv.SetTitulo(txtTitulo.Text);
            liv.SetAutor(txtAutor.Text);

            try
            {
                lista.Add(liv.GetTitulo(), liv);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Esta chave já existe!");
            }

            MostraConteudo();
        }


        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                lista.RemoveAt(Convert.ToInt32(txtIndice.Text));
                MostraConteudo();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Digite um indice valido!");
                return;
            }
        }

        private void MostraConteudo()
        {
            // Limpo a lista.
            listBox1.Items.Clear();

            // Insiro as informações.
            foreach (DictionaryEntry l in lista)
                listBox1.Items.Add(String.Format("{0} - {1}", ((Livro)l.Value).GetTitulo(), ((Livro)l.Value).GetAutor()));

            // Limpa os txt´s
            txtTitulo.Clear();
            txtAutor.Clear();
            txtIndice.Clear();
        }
    }
}
