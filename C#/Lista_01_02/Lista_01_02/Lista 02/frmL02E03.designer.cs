namespace Lista_01_e_02
{
    partial class frmL02E03
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
            this.btnInsere = new System.Windows.Forms.Button();
            this.btnRetira = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtNome = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btnInsere
            // 
            this.btnInsere.Location = new System.Drawing.Point(33, 181);
            this.btnInsere.Name = "btnInsere";
            this.btnInsere.Size = new System.Drawing.Size(75, 23);
            this.btnInsere.TabIndex = 0;
            this.btnInsere.Text = "Insere";
            this.btnInsere.UseVisualStyleBackColor = true;
            this.btnInsere.Click += new System.EventHandler(this.btnInsere_Click);
            // 
            // btnRetira
            // 
            this.btnRetira.Location = new System.Drawing.Point(128, 181);
            this.btnRetira.Name = "btnRetira";
            this.btnRetira.Size = new System.Drawing.Size(75, 23);
            this.btnRetira.TabIndex = 1;
            this.btnRetira.Text = "Retira";
            this.btnRetira.UseVisualStyleBackColor = true;
            this.btnRetira.Click += new System.EventHandler(this.btnRetira_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome:";
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(363, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(257, 264);
            this.listBox1.TabIndex = 4;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(66, 35);
            this.txtNome.Mask = "00000";
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 5;
            this.txtNome.ValidatingType = typeof(int);
            // 
            // frmL02E03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 273);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRetira);
            this.Controls.Add(this.btnInsere);
            this.Name = "frmL02E03";
            this.Text = "Lista 02, exercício 03";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsere;
        private System.Windows.Forms.Button btnRetira;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.MaskedTextBox txtNome;
    }
}

