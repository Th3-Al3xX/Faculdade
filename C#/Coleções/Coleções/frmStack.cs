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
    public partial class frmStack : Form
    {
        private Stack pilha;

        public frmStack()
        {
            InitializeComponent();
            pilha = new Stack();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Livro liv = new Livro();
            liv.SetTitulo(txtTitulo.Text);
            liv.SetAutor(txtAutor.Text);

            pilha.Push(liv);

            MostraConteudo();
        }


        private void btnRemove_Click(object sender, EventArgs e)
        {
            pilha.Pop();
            MostraConteudo();
        }

        private void MostraConteudo()
        {
            // Limpo a lista.
            listBox1.Items.Clear();

            // Insiro as informações.
            foreach (Livro l in pilha)
                listBox1.Items.Add(String.Format("{0} - {1}", l.GetTitulo(), l.GetAutor()));

            // Limpa os txt´s
            txtTitulo.Clear();
            txtAutor.Clear();
        }
    }
}
