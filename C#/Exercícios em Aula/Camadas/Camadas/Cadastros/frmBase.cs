using System;
using System.Windows.Forms;

namespace Camadas
{
    public partial class frmBase : Form
    {
        private string _titulo;
        protected string Titulo
        {
            get { return _titulo; }
            set { _titulo = value; }
        }

        /// <summary>
        /// Método onde deve ser implementado (através de sobrecarga) a gravação do item.
        /// </summary>
        public virtual void Gravar() { throw new NotImplementedException(); }

        public frmBase()
        {
            InitializeComponent();
        }

        private void frmBase_Load(object sender, EventArgs e)
        {
            // Acerto a barra de título do form.
            this.Text = Titulo;
            // Acerto o label de título.
            lblTitulo.Text = Titulo;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            this.Gravar();
        }

    }
}
