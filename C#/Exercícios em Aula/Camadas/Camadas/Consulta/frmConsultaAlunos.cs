using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BussinessRules;

namespace Camadas.Consulta
{
    public partial class frmConsultaAlunos : Form
    {
        public frmConsultaAlunos()
        {
            InitializeComponent();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            int _codigo = int.Parse(grvPrincipal.CurrentRow.Cells["Codigo"].Value.ToString());
            frmAluno frm = new frmAluno(_codigo);
            
            frm.ShowDialog();

            frmConsultaAlunos_Load(sender, new EventArgs());
        }

        private void frmConsultaAlunos_Load(object sender, EventArgs e)
        {
            AlunoBR _BR = new AlunoBR();

            grvPrincipal.DataSource = _BR.GetList();

            foreach (DataGridViewColumn _col in grvPrincipal.Columns)
                _col.Visible = false;

            grvPrincipal.Columns["Codigo"].HeaderText = "Código";
            grvPrincipal.Columns["Codigo"].Visible = true;
            grvPrincipal.Columns["Codigo"].DisplayIndex = 0;

            grvPrincipal.Columns["Nome"].HeaderText = "Nome";
            grvPrincipal.Columns["Nome"].Visible = true;
            grvPrincipal.Columns["Nome"].DisplayIndex = 1;
            grvPrincipal.Columns["Nome"].Width = 400;
        }
    }
}
