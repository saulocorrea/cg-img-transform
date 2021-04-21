namespace Imagens
{
    partial class Principal
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
            this.pbImagem = new System.Windows.Forms.PictureBox();
            this.lblMedia = new System.Windows.Forms.Label();
            this.txtMedia = new System.Windows.Forms.TextBox();
            this.txtMediana = new System.Windows.Forms.TextBox();
            this.lblMediana = new System.Windows.Forms.Label();
            this.txtModa = new System.Windows.Forms.TextBox();
            this.lblModa = new System.Windows.Forms.Label();
            this.txtVariancia = new System.Windows.Forms.TextBox();
            this.lblVariancia = new System.Windows.Forms.Label();
            this.txtMenor100 = new System.Windows.Forms.TextBox();
            this.lblMenor100 = new System.Windows.Forms.Label();
            this.txtMaior150 = new System.Windows.Forms.TextBox();
            this.lblMaior150 = new System.Windows.Forms.Label();
            this.pbAlterada = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolEfeitos = new System.Windows.Forms.ToolStripMenuItem();
            this.estatisticaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aValoresMaioresOuIguaisAMédiaRecebemBrancoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bValoresMaioresOuIguaisAModaRecebem200ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cValoresMaioresOuIguaisAMedianaRecebem220ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dValoresMenoresQueAMédiaRecebem100ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eValoresMaioresQueAMédiaRecebem0EMenoresQueAMédiaRecebem255ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transformaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.espelhamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotacionar180ºToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.espelhamentoVerticalEHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btHistograma = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlterada)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbImagem
            // 
            this.pbImagem.Location = new System.Drawing.Point(232, 41);
            this.pbImagem.Name = "pbImagem";
            this.pbImagem.Size = new System.Drawing.Size(300, 300);
            this.pbImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagem.TabIndex = 1;
            this.pbImagem.TabStop = false;
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Location = new System.Drawing.Point(9, 53);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(36, 13);
            this.lblMedia.TabIndex = 2;
            this.lblMedia.Text = "Média";
            // 
            // txtMedia
            // 
            this.txtMedia.Location = new System.Drawing.Point(122, 50);
            this.txtMedia.Name = "txtMedia";
            this.txtMedia.ReadOnly = true;
            this.txtMedia.Size = new System.Drawing.Size(100, 20);
            this.txtMedia.TabIndex = 4;
            // 
            // txtMediana
            // 
            this.txtMediana.Location = new System.Drawing.Point(122, 77);
            this.txtMediana.Name = "txtMediana";
            this.txtMediana.ReadOnly = true;
            this.txtMediana.Size = new System.Drawing.Size(100, 20);
            this.txtMediana.TabIndex = 6;
            // 
            // lblMediana
            // 
            this.lblMediana.AutoSize = true;
            this.lblMediana.Location = new System.Drawing.Point(9, 80);
            this.lblMediana.Name = "lblMediana";
            this.lblMediana.Size = new System.Drawing.Size(48, 13);
            this.lblMediana.TabIndex = 5;
            this.lblMediana.Text = "Mediana";
            // 
            // txtModa
            // 
            this.txtModa.Location = new System.Drawing.Point(122, 103);
            this.txtModa.Name = "txtModa";
            this.txtModa.ReadOnly = true;
            this.txtModa.Size = new System.Drawing.Size(100, 20);
            this.txtModa.TabIndex = 8;
            // 
            // lblModa
            // 
            this.lblModa.AutoSize = true;
            this.lblModa.Location = new System.Drawing.Point(9, 106);
            this.lblModa.Name = "lblModa";
            this.lblModa.Size = new System.Drawing.Size(34, 13);
            this.lblModa.TabIndex = 7;
            this.lblModa.Text = "Moda";
            // 
            // txtVariancia
            // 
            this.txtVariancia.Location = new System.Drawing.Point(122, 129);
            this.txtVariancia.Name = "txtVariancia";
            this.txtVariancia.ReadOnly = true;
            this.txtVariancia.Size = new System.Drawing.Size(100, 20);
            this.txtVariancia.TabIndex = 10;
            // 
            // lblVariancia
            // 
            this.lblVariancia.AutoSize = true;
            this.lblVariancia.Location = new System.Drawing.Point(9, 132);
            this.lblVariancia.Name = "lblVariancia";
            this.lblVariancia.Size = new System.Drawing.Size(51, 13);
            this.lblVariancia.TabIndex = 9;
            this.lblVariancia.Text = "Variância";
            // 
            // txtMenor100
            // 
            this.txtMenor100.Location = new System.Drawing.Point(122, 155);
            this.txtMenor100.Name = "txtMenor100";
            this.txtMenor100.ReadOnly = true;
            this.txtMenor100.Size = new System.Drawing.Size(100, 20);
            this.txtMenor100.TabIndex = 12;
            // 
            // lblMenor100
            // 
            this.lblMenor100.AutoSize = true;
            this.lblMenor100.Location = new System.Drawing.Point(9, 158);
            this.lblMenor100.Name = "lblMenor100";
            this.lblMenor100.Size = new System.Drawing.Size(109, 13);
            this.lblMenor100.TabIndex = 11;
            this.lblMenor100.Text = "Pixels Menor que 100";
            // 
            // txtMaior150
            // 
            this.txtMaior150.Location = new System.Drawing.Point(122, 181);
            this.txtMaior150.Name = "txtMaior150";
            this.txtMaior150.ReadOnly = true;
            this.txtMaior150.Size = new System.Drawing.Size(100, 20);
            this.txtMaior150.TabIndex = 14;
            // 
            // lblMaior150
            // 
            this.lblMaior150.AutoSize = true;
            this.lblMaior150.Location = new System.Drawing.Point(9, 184);
            this.lblMaior150.Name = "lblMaior150";
            this.lblMaior150.Size = new System.Drawing.Size(105, 13);
            this.lblMaior150.TabIndex = 13;
            this.lblMaior150.Text = "Pixels Maior que 150";
            // 
            // pbAlterada
            // 
            this.pbAlterada.Location = new System.Drawing.Point(538, 41);
            this.pbAlterada.Name = "pbAlterada";
            this.pbAlterada.Size = new System.Drawing.Size(300, 300);
            this.pbAlterada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAlterada.TabIndex = 15;
            this.pbAlterada.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolArquivo,
            this.toolEfeitos});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(856, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolArquivo
            // 
            this.toolArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem});
            this.toolArquivo.Name = "toolArquivo";
            this.toolArquivo.Size = new System.Drawing.Size(61, 20);
            this.toolArquivo.Text = "Arquivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // toolEfeitos
            // 
            this.toolEfeitos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estatisticaToolStripMenuItem,
            this.transformaçõesToolStripMenuItem});
            this.toolEfeitos.Enabled = false;
            this.toolEfeitos.Name = "toolEfeitos";
            this.toolEfeitos.Size = new System.Drawing.Size(54, 20);
            this.toolEfeitos.Text = "Efeitos";
            // 
            // estatisticaToolStripMenuItem
            // 
            this.estatisticaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aValoresMaioresOuIguaisAMédiaRecebemBrancoToolStripMenuItem,
            this.bValoresMaioresOuIguaisAModaRecebem200ToolStripMenuItem,
            this.cValoresMaioresOuIguaisAMedianaRecebem220ToolStripMenuItem,
            this.dValoresMenoresQueAMédiaRecebem100ToolStripMenuItem,
            this.eValoresMaioresQueAMédiaRecebem0EMenoresQueAMédiaRecebem255ToolStripMenuItem});
            this.estatisticaToolStripMenuItem.Name = "estatisticaToolStripMenuItem";
            this.estatisticaToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.estatisticaToolStripMenuItem.Text = "Estatistica";
            // 
            // aValoresMaioresOuIguaisAMédiaRecebemBrancoToolStripMenuItem
            // 
            this.aValoresMaioresOuIguaisAMédiaRecebemBrancoToolStripMenuItem.Name = "aValoresMaioresOuIguaisAMédiaRecebemBrancoToolStripMenuItem";
            this.aValoresMaioresOuIguaisAMédiaRecebemBrancoToolStripMenuItem.Size = new System.Drawing.Size(491, 22);
            this.aValoresMaioresOuIguaisAMédiaRecebemBrancoToolStripMenuItem.Text = "A) Valores maiores ou iguais a média recebem branco";
            this.aValoresMaioresOuIguaisAMédiaRecebemBrancoToolStripMenuItem.Click += new System.EventHandler(this.aValoresMaioresOuIguaisAMédiaRecebemBrancoToolStripMenuItem_Click);
            // 
            // bValoresMaioresOuIguaisAModaRecebem200ToolStripMenuItem
            // 
            this.bValoresMaioresOuIguaisAModaRecebem200ToolStripMenuItem.Name = "bValoresMaioresOuIguaisAModaRecebem200ToolStripMenuItem";
            this.bValoresMaioresOuIguaisAModaRecebem200ToolStripMenuItem.Size = new System.Drawing.Size(491, 22);
            this.bValoresMaioresOuIguaisAModaRecebem200ToolStripMenuItem.Text = "B) Valores maiores ou iguais a moda recebem 200";
            this.bValoresMaioresOuIguaisAModaRecebem200ToolStripMenuItem.Click += new System.EventHandler(this.bValoresMaioresOuIguaisAModaRecebem200ToolStripMenuItem_Click);
            // 
            // cValoresMaioresOuIguaisAMedianaRecebem220ToolStripMenuItem
            // 
            this.cValoresMaioresOuIguaisAMedianaRecebem220ToolStripMenuItem.Name = "cValoresMaioresOuIguaisAMedianaRecebem220ToolStripMenuItem";
            this.cValoresMaioresOuIguaisAMedianaRecebem220ToolStripMenuItem.Size = new System.Drawing.Size(491, 22);
            this.cValoresMaioresOuIguaisAMedianaRecebem220ToolStripMenuItem.Text = "C) Valores maiores ou iguais a mediana recebem 220";
            this.cValoresMaioresOuIguaisAMedianaRecebem220ToolStripMenuItem.Click += new System.EventHandler(this.cValoresMaioresOuIguaisAMedianaRecebem220ToolStripMenuItem_Click);
            // 
            // dValoresMenoresQueAMédiaRecebem100ToolStripMenuItem
            // 
            this.dValoresMenoresQueAMédiaRecebem100ToolStripMenuItem.Name = "dValoresMenoresQueAMédiaRecebem100ToolStripMenuItem";
            this.dValoresMenoresQueAMédiaRecebem100ToolStripMenuItem.Size = new System.Drawing.Size(491, 22);
            this.dValoresMenoresQueAMédiaRecebem100ToolStripMenuItem.Text = "D) Valores menores que a média recebem 100";
            this.dValoresMenoresQueAMédiaRecebem100ToolStripMenuItem.Click += new System.EventHandler(this.dValoresMenoresQueAMédiaRecebem100ToolStripMenuItem_Click);
            // 
            // eValoresMaioresQueAMédiaRecebem0EMenoresQueAMédiaRecebem255ToolStripMenuItem
            // 
            this.eValoresMaioresQueAMédiaRecebem0EMenoresQueAMédiaRecebem255ToolStripMenuItem.Name = "eValoresMaioresQueAMédiaRecebem0EMenoresQueAMédiaRecebem255ToolStripMenuItem";
            this.eValoresMaioresQueAMédiaRecebem0EMenoresQueAMédiaRecebem255ToolStripMenuItem.Size = new System.Drawing.Size(491, 22);
            this.eValoresMaioresQueAMédiaRecebem0EMenoresQueAMédiaRecebem255ToolStripMenuItem.Text = "E) Valores maiores que a média recebem 0 e menores que a média recebem 255";
            this.eValoresMaioresQueAMédiaRecebem0EMenoresQueAMédiaRecebem255ToolStripMenuItem.Click += new System.EventHandler(this.eValoresMaioresQueAMédiaRecebem0EMenoresQueAMédiaRecebem255ToolStripMenuItem_Click);
            // 
            // transformaçõesToolStripMenuItem
            // 
            this.transformaçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.espelhamentoToolStripMenuItem,
            this.rotacionar180ºToolStripMenuItem,
            this.espelhamentoVerticalEHorizontalToolStripMenuItem});
            this.transformaçõesToolStripMenuItem.Name = "transformaçõesToolStripMenuItem";
            this.transformaçõesToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.transformaçõesToolStripMenuItem.Text = "Transformações";
            // 
            // espelhamentoToolStripMenuItem
            // 
            this.espelhamentoToolStripMenuItem.Name = "espelhamentoToolStripMenuItem";
            this.espelhamentoToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.espelhamentoToolStripMenuItem.Text = "Espelhamento Vertical";
            this.espelhamentoToolStripMenuItem.Click += new System.EventHandler(this.espelhamentoToolStripMenuItem_Click);
            // 
            // rotacionar180ºToolStripMenuItem
            // 
            this.rotacionar180ºToolStripMenuItem.Name = "rotacionar180ºToolStripMenuItem";
            this.rotacionar180ºToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.rotacionar180ºToolStripMenuItem.Text = "Espelhamento Horizontal";
            this.rotacionar180ºToolStripMenuItem.Click += new System.EventHandler(this.rotacionar180ºToolStripMenuItem_Click);
            // 
            // espelhamentoVerticalEHorizontalToolStripMenuItem
            // 
            this.espelhamentoVerticalEHorizontalToolStripMenuItem.Name = "espelhamentoVerticalEHorizontalToolStripMenuItem";
            this.espelhamentoVerticalEHorizontalToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.espelhamentoVerticalEHorizontalToolStripMenuItem.Text = "Espelhamento Vertical e Horizontal";
            this.espelhamentoVerticalEHorizontalToolStripMenuItem.Click += new System.EventHandler(this.espelhamentoVerticalEHorizontalToolStripMenuItem_Click);
            // 
            // btHistograma
            // 
            this.btHistograma.Enabled = false;
            this.btHistograma.Location = new System.Drawing.Point(12, 210);
            this.btHistograma.Name = "btHistograma";
            this.btHistograma.Size = new System.Drawing.Size(210, 23);
            this.btHistograma.TabIndex = 22;
            this.btHistograma.Text = "Mostrar Histograma";
            this.btHistograma.UseVisualStyleBackColor = true;
            this.btHistograma.Click += new System.EventHandler(this.btHistograma_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 534);
            this.Controls.Add(this.btHistograma);
            this.Controls.Add(this.pbAlterada);
            this.Controls.Add(this.txtMaior150);
            this.Controls.Add(this.lblMaior150);
            this.Controls.Add(this.txtMenor100);
            this.Controls.Add(this.lblMenor100);
            this.Controls.Add(this.txtVariancia);
            this.Controls.Add(this.lblVariancia);
            this.Controls.Add(this.txtModa);
            this.Controls.Add(this.lblModa);
            this.Controls.Add(this.txtMediana);
            this.Controls.Add(this.lblMediana);
            this.Controls.Add(this.txtMedia);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.pbImagem);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Manipulação de Imagens";
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlterada)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImagem;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.TextBox txtMedia;
        private System.Windows.Forms.TextBox txtMediana;
        private System.Windows.Forms.Label lblMediana;
        private System.Windows.Forms.TextBox txtModa;
        private System.Windows.Forms.Label lblModa;
        private System.Windows.Forms.TextBox txtVariancia;
        private System.Windows.Forms.Label lblVariancia;
        private System.Windows.Forms.TextBox txtMenor100;
        private System.Windows.Forms.Label lblMenor100;
        private System.Windows.Forms.TextBox txtMaior150;
        private System.Windows.Forms.Label lblMaior150;
        private System.Windows.Forms.PictureBox pbAlterada;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolArquivo;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolEfeitos;
        private System.Windows.Forms.ToolStripMenuItem estatisticaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aValoresMaioresOuIguaisAMédiaRecebemBrancoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bValoresMaioresOuIguaisAModaRecebem200ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cValoresMaioresOuIguaisAMedianaRecebem220ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dValoresMenoresQueAMédiaRecebem100ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eValoresMaioresQueAMédiaRecebem0EMenoresQueAMédiaRecebem255ToolStripMenuItem;
        private System.Windows.Forms.Button btHistograma;
        private System.Windows.Forms.ToolStripMenuItem transformaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem espelhamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotacionar180ºToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem espelhamentoVerticalEHorizontalToolStripMenuItem;
    }
}

