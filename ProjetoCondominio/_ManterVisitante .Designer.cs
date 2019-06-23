namespace ProjetoCondominio
{
	partial class _ManterVisitante
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_ManterVisitante));
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.txtBuscar = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.pnlBuscar = new System.Windows.Forms.Panel();
			this.btnTudo = new System.Windows.Forms.Button();
			this.lstPesquisa = new System.Windows.Forms.ListBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnLimpar = new System.Windows.Forms.Button();
			this.txtIDVisitante = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtApartamento = new System.Windows.Forms.MaskedTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtBloco = new System.Windows.Forms.MaskedTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtNome = new System.Windows.Forms.MaskedTextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtCpf = new System.Windows.Forms.MaskedTextBox();
			this.btnExcluir = new System.Windows.Forms.Button();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.pnlBuscar.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.btnBuscar);
			this.panel1.Controls.Add(this.txtBuscar);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.pnlBuscar);
			this.panel1.Location = new System.Drawing.Point(296, 19);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(253, 203);
			this.panel1.TabIndex = 129;
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
			this.lstPesquisa.SelectedIndexChanged += new System.EventHandler(this.lstPesquisa_SelectedIndexChanged);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.panel2.Controls.Add(this.btnLimpar);
			this.panel2.Controls.Add(this.txtIDVisitante);
			this.panel2.Controls.Add(this.panel1);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.txtApartamento);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.txtBloco);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.txtNome);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.txtCpf);
			this.panel2.Controls.Add(this.btnExcluir);
			this.panel2.Controls.Add(this.btnSalvar);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(735, 380);
			this.panel2.TabIndex = 128;
			// 
			// btnLimpar
			// 
			this.btnLimpar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnLimpar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLimpar.Location = new System.Drawing.Point(215, 192);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(75, 30);
			this.btnLimpar.TabIndex = 141;
			this.btnLimpar.Text = "Limpar";
			this.btnLimpar.UseVisualStyleBackColor = false;
			this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
			// 
			// txtIDVisitante
			// 
			this.txtIDVisitante.Location = new System.Drawing.Point(27, 249);
			this.txtIDVisitante.Name = "txtIDVisitante";
			this.txtIDVisitante.Size = new System.Drawing.Size(100, 20);
			this.txtIDVisitante.TabIndex = 140;
			this.txtIDVisitante.Visible = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(120, 120);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(91, 19);
			this.label4.TabIndex = 139;
			this.label4.Text = "Apartamento:";
			// 
			// txtApartamento
			// 
			this.txtApartamento.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtApartamento.Location = new System.Drawing.Point(124, 142);
			this.txtApartamento.Name = "txtApartamento";
			this.txtApartamento.Size = new System.Drawing.Size(84, 26);
			this.txtApartamento.TabIndex = 138;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(23, 120);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 19);
			this.label3.TabIndex = 137;
			this.label3.Text = "Bloco:";
			// 
			// txtBloco
			// 
			this.txtBloco.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBloco.Location = new System.Drawing.Point(27, 142);
			this.txtBloco.Name = "txtBloco";
			this.txtBloco.Size = new System.Drawing.Size(67, 26);
			this.txtBloco.TabIndex = 136;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(23, 12);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(50, 19);
			this.label2.TabIndex = 135;
			this.label2.Text = "Nome:";
			// 
			// txtNome
			// 
			this.txtNome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNome.Location = new System.Drawing.Point(27, 34);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(181, 26);
			this.txtNome.TabIndex = 134;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(23, 67);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(41, 19);
			this.label5.TabIndex = 133;
			this.label5.Text = "CPF:";
			// 
			// txtCpf
			// 
			this.txtCpf.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCpf.Location = new System.Drawing.Point(27, 89);
			this.txtCpf.Name = "txtCpf";
			this.txtCpf.Size = new System.Drawing.Size(181, 26);
			this.txtCpf.TabIndex = 132;
			// 
			// btnExcluir
			// 
			this.btnExcluir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnExcluir.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
			this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnExcluir.Location = new System.Drawing.Point(27, 189);
			this.btnExcluir.Name = "btnExcluir";
			this.btnExcluir.Size = new System.Drawing.Size(84, 33);
			this.btnExcluir.TabIndex = 127;
			this.btnExcluir.Text = "Excluir";
			this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnExcluir.UseVisualStyleBackColor = false;
			this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
			// 
			// btnSalvar
			// 
			this.btnSalvar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSalvar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
			this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSalvar.Location = new System.Drawing.Point(123, 189);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(84, 33);
			this.btnSalvar.TabIndex = 125;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSalvar.UseVisualStyleBackColor = false;
			this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
			// 
			// _ManterVisitante
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel2);
			this.Name = "_ManterVisitante";
			this.Size = new System.Drawing.Size(735, 380);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.pnlBuscar.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.TextBox txtBuscar;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Panel pnlBuscar;
		private System.Windows.Forms.Button btnTudo;
		private System.Windows.Forms.ListBox lstPesquisa;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.MaskedTextBox txtApartamento;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.MaskedTextBox txtBloco;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.MaskedTextBox txtNome;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.MaskedTextBox txtCpf;
		private System.Windows.Forms.Button btnExcluir;
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.TextBox txtIDVisitante;
		private System.Windows.Forms.Button btnLimpar;
	}
}
