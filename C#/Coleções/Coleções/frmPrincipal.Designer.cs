namespace Coleções
{
    partial class frmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.coleçõsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrayListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hashTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortedListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoExemploEmSalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exemplo1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exemplo2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.coleçõsToolStripMenuItem,
            this.novoExemploEmSalaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(626, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // coleçõsToolStripMenuItem
            // 
            this.coleçõsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arrayListToolStripMenuItem,
            this.queuToolStripMenuItem,
            this.stackToolStripMenuItem,
            this.hashTableToolStripMenuItem,
            this.sortedListToolStripMenuItem,
            this.toolStripMenuItem1,
            this.sairToolStripMenuItem});
            this.coleçõsToolStripMenuItem.Name = "coleçõsToolStripMenuItem";
            this.coleçõsToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.coleçõsToolStripMenuItem.Text = "Coleções";
            // 
            // arrayListToolStripMenuItem
            // 
            this.arrayListToolStripMenuItem.Name = "arrayListToolStripMenuItem";
            this.arrayListToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.arrayListToolStripMenuItem.Text = "ArrayList";
            this.arrayListToolStripMenuItem.Click += new System.EventHandler(this.arrayListToolStripMenuItem_Click);
            // 
            // queuToolStripMenuItem
            // 
            this.queuToolStripMenuItem.Name = "queuToolStripMenuItem";
            this.queuToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.queuToolStripMenuItem.Text = "Queue";
            this.queuToolStripMenuItem.Click += new System.EventHandler(this.queuToolStripMenuItem_Click);
            // 
            // stackToolStripMenuItem
            // 
            this.stackToolStripMenuItem.Name = "stackToolStripMenuItem";
            this.stackToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.stackToolStripMenuItem.Text = "Stack";
            this.stackToolStripMenuItem.Click += new System.EventHandler(this.stackToolStripMenuItem_Click);
            // 
            // hashTableToolStripMenuItem
            // 
            this.hashTableToolStripMenuItem.Name = "hashTableToolStripMenuItem";
            this.hashTableToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hashTableToolStripMenuItem.Text = "HashTable";
            this.hashTableToolStripMenuItem.Click += new System.EventHandler(this.hashTableToolStripMenuItem_Click);
            // 
            // sortedListToolStripMenuItem
            // 
            this.sortedListToolStripMenuItem.Name = "sortedListToolStripMenuItem";
            this.sortedListToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sortedListToolStripMenuItem.Text = "SortedList";
            this.sortedListToolStripMenuItem.Click += new System.EventHandler(this.sortedListToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // novoExemploEmSalaToolStripMenuItem
            // 
            this.novoExemploEmSalaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exemplo1ToolStripMenuItem,
            this.exemplo2ToolStripMenuItem});
            this.novoExemploEmSalaToolStripMenuItem.Name = "novoExemploEmSalaToolStripMenuItem";
            this.novoExemploEmSalaToolStripMenuItem.Size = new System.Drawing.Size(140, 20);
            this.novoExemploEmSalaToolStripMenuItem.Text = "Novo Exemplo em Sala";
            // 
            // exemplo1ToolStripMenuItem
            // 
            this.exemplo1ToolStripMenuItem.Name = "exemplo1ToolStripMenuItem";
            this.exemplo1ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exemplo1ToolStripMenuItem.Text = "Exemplo 1";
            this.exemplo1ToolStripMenuItem.Click += new System.EventHandler(this.exemplo1ToolStripMenuItem_Click);
            // 
            // exemplo2ToolStripMenuItem
            // 
            this.exemplo2ToolStripMenuItem.Name = "exemplo2ToolStripMenuItem";
            this.exemplo2ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exemplo2ToolStripMenuItem.Text = "Exemplo 2";
            this.exemplo2ToolStripMenuItem.Click += new System.EventHandler(this.exemplo2ToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 262);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "Coleções";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem coleçõsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrayListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hashTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortedListToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoExemploEmSalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exemplo1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exemplo2ToolStripMenuItem;
    }
}

