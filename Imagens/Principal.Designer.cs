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
            this.rotação90GrausToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ampliaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reduçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btHistograma = new System.Windows.Forms.Button();
            this.morfologiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.erosãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dilataçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aberturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fechamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpMorfologia = new System.Windows.Forms.GroupBox();
            this.lblFator = new System.Windows.Forms.Label();
            this.btErosao = new System.Windows.Forms.Button();
            this.btDilatacao = new System.Windows.Forms.Button();
            this.btAbertura = new System.Windows.Forms.Button();
            this.btFechamento = new System.Windows.Forms.Button();
            this.txtFator = new System.Windows.Forms.NumericUpDown();
            this.btReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlterada)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.grpMorfologia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFator)).BeginInit();
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
            this.txtMedia.Size = new System.Drawing.Size(100, 20);
            this.txtMedia.TabIndex = 4;
            // 
            // txtMediana
            // 
            this.txtMediana.Location = new System.Drawing.Point(122, 77);
            this.txtMediana.Name = "txtMediana";
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
            this.transformaçõesToolStripMenuItem,
            this.morfologiaToolStripMenuItem});
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
            this.estatisticaToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.estatisticaToolStripMenuItem.Text = "Estatistica";
            // 
            // aValoresMaioresOuIguaisAMédiaRecebemBrancoToolStripMenuItem
            // 
            this.aValoresMaioresOuIguaisAMédiaRecebemBrancoToolStripMenuItem.Name = "aValoresMaioresOuIguaisAMédiaRecebemBrancoToolStripMenuItem";
            this.aValoresMaioresOuIguaisAMédiaRecebemBrancoToolStripMenuItem.Size = new System.Drawing.Size(492, 22);
            this.aValoresMaioresOuIguaisAMédiaRecebemBrancoToolStripMenuItem.Text = "A) Valores maiores ou iguais a média recebem branco";
            this.aValoresMaioresOuIguaisAMédiaRecebemBrancoToolStripMenuItem.Click += new System.EventHandler(this.aValoresMaioresOuIguaisAMédiaRecebemBrancoToolStripMenuItem_Click);
            // 
            // bValoresMaioresOuIguaisAModaRecebem200ToolStripMenuItem
            // 
            this.bValoresMaioresOuIguaisAModaRecebem200ToolStripMenuItem.Name = "bValoresMaioresOuIguaisAModaRecebem200ToolStripMenuItem";
            this.bValoresMaioresOuIguaisAModaRecebem200ToolStripMenuItem.Size = new System.Drawing.Size(492, 22);
            this.bValoresMaioresOuIguaisAModaRecebem200ToolStripMenuItem.Text = "B) Valores maiores ou iguais a moda recebem 200";
            this.bValoresMaioresOuIguaisAModaRecebem200ToolStripMenuItem.Click += new System.EventHandler(this.bValoresMaioresOuIguaisAModaRecebem200ToolStripMenuItem_Click);
            // 
            // cValoresMaioresOuIguaisAMedianaRecebem220ToolStripMenuItem
            // 
            this.cValoresMaioresOuIguaisAMedianaRecebem220ToolStripMenuItem.Name = "cValoresMaioresOuIguaisAMedianaRecebem220ToolStripMenuItem";
            this.cValoresMaioresOuIguaisAMedianaRecebem220ToolStripMenuItem.Size = new System.Drawing.Size(492, 22);
            this.cValoresMaioresOuIguaisAMedianaRecebem220ToolStripMenuItem.Text = "C) Valores maiores ou iguais a mediana recebem 220";
            this.cValoresMaioresOuIguaisAMedianaRecebem220ToolStripMenuItem.Click += new System.EventHandler(this.cValoresMaioresOuIguaisAMedianaRecebem220ToolStripMenuItem_Click);
            // 
            // dValoresMenoresQueAMédiaRecebem100ToolStripMenuItem
            // 
            this.dValoresMenoresQueAMédiaRecebem100ToolStripMenuItem.Name = "dValoresMenoresQueAMédiaRecebem100ToolStripMenuItem";
            this.dValoresMenoresQueAMédiaRecebem100ToolStripMenuItem.Size = new System.Drawing.Size(492, 22);
            this.dValoresMenoresQueAMédiaRecebem100ToolStripMenuItem.Text = "D) Valores menores que a média recebem 100";
            this.dValoresMenoresQueAMédiaRecebem100ToolStripMenuItem.Click += new System.EventHandler(this.dValoresMenoresQueAMédiaRecebem100ToolStripMenuItem_Click);
            // 
            // eValoresMaioresQueAMédiaRecebem0EMenoresQueAMédiaRecebem255ToolStripMenuItem
            // 
            this.eValoresMaioresQueAMédiaRecebem0EMenoresQueAMédiaRecebem255ToolStripMenuItem.Name = "eValoresMaioresQueAMédiaRecebem0EMenoresQueAMédiaRecebem255ToolStripMenuItem";
            this.eValoresMaioresQueAMédiaRecebem0EMenoresQueAMédiaRecebem255ToolStripMenuItem.Size = new System.Drawing.Size(492, 22);
            this.eValoresMaioresQueAMédiaRecebem0EMenoresQueAMédiaRecebem255ToolStripMenuItem.Text = "E) Valores maiores que a média recebem 0 e menores que a média recebem 255";
            this.eValoresMaioresQueAMédiaRecebem0EMenoresQueAMédiaRecebem255ToolStripMenuItem.Click += new System.EventHandler(this.eValoresMaioresQueAMédiaRecebem0EMenoresQueAMédiaRecebem255ToolStripMenuItem_Click);
            // 
            // transformaçõesToolStripMenuItem
            // 
            this.transformaçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.espelhamentoToolStripMenuItem,
            this.rotacionar180ºToolStripMenuItem,
            this.espelhamentoVerticalEHorizontalToolStripMenuItem,
            this.rotação90GrausToolStripMenuItem,
            this.ampliaçãoToolStripMenuItem,
            this.reduçãoToolStripMenuItem});
            this.transformaçõesToolStripMenuItem.Name = "transformaçõesToolStripMenuItem";
            this.transformaçõesToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.transformaçõesToolStripMenuItem.Text = "Transformações";
            // 
            // espelhamentoToolStripMenuItem
            // 
            this.espelhamentoToolStripMenuItem.Name = "espelhamentoToolStripMenuItem";
            this.espelhamentoToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.espelhamentoToolStripMenuItem.Text = "Espelhamento Vertical";
            this.espelhamentoToolStripMenuItem.Click += new System.EventHandler(this.espelhamentoToolStripMenuItem_Click);
            // 
            // rotacionar180ºToolStripMenuItem
            // 
            this.rotacionar180ºToolStripMenuItem.Name = "rotacionar180ºToolStripMenuItem";
            this.rotacionar180ºToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.rotacionar180ºToolStripMenuItem.Text = "Espelhamento Horizontal";
            this.rotacionar180ºToolStripMenuItem.Click += new System.EventHandler(this.rotacionar180ºToolStripMenuItem_Click);
            // 
            // espelhamentoVerticalEHorizontalToolStripMenuItem
            // 
            this.espelhamentoVerticalEHorizontalToolStripMenuItem.Name = "espelhamentoVerticalEHorizontalToolStripMenuItem";
            this.espelhamentoVerticalEHorizontalToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.espelhamentoVerticalEHorizontalToolStripMenuItem.Text = "Espelhamento Vertical e Horizontal";
            this.espelhamentoVerticalEHorizontalToolStripMenuItem.Click += new System.EventHandler(this.espelhamentoVerticalEHorizontalToolStripMenuItem_Click);
            // 
            // rotação90GrausToolStripMenuItem
            // 
            this.rotação90GrausToolStripMenuItem.Name = "rotação90GrausToolStripMenuItem";
            this.rotação90GrausToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.rotação90GrausToolStripMenuItem.Text = "Rotação 90 Graus";
            this.rotação90GrausToolStripMenuItem.Click += new System.EventHandler(this.rotação90GrausToolStripMenuItem_Click);
            // 
            // ampliaçãoToolStripMenuItem
            // 
            this.ampliaçãoToolStripMenuItem.Name = "ampliaçãoToolStripMenuItem";
            this.ampliaçãoToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.ampliaçãoToolStripMenuItem.Text = "Ampliação";
            this.ampliaçãoToolStripMenuItem.Click += new System.EventHandler(this.ampliaçãoToolStripMenuItem_Click);
            // 
            // reduçãoToolStripMenuItem
            // 
            this.reduçãoToolStripMenuItem.Name = "reduçãoToolStripMenuItem";
            this.reduçãoToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.reduçãoToolStripMenuItem.Text = "Redução";
            this.reduçãoToolStripMenuItem.Click += new System.EventHandler(this.reduçãoToolStripMenuItem_Click);
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
            // morfologiaToolStripMenuItem
            // 
            this.morfologiaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.erosãoToolStripMenuItem,
            this.dilataçãoToolStripMenuItem,
            this.aberturaToolStripMenuItem,
            this.fechamentoToolStripMenuItem});
            this.morfologiaToolStripMenuItem.Name = "morfologiaToolStripMenuItem";
            this.morfologiaToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.morfologiaToolStripMenuItem.Text = "Morfologia";
            // 
            // erosãoToolStripMenuItem
            // 
            this.erosãoToolStripMenuItem.Name = "erosãoToolStripMenuItem";
            this.erosãoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.erosãoToolStripMenuItem.Text = "Erosão";
            this.erosãoToolStripMenuItem.Click += new System.EventHandler(this.erosãoToolStripMenuItem_Click);
            // 
            // dilataçãoToolStripMenuItem
            // 
            this.dilataçãoToolStripMenuItem.Name = "dilataçãoToolStripMenuItem";
            this.dilataçãoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dilataçãoToolStripMenuItem.Text = "Dilatação";
            this.dilataçãoToolStripMenuItem.Click += new System.EventHandler(this.dilataçãoToolStripMenuItem_Click);
            // 
            // aberturaToolStripMenuItem
            // 
            this.aberturaToolStripMenuItem.Name = "aberturaToolStripMenuItem";
            this.aberturaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aberturaToolStripMenuItem.Text = "Abertura";
            this.aberturaToolStripMenuItem.Click += new System.EventHandler(this.aberturaToolStripMenuItem_Click);
            // 
            // fechamentoToolStripMenuItem
            // 
            this.fechamentoToolStripMenuItem.Name = "fechamentoToolStripMenuItem";
            this.fechamentoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fechamentoToolStripMenuItem.Text = "Fechamento";
            this.fechamentoToolStripMenuItem.Click += new System.EventHandler(this.fechamentoToolStripMenuItem_Click);
            // 
            // grpMorfologia
            // 
            this.grpMorfologia.Controls.Add(this.btReset);
            this.grpMorfologia.Controls.Add(this.txtFator);
            this.grpMorfologia.Controls.Add(this.btFechamento);
            this.grpMorfologia.Controls.Add(this.btAbertura);
            this.grpMorfologia.Controls.Add(this.btDilatacao);
            this.grpMorfologia.Controls.Add(this.btErosao);
            this.grpMorfologia.Controls.Add(this.lblFator);
            this.grpMorfologia.Enabled = false;
            this.grpMorfologia.Location = new System.Drawing.Point(232, 348);
            this.grpMorfologia.Name = "grpMorfologia";
            this.grpMorfologia.Size = new System.Drawing.Size(245, 174);
            this.grpMorfologia.TabIndex = 23;
            this.grpMorfologia.TabStop = false;
            this.grpMorfologia.Text = "Morfologia";
            // 
            // lblFator
            // 
            this.lblFator.AutoSize = true;
            this.lblFator.Location = new System.Drawing.Point(102, 22);
            this.lblFator.Name = "lblFator";
            this.lblFator.Size = new System.Drawing.Size(31, 13);
            this.lblFator.TabIndex = 1;
            this.lblFator.Text = "Fator";
            // 
            // btErosao
            // 
            this.btErosao.Location = new System.Drawing.Point(6, 46);
            this.btErosao.Name = "btErosao";
            this.btErosao.Size = new System.Drawing.Size(232, 23);
            this.btErosao.TabIndex = 2;
            this.btErosao.Text = "Erosão";
            this.btErosao.UseVisualStyleBackColor = true;
            this.btErosao.Click += new System.EventHandler(this.btErosao_Click);
            // 
            // btDilatacao
            // 
            this.btDilatacao.Location = new System.Drawing.Point(6, 70);
            this.btDilatacao.Name = "btDilatacao";
            this.btDilatacao.Size = new System.Drawing.Size(232, 23);
            this.btDilatacao.TabIndex = 3;
            this.btDilatacao.Text = "Dilatação";
            this.btDilatacao.UseVisualStyleBackColor = true;
            this.btDilatacao.Click += new System.EventHandler(this.btDilatacao_Click);
            // 
            // btAbertura
            // 
            this.btAbertura.Location = new System.Drawing.Point(6, 94);
            this.btAbertura.Name = "btAbertura";
            this.btAbertura.Size = new System.Drawing.Size(232, 23);
            this.btAbertura.TabIndex = 4;
            this.btAbertura.Text = "Abertura";
            this.btAbertura.UseVisualStyleBackColor = true;
            this.btAbertura.Click += new System.EventHandler(this.btAbertura_Click);
            // 
            // btFechamento
            // 
            this.btFechamento.Location = new System.Drawing.Point(6, 117);
            this.btFechamento.Name = "btFechamento";
            this.btFechamento.Size = new System.Drawing.Size(232, 23);
            this.btFechamento.TabIndex = 5;
            this.btFechamento.Text = "Fechamento";
            this.btFechamento.UseVisualStyleBackColor = true;
            this.btFechamento.Click += new System.EventHandler(this.btFechamento_Click);
            // 
            // txtFator
            // 
            this.txtFator.Location = new System.Drawing.Point(139, 20);
            this.txtFator.Name = "txtFator";
            this.txtFator.Size = new System.Drawing.Size(98, 20);
            this.txtFator.TabIndex = 6;
            this.txtFator.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(6, 142);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(232, 23);
            this.btReset.TabIndex = 7;
            this.btReset.Text = "Reseta Imagem";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 534);
            this.Controls.Add(this.grpMorfologia);
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
            this.grpMorfologia.ResumeLayout(false);
            this.grpMorfologia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFator)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem rotação90GrausToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ampliaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reduçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem morfologiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem erosãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dilataçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aberturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fechamentoToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpMorfologia;
        private System.Windows.Forms.Button btFechamento;
        private System.Windows.Forms.Button btAbertura;
        private System.Windows.Forms.Button btDilatacao;
        private System.Windows.Forms.Button btErosao;
        private System.Windows.Forms.Label lblFator;
        private System.Windows.Forms.NumericUpDown txtFator;
        private System.Windows.Forms.Button btReset;
    }
}

