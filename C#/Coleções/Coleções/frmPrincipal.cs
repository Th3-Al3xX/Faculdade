using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Coleções
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void arrayListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArrayList frm = new frmArrayList();
            frm.ShowDialog();
        }

        private void queuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQueue frm = new frmQueue();
            frm.ShowDialog();
        }

        private void stackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStack frm = new frmStack();
            frm.ShowDialog();
        }

        private void hashTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHashTable frm = new frmHashTable();
            frm.ShowDialog();
        }

        private void sortedListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSortedList frm = new frmSortedList();
            frm.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void exemplo1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void exemplo2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExemplo frm = new frmExemplo();
            frm.ShowDialog();

            frm.Dispose();
        }
    }
}
