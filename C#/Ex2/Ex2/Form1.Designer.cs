namespace Ex2
{
    partial class frmEx2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblMoedaEnt = new System.Windows.Forms.Label();
            this.lblMoedaSaida = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.cboMoedaEnt = new System.Windows.Forms.ComboBox();
            this.cboMoedaSaida = new System.Windows.Forms.ComboBox();
            this.btnConverter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblValor
            // 
            this.lblValor.Location = new System.Drawing.Point(18, 25);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(100, 20);
            this.lblValor.Text = "Valor:";
            // 
            // lblMoedaEnt
            // 
            this.lblMoedaEnt.Location = new System.Drawing.Point(18, 92);
            this.lblMoedaEnt.Name = "lblMoedaEnt";
            this.lblMoedaEnt.Size = new System.Drawing.Size(100, 20);
            this.lblMoedaEnt.Text = "Moeda Entrada";
            // 
            // lblMoedaSaida
            // 
            this.lblMoedaSaida.Location = new System.Drawing.Point(121, 92);
            this.lblMoedaSaida.Name = "lblMoedaSaida";
            this.lblMoedaSaida.Size = new System.Drawing.Size(100, 20);
            this.lblMoedaSaida.Text = "Moeda Saída";
            // 
            // lblResult
            // 
            this.lblResult.Location = new System.Drawing.Point(18, 203);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(100, 20);
            this.lblResult.Text = "Resultado:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(67, 24);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 21);
            this.txtValor.TabIndex = 4;
            // 
            // txtResult
            // 
            this.txtResult.Enabled = false;
            this.txtResult.Location = new System.Drawing.Point(79, 202);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(100, 21);
            this.txtResult.TabIndex = 5;
            // 
            // cboMoedaEnt
            // 
            this.cboMoedaEnt.Location = new System.Drawing.Point(18, 113);
            this.cboMoedaEnt.Name = "cboMoedaEnt";
            this.cboMoedaEnt.Size = new System.Drawing.Size(100, 22);
            this.cboMoedaEnt.TabIndex = 6;
            // 
            // cboMoedaSaida
            // 
            this.cboMoedaSaida.Location = new System.Drawing.Point(121, 113);
            this.cboMoedaSaida.Name = "cboMoedaSaida";
            this.cboMoedaSaida.Size = new System.Drawing.Size(100, 22);
            this.cboMoedaSaida.TabIndex = 7;
            // 
            // btnConverter
            // 
            this.btnConverter.Location = new System.Drawing.Point(67, 150);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(100, 26);
            this.btnConverter.TabIndex = 8;
            this.btnConverter.Text = "Converter";
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // frmEx2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.cboMoedaSaida);
            this.Controls.Add(this.cboMoedaEnt);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblMoedaSaida);
            this.Controls.Add(this.lblMoedaEnt);
            this.Controls.Add(this.lblValor);
            this.KeyPreview = true;
            this.Menu = this.mainMenu1;
            this.MinimizeBox = false;
            this.Name = "frmEx2";
            this.Text = "Conversor de Moedas";
            this.Load += new System.EventHandler(this.frmEx2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblMoedaEnt;
        private System.Windows.Forms.Label lblMoedaSaida;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.ComboBox cboMoedaEnt;
        private System.Windows.Forms.ComboBox cboMoedaSaida;
        private System.Windows.Forms.Button btnConverter;
    }
}

