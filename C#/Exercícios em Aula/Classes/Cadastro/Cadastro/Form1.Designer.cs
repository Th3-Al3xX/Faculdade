namespace Cadastro
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbFuncionario = new System.Windows.Forms.GroupBox();
            this.btnCriarFormulario = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.gbEndereco = new System.Windows.Forms.GroupBox();
            this.lblRua = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnCriarEndereco = new System.Windows.Forms.Button();
            this.btnAtribuirEndereco = new System.Windows.Forms.Button();
            this.gbInformacoes = new System.Windows.Forms.GroupBox();
            this.lblCodigo1 = new System.Windows.Forms.Label();
            this.lblNome1 = new System.Windows.Forms.Label();
            this.lblRua1 = new System.Windows.Forms.Label();
            this.lblNumero1 = new System.Windows.Forms.Label();
            this.txtCodigo1 = new System.Windows.Forms.TextBox();
            this.txtNome1 = new System.Windows.Forms.TextBox();
            this.txtRua1 = new System.Windows.Forms.TextBox();
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.gbFuncionario.SuspendLayout();
            this.gbEndereco.SuspendLayout();
            this.gbInformacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbFuncionario
            // 
            this.gbFuncionario.Controls.Add(this.btnCriarFormulario);
            this.gbFuncionario.Controls.Add(this.txtNome);
            this.gbFuncionario.Controls.Add(this.txtCodigo);
            this.gbFuncionario.Controls.Add(this.lblNome);
            this.gbFuncionario.Controls.Add(this.lblCodigo);
            this.gbFuncionario.Location = new System.Drawing.Point(7, 11);
            this.gbFuncionario.Name = "gbFuncionario";
            this.gbFuncionario.Size = new System.Drawing.Size(279, 109);
            this.gbFuncionario.TabIndex = 0;
            this.gbFuncionario.TabStop = false;
            this.gbFuncionario.Text = "Funcionário";
            // 
            // btnCriarFormulario
            // 
            this.btnCriarFormulario.Location = new System.Drawing.Point(134, 80);
            this.btnCriarFormulario.Name = "btnCriarFormulario";
            this.btnCriarFormulario.Size = new System.Drawing.Size(138, 22);
            this.btnCriarFormulario.TabIndex = 4;
            this.btnCriarFormulario.Text = "Criar &Formulário";
            this.btnCriarFormulario.UseVisualStyleBackColor = true;
            this.btnCriarFormulario.Click += new System.EventHandler(this.btnCriarFormulario_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(78, 51);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(177, 20);
            this.txtNome.TabIndex = 3;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(78, 25);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(39, 20);
            this.txtCodigo.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(21, 55);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(21, 28);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // gbEndereco
            // 
            this.gbEndereco.Controls.Add(this.btnCriarEndereco);
            this.gbEndereco.Controls.Add(this.txtNumero);
            this.gbEndereco.Controls.Add(this.txtRua);
            this.gbEndereco.Controls.Add(this.lblNumero);
            this.gbEndereco.Controls.Add(this.lblRua);
            this.gbEndereco.Enabled = false;
            this.gbEndereco.Location = new System.Drawing.Point(7, 124);
            this.gbEndereco.Name = "gbEndereco";
            this.gbEndereco.Size = new System.Drawing.Size(278, 89);
            this.gbEndereco.TabIndex = 1;
            this.gbEndereco.TabStop = false;
            this.gbEndereco.Text = "Endereço";
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Location = new System.Drawing.Point(28, 28);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(30, 13);
            this.lblRua.TabIndex = 0;
            this.lblRua.Text = "Rua:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(28, 53);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(47, 13);
            this.lblNumero.TabIndex = 1;
            this.lblNumero.Text = "Número:";
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(78, 25);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(177, 20);
            this.txtRua.TabIndex = 2;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(78, 50);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(38, 20);
            this.txtNumero.TabIndex = 3;
            // 
            // btnCriarEndereco
            // 
            this.btnCriarEndereco.Location = new System.Drawing.Point(134, 59);
            this.btnCriarEndereco.Name = "btnCriarEndereco";
            this.btnCriarEndereco.Size = new System.Drawing.Size(136, 21);
            this.btnCriarEndereco.TabIndex = 4;
            this.btnCriarEndereco.Text = "Criar &Endereço";
            this.btnCriarEndereco.UseVisualStyleBackColor = true;
            this.btnCriarEndereco.Click += new System.EventHandler(this.btnCriarEndereco_Click);
            // 
            // btnAtribuirEndereco
            // 
            this.btnAtribuirEndereco.Enabled = false;
            this.btnAtribuirEndereco.Location = new System.Drawing.Point(44, 223);
            this.btnAtribuirEndereco.Name = "btnAtribuirEndereco";
            this.btnAtribuirEndereco.Size = new System.Drawing.Size(204, 24);
            this.btnAtribuirEndereco.TabIndex = 2;
            this.btnAtribuirEndereco.Text = "&Atribuir Endereço";
            this.btnAtribuirEndereco.UseVisualStyleBackColor = true;
            this.btnAtribuirEndereco.Click += new System.EventHandler(this.btnAtribuirEndereco_Click);
            // 
            // gbInformacoes
            // 
            this.gbInformacoes.Controls.Add(this.btnLimpar);
            this.gbInformacoes.Controls.Add(this.txtNumero1);
            this.gbInformacoes.Controls.Add(this.txtRua1);
            this.gbInformacoes.Controls.Add(this.txtNome1);
            this.gbInformacoes.Controls.Add(this.txtCodigo1);
            this.gbInformacoes.Controls.Add(this.lblNumero1);
            this.gbInformacoes.Controls.Add(this.lblRua1);
            this.gbInformacoes.Controls.Add(this.lblNome1);
            this.gbInformacoes.Controls.Add(this.lblCodigo1);
            this.gbInformacoes.Enabled = false;
            this.gbInformacoes.Location = new System.Drawing.Point(7, 252);
            this.gbInformacoes.Name = "gbInformacoes";
            this.gbInformacoes.Size = new System.Drawing.Size(279, 147);
            this.gbInformacoes.TabIndex = 3;
            this.gbInformacoes.TabStop = false;
            this.gbInformacoes.Text = "Informações";
            // 
            // lblCodigo1
            // 
            this.lblCodigo1.AutoSize = true;
            this.lblCodigo1.Location = new System.Drawing.Point(18, 26);
            this.lblCodigo1.Name = "lblCodigo1";
            this.lblCodigo1.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo1.TabIndex = 0;
            this.lblCodigo1.Text = "Código:";
            // 
            // lblNome1
            // 
            this.lblNome1.AutoSize = true;
            this.lblNome1.Location = new System.Drawing.Point(18, 53);
            this.lblNome1.Name = "lblNome1";
            this.lblNome1.Size = new System.Drawing.Size(38, 13);
            this.lblNome1.TabIndex = 1;
            this.lblNome1.Text = "Nome:";
            // 
            // lblRua1
            // 
            this.lblRua1.AutoSize = true;
            this.lblRua1.Location = new System.Drawing.Point(18, 79);
            this.lblRua1.Name = "lblRua1";
            this.lblRua1.Size = new System.Drawing.Size(30, 13);
            this.lblRua1.TabIndex = 2;
            this.lblRua1.Text = "Rua:";
            // 
            // lblNumero1
            // 
            this.lblNumero1.AutoSize = true;
            this.lblNumero1.Location = new System.Drawing.Point(18, 106);
            this.lblNumero1.Name = "lblNumero1";
            this.lblNumero1.Size = new System.Drawing.Size(47, 13);
            this.lblNumero1.TabIndex = 3;
            this.lblNumero1.Text = "Número:";
            // 
            // txtCodigo1
            // 
            this.txtCodigo1.Enabled = false;
            this.txtCodigo1.Location = new System.Drawing.Point(68, 23);
            this.txtCodigo1.Name = "txtCodigo1";
            this.txtCodigo1.Size = new System.Drawing.Size(64, 20);
            this.txtCodigo1.TabIndex = 4;
            // 
            // txtNome1
            // 
            this.txtNome1.Enabled = false;
            this.txtNome1.Location = new System.Drawing.Point(68, 50);
            this.txtNome1.Name = "txtNome1";
            this.txtNome1.Size = new System.Drawing.Size(187, 20);
            this.txtNome1.TabIndex = 5;
            // 
            // txtRua1
            // 
            this.txtRua1.Enabled = false;
            this.txtRua1.Location = new System.Drawing.Point(68, 76);
            this.txtRua1.Name = "txtRua1";
            this.txtRua1.Size = new System.Drawing.Size(187, 20);
            this.txtRua1.TabIndex = 6;
            // 
            // txtNumero1
            // 
            this.txtNumero1.Enabled = false;
            this.txtNumero1.Location = new System.Drawing.Point(68, 104);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(63, 20);
            this.txtNumero1.TabIndex = 7;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(202, 117);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(68, 21);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 405);
            this.Controls.Add(this.gbInformacoes);
            this.Controls.Add(this.btnAtribuirEndereco);
            this.Controls.Add(this.gbEndereco);
            this.Controls.Add(this.gbFuncionario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Endereços";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbFuncionario.ResumeLayout(false);
            this.gbFuncionario.PerformLayout();
            this.gbEndereco.ResumeLayout(false);
            this.gbEndereco.PerformLayout();
            this.gbInformacoes.ResumeLayout(false);
            this.gbInformacoes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFuncionario;
        private System.Windows.Forms.Button btnCriarFormulario;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.GroupBox gbEndereco;
        private System.Windows.Forms.Button btnCriarEndereco;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.Button btnAtribuirEndereco;
        private System.Windows.Forms.GroupBox gbInformacoes;
        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.TextBox txtRua1;
        private System.Windows.Forms.TextBox txtNome1;
        private System.Windows.Forms.TextBox txtCodigo1;
        private System.Windows.Forms.Label lblNumero1;
        private System.Windows.Forms.Label lblRua1;
        private System.Windows.Forms.Label lblNome1;
        private System.Windows.Forms.Label lblCodigo1;
        private System.Windows.Forms.Button btnLimpar;

    }
}

