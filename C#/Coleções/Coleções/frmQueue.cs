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
    public partial class frmQueue : Form
    {
        private Queue fila;

        public frmQueue()
        {
            InitializeComponent();
            fila = new Queue();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Livro liv = new Livro();
            liv.SetTitulo(txtTitulo.Text);
            liv.SetAutor(txtAutor.Text);

            fila.Enqueue(liv);

            MostraConteudo();
        }


        private void btnRemove_Click(object sender, EventArgs e)
        {
            fila.Dequeue();
            MostraConteudo();
        }

        private void MostraConteudo()
        {
            // Limpo a lista.
            listBox1.Items.Clear();

            // Insiro as informações.
            foreach (Livro l in fila)
                listBox1.Items.Add(String.Format("{0} - {1}", l.GetTitulo(), l.GetAutor()));
        }
    }
}
