using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Lista_01_e_02.Lista_01;
using Lista_01_02.Lista_01;

namespace Lista_01_e_02
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void exercício01ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmL02E01 frm = new frmL02E01();
            frm.Show();
        }

        private void exercício02ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmL02E02 frm = new frmL02E02();
            frm.Show();
        }

        private void exercício03ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmL02E03 frm = new frmL02E03();
            frm.Show();
        }

        private void exercício04ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmL02E04 frm = new frmL02E04();
            frm.Show();
        }

        private void exercício05ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmL02E05 frm = new frmL02E05();
            frm.Show();
        }

        private void exercício01ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmL01E01 frm = new frmL01E01();
            frm.Show();
        }

        private void exercício02ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmL01E02 frm = new frmL01E02();
            frm.ShowDialog();
        }

        private void exercício03ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmL01E03 frm = new frmL01E03();
            frm.Show();
        }

        private void exercício04ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmL01E04 frm = new frmL01E04();
            frm.Show();
        }

        private void exercício05ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new frmL01E05().Show();
        }

        private void exercício06ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmL01E06().Show();
        }

        private void exercício07ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmL01E07().Show();
        }

        private void exercício08ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmL01E08().Show();
        }
    }
}
