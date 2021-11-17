using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Aplicacao;
using System.Collections;

namespace TesteDeCamadas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExemplo_Click(object sender, EventArgs e)
        {
            MensagemBR obj = new MensagemBR();

            ArrayList _mensagem = obj.getMensagem(); //= "APRESENTAÇÃO";
            
            MessageBox.Show(_mensagem.Count.ToString());

            foreach (object item in _mensagem)
            {
                MessageBox.Show(item.ToString());
            }
        }
    }
}
