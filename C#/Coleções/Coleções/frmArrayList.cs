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
    public partial class frmArrayList : Form
    {
        private ArrayList lista;

        public frmArrayList()
        {
            InitializeComponent();
            lista = new ArrayList();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Livro liv = new Livro();
            liv.SetTitulo(txtTitulo.Text);
            liv.SetAutor(txtAutor.Text);

            lista.Insert(0, liv);

            MostraConteudo();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Livro liv = new Livro();
            liv.SetTitulo(txtTitulo.Text);
            liv.SetAutor(txtAutor.Text);

            lista.Add(liv);

            MostraConteudo();
        }


        private void btnRemove_Click(object sender, EventArgs e)
        {
            int indice = int.MinValue;
            try
            {
                indice = Convert.ToInt32(txtIndice.Text);
                lista.RemoveAt(indice);
                MostraConteudo();
            }
            catch (FormatException)
            {
                MessageBox.Show("Digite um inteiro valido!");
                return;
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
            foreach (Livro l in lista)
                listBox1.Items.Add(String.Format("{0}-{1}", l.GetTitulo(), l.GetAutor()));
        }

        private void frmArrayList_Load(object sender, EventArgs e)
        {

        }
    }
}
