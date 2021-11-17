using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Camadas.Consulta;

namespace Camadas
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public bool IsFormOpen(string strForm)
        {
            //Função, verifica se existe um formulário com o mesmo nome aberto
            int i = 0;
            while (i != this.MdiChildren.Length)
            {
                if (this.MdiChildren[i].Name.ToString().Equals(strForm))
                {
                    this.MdiChildren[i].BringToFront();
                    this.MdiChildren[i].WindowState = FormWindowState.Normal;
                    this.MdiChildren[i].Show();
                    return true;
                }
                i++;
            }
            return false;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!IsFormOpen("frmAluno"))
            {
                frmAluno frm = new frmAluno();
                frm.MdiParent = (Form)this;
                frm.WindowState = FormWindowState.Normal;
                frm.Show();
            }
        }


        private void alunoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!IsFormOpen("frmConsultaAlunos"))
            {
                frmConsultaAlunos frm = new frmConsultaAlunos();
                frm.MdiParent = (Form)this;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
        }

        private void cursoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
