namespace ProjetoCondominio
{
	partial class _ManterManutencoes
	{
		/// <summary> 
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Designer de Componentes

		/// <summary> 
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_ManterManutencoes));
			this.btnSalvar = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnLimpar = new System.Windows.Forms.Button();
			this.txtIDManutencao = new System.Windows.Forms.TextBox();
			this.rbtNao = new System.Windows.Forms.RadioButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.txtBuscar = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.pnlBuscar = new System.Windows.Forms.Panel();
			this.btnTudo = new System.Windows.Forms.Button();
			this.lstPesquisa = new System.Windows.Forms.ListBox();
			this.rbtSim = new System.Windows.Forms.RadioButton();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtOrcamentoPrevisto = new System.Windows.Forms.MaskedTextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtLocal = new System.Windows.Forms.MaskedTextBox();
			this.txtDSProblema = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnExcluir = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtDtConclusao = new System.Windows.Forms.MaskedTextBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.pnlBuscar.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnSalvar
			// 
			this.btnSalvar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSalvar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
			this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSalvar.Location = new System.Drawing.Point(124, 259);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(84, 33);
			this.btnSalvar.TabIndex = 125;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSalvar.UseVisualStyleBackColor = false;
			this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.panel2.Controls.Add(this.btnLimpar);
			this.panel2.Controls.Add(this.txtIDManutencao);
			this.panel2.Controls.Add(this.rbtNao);
			this.panel2.Controls.Add(this.panel1);
			this.panel2.Controls.Add(this.rbtSim);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.txtOrcamentoPrevisto);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.txtLocal);
			this.panel2.Controls.Add(this.txtDSProblema);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.btnExcluir);
			this.panel2.Controls.Add(this.btnSalvar);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.txtDtConclusao);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(735, 380);
			this.panel2.TabIndex = 124;
			// 
			// btnLimpar
			// 
			this.btnLimpar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnLimpar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLimpar.Location = new System.Drawing.Point(227, 261);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(75, 30);
			this.btnLimpar.TabIndex = 142;
			this.btnLimpar.Text = "Limpar";
			this.btnLimpar.UseVisualStyleBackColor = false;
			this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
			// 
			// txtIDManutencao
			// 
			this.txtIDManutencao.Location = new System.Drawing.Point(227, 207);
			this.txtIDManutencao.Name = "txtIDManutencao";
			this.txtIDManutencao.Size = new System.Drawing.Size(100, 20);
			this.txtIDManutencao.TabIndex = 139;
			this.txtIDManutencao.Visible = false;
			// 
			// rbtNao
			// 
			this.rbtNao.AutoSize = true;
			this.rbtNao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbtNao.Location = new System.Drawing.Point(283, 28);
			this.rbtNao.Name = "rbtNao";
			this.rbtNao.Size = new System.Drawing.Size(54, 23);
			this.rbtNao.TabIndex = 137;
			this.rbtNao.TabStop = true;
			this.rbtNao.Text = "Não";
			this.rbtNao.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.btnBuscar);
			this.panel1.Controls.Add(this.txtBuscar);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.pnlBuscar);
			this.panel1.Location = new System.Drawing.Point(343, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(253, 203);
			this.panel1.TabIndex = 125;
			// 
			// btnBuscar
			// 
			this.btnBuscar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnBuscar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnBuscar.Location = new System.Drawing.Point(193, 7);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(55, 24);
			this.btnBuscar.TabIndex = 119;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = false;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// txtBuscar
			// 
			this.txtBuscar.Location = new System.Drawing.Point(79, 9);
			this.txtBuscar.Name = "txtBuscar";
			this.txtBuscar.Size = new System.Drawing.Size(108, 20);
			this.txtBuscar.TabIndex = 117;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(3, 9);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(70, 19);
			this.label7.TabIndex = 118;
			this.label7.Text = "Pesquisar:";
			// 
			// pnlBuscar
			// 
			this.pnlBuscar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.pnlBuscar.Controls.Add(this.btnTudo);
			this.pnlBuscar.Controls.Add(this.lstPesquisa);
			this.pnlBuscar.Location = new System.Drawing.Point(24, 37);
			this.pnlBuscar.Name = "pnlBuscar";
			this.pnlBuscar.Size = new System.Drawing.Size(206, 157);
			this.pnlBuscar.TabIndex = 116;
			// 
			// btnTudo
			// 
			this.btnTudo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnTudo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnTudo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTudo.Image = ((System.Drawing.Image)(resources.GetObject("btnTudo.Image")));
			this.btnTudo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnTudo.Location = new System.Drawing.Point(25, 119);
			this.btnTudo.Name = "btnTudo";
			this.btnTudo.Size = new System.Drawing.Size(149, 33);
			this.btnTudo.TabIndex = 20;
			this.btnTudo.Text = "Exibir Todos";
			this.btnTudo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnTudo.UseVisualStyleBackColor = false;
			this.btnTudo.Click += new System.EventHandler(this.btnTudo_Click);
			// 
			// lstPesquisa
			// 
			this.lstPesquisa.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lstPesquisa.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstPesquisa.ForeColor = System.Drawing.Color.Goldenrod;
			this.lstPesquisa.FormattingEnabled = true;
			this.lstPesquisa.ItemHeight = 17;
			this.lstPesquisa.Location = new System.Drawing.Point(9, 7);
			this.lstPesquisa.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
			this.lstPesquisa.Name = "lstPesquisa";
			this.lstPesquisa.ScrollAlwaysVisible = true;
			this.lstPesquisa.Size = new System.Drawing.Size(194, 106);
			this.lstPesquisa.TabIndex = 7;
			this.lstPesquisa.Click += new System.EventHandler(this.lstPesquisa_Click);
			// 
			// rbtSim
			// 
			this.rbtSim.AutoSize = true;
			this.rbtSim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbtSim.Location = new System.Drawing.Point(227, 28);
			this.rbtSim.Name = "rbtSim";
			this.rbtSim.Size = new System.Drawing.Size(50, 23);
			this.rbtSim.TabIndex = 136;
			this.rbtSim.TabStop = true;
			this.rbtSim.Text = "Sim";
			this.rbtSim.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(224, 12);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(74, 19);
			this.label4.TabIndex = 138;
			this.label4.Text = "Concluído:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(23, 12);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(132, 19);
			this.label2.TabIndex = 135;
			this.label2.Text = "Orçamento previsto:";
			// 
			// txtOrcamentoPrevisto
			// 
			this.txtOrcamentoPrevisto.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtOrcamentoPrevisto.Location = new System.Drawing.Point(27, 34);
			this.txtOrcamentoPrevisto.Name = "txtOrcamentoPrevisto";
			this.txtOrcamentoPrevisto.Size = new System.Drawing.Size(181, 26);
			this.txtOrcamentoPrevisto.TabIndex = 134;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(23, 120);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(46, 19);
			this.label5.TabIndex = 133;
			this.label5.Text = "Local:";
			// 
			// txtLocal
			// 
			this.txtLocal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtLocal.Location = new System.Drawing.Point(27, 142);
			this.txtLocal.Name = "txtLocal";
			this.txtLocal.Size = new System.Drawing.Size(181, 26);
			this.txtLocal.TabIndex = 132;
			// 
			// txtDSProblema
			// 
			this.txtDSProblema.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDSProblema.Location = new System.Drawing.Point(27, 193);
			this.txtDSProblema.Multiline = true;
			this.txtDSProblema.Name = "txtDSProblema";
			this.txtDSProblema.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtDSProblema.Size = new System.Drawing.Size(181, 43);
			this.txtDSProblema.TabIndex = 131;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(23, 171);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(154, 19);
			this.label3.TabIndex = 129;
			this.label3.Text = "Descrição do problema:";
			// 
			// btnExcluir
			// 
			this.btnExcluir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnExcluir.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
			this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnExcluir.Location = new System.Drawing.Point(27, 258);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(84, 33);
			this.btnExcluir.TabIndex = 127;
			this.btnExcluir.Text = "Excluir";
			this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnExcluir.UseVisualStyleBackColor = false;
			this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(20, 64);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(124, 19);
			this.label1.TabIndex = 114;
			this.label1.Text = "Data de conclusão:";
			// 
			// txtDtConclusao
			// 
			this.txtDtConclusao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDtConclusao.Location = new System.Drawing.Point(27, 86);
			this.txtDtConclusao.Name = "txtDtConclusao";
			this.txtDtConclusao.Size = new System.Drawing.Size(181, 26);
			this.txtDtConclusao.TabIndex = 113;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// _ManterManutencoes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.Controls.Add(this.panel2);
			this.Name = "_ManterManutencoes";
			this.Size = new System.Drawing.Size(735, 380);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.pnlBuscar.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.MaskedTextBox txtDtConclusao;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.TextBox txtBuscar;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Panel pnlBuscar;
		private System.Windows.Forms.Button btnTudo;
		private System.Windows.Forms.ListBox lstPesquisa;
		private System.Windows.Forms.Button btnExcluir;
		private System.Windows.Forms.RadioButton rbtNao;
		private System.Windows.Forms.RadioButton rbtSim;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.MaskedTextBox txtOrcamentoPrevisto;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.MaskedTextBox txtLocal;
		private System.Windows.Forms.TextBox txtDSProblema;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.TextBox txtIDManutencao;
		private System.Windows.Forms.Button btnLimpar;
	}
}
