namespace ProjetoCondominio
{
	partial class _RelatoriosDeCustos
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_RelatoriosDeCustos));
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.txtIDCusto = new System.Windows.Forms.TextBox();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.btnTodosMaterias = new System.Windows.Forms.Button();
			this.btnBuscaMaterial = new System.Windows.Forms.Button();
			this.txtBuscaMaterial = new System.Windows.Forms.TextBox();
			this.btnBuscaManutencao = new System.Windows.Forms.Button();
			this.txtBuscaManutencao = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtValorGasto = new System.Windows.Forms.MaskedTextBox();
			this.lstManutencao = new System.Windows.Forms.ListBox();
			this.label6 = new System.Windows.Forms.Label();
			this.btnExcluir = new System.Windows.Forms.Button();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.btnAdicionar = new System.Windows.Forms.Button();
			this.txtQuantidade = new System.Windows.Forms.MaskedTextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.lstMaterial = new System.Windows.Forms.ListBox();
			this.label8 = new System.Windows.Forms.Label();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.panel2.Controls.Add(this.panel1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(735, 380);
			this.panel2.TabIndex = 129;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.panel1.Controls.Add(this.txtIDCusto);
			this.panel1.Controls.Add(this.dataGridView);
			this.panel1.Controls.Add(this.btnTodosMaterias);
			this.panel1.Controls.Add(this.btnBuscaMaterial);
			this.panel1.Controls.Add(this.txtBuscaMaterial);
			this.panel1.Controls.Add(this.btnBuscaManutencao);
			this.panel1.Controls.Add(this.txtBuscaManutencao);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.txtValorGasto);
			this.panel1.Controls.Add(this.lstManutencao);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.btnExcluir);
			this.panel1.Controls.Add(this.btnSalvar);
			this.panel1.Controls.Add(this.btnAdicionar);
			this.panel1.Controls.Add(this.txtQuantidade);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.lstMaterial);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(735, 380);
			this.panel1.TabIndex = 143;
			// 
			// txtIDCusto
			// 
			this.txtIDCusto.Location = new System.Drawing.Point(473, 316);
			this.txtIDCusto.Name = "txtIDCusto";
			this.txtIDCusto.Size = new System.Drawing.Size(100, 20);
			this.txtIDCusto.TabIndex = 146;
			this.txtIDCusto.Visible = false;
			// 
			// dataGridView
			// 
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Location = new System.Drawing.Point(31, 157);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.Size = new System.Drawing.Size(423, 190);
			this.dataGridView.TabIndex = 145;
			// 
			// btnTodosMaterias
			// 
			this.btnTodosMaterias.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnTodosMaterias.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnTodosMaterias.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTodosMaterias.Image = ((System.Drawing.Image)(resources.GetObject("btnTodosMaterias.Image")));
			this.btnTodosMaterias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnTodosMaterias.Location = new System.Drawing.Point(338, 118);
			this.btnTodosMaterias.Name = "btnTodosMaterias";
			this.btnTodosMaterias.Size = new System.Drawing.Size(220, 33);
			this.btnTodosMaterias.TabIndex = 144;
			this.btnTodosMaterias.Text = "Exibir todos materiais";
			this.btnTodosMaterias.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnTodosMaterias.UseVisualStyleBackColor = false;
			this.btnTodosMaterias.Click += new System.EventHandler(this.btnTodosMaterias_Click);
			// 
			// btnBuscaMaterial
			// 
			this.btnBuscaMaterial.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnBuscaMaterial.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnBuscaMaterial.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBuscaMaterial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnBuscaMaterial.Location = new System.Drawing.Point(503, 11);
			this.btnBuscaMaterial.Name = "btnBuscaMaterial";
			this.btnBuscaMaterial.Size = new System.Drawing.Size(55, 24);
			this.btnBuscaMaterial.TabIndex = 143;
			this.btnBuscaMaterial.Text = "Buscar";
			this.btnBuscaMaterial.UseVisualStyleBackColor = false;
			this.btnBuscaMaterial.Click += new System.EventHandler(this.btnBuscaMaterial_Click);
			// 
			// txtBuscaMaterial
			// 
			this.txtBuscaMaterial.Location = new System.Drawing.Point(389, 13);
			this.txtBuscaMaterial.Name = "txtBuscaMaterial";
			this.txtBuscaMaterial.Size = new System.Drawing.Size(108, 20);
			this.txtBuscaMaterial.TabIndex = 142;
			// 
			// btnBuscaManutencao
			// 
			this.btnBuscaManutencao.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnBuscaManutencao.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnBuscaManutencao.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBuscaManutencao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnBuscaManutencao.Location = new System.Drawing.Point(231, 13);
			this.btnBuscaManutencao.Name = "btnBuscaManutencao";
			this.btnBuscaManutencao.Size = new System.Drawing.Size(55, 24);
			this.btnBuscaManutencao.TabIndex = 119;
			this.btnBuscaManutencao.Text = "Buscar";
			this.btnBuscaManutencao.UseVisualStyleBackColor = false;
			this.btnBuscaManutencao.Click += new System.EventHandler(this.btnBuscaManutencao_Click);
			// 
			// txtBuscaManutencao
			// 
			this.txtBuscaManutencao.Location = new System.Drawing.Point(117, 15);
			this.txtBuscaManutencao.Name = "txtBuscaManutencao";
			this.txtBuscaManutencao.Size = new System.Drawing.Size(108, 20);
			this.txtBuscaManutencao.TabIndex = 117;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(470, 183);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(80, 19);
			this.label5.TabIndex = 139;
			this.label5.Text = "Valor gasto:";
			// 
			// txtValorGasto
			// 
			this.txtValorGasto.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtValorGasto.Location = new System.Drawing.Point(474, 205);
			this.txtValorGasto.Name = "txtValorGasto";
			this.txtValorGasto.ReadOnly = true;
			this.txtValorGasto.Size = new System.Drawing.Size(181, 26);
			this.txtValorGasto.TabIndex = 138;
			// 
			// lstManutencao
			// 
			this.lstManutencao.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lstManutencao.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstManutencao.ForeColor = System.Drawing.Color.Goldenrod;
			this.lstManutencao.FormattingEnabled = true;
			this.lstManutencao.ItemHeight = 17;
			this.lstManutencao.Location = new System.Drawing.Point(31, 40);
			this.lstManutencao.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
			this.lstManutencao.Name = "lstManutencao";
			this.lstManutencao.ScrollAlwaysVisible = true;
			this.lstManutencao.Size = new System.Drawing.Size(255, 72);
			this.lstManutencao.TabIndex = 137;
			this.lstManutencao.Click += new System.EventHandler(this.lstManutencao_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(27, 18);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(87, 19);
			this.label6.TabIndex = 136;
			this.label6.Text = "Manutenção:";
			// 
			// btnExcluir
			// 
			this.btnExcluir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnExcluir.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
			this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnExcluir.Location = new System.Drawing.Point(473, 251);
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
			this.btnSalvar.Location = new System.Drawing.Point(571, 251);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(84, 33);
			this.btnSalvar.TabIndex = 125;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSalvar.UseVisualStyleBackColor = false;
			this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
			// 
			// btnAdicionar
			// 
			this.btnAdicionar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAdicionar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionar.Image")));
			this.btnAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAdicionar.Location = new System.Drawing.Point(584, 79);
			this.btnAdicionar.Name = "btnAdicionar";
			this.btnAdicionar.Size = new System.Drawing.Size(108, 33);
			this.btnAdicionar.TabIndex = 130;
			this.btnAdicionar.Text = "Adicionar";
			this.btnAdicionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAdicionar.UseVisualStyleBackColor = false;
			this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
			// 
			// txtQuantidade
			// 
			this.txtQuantidade.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtQuantidade.Location = new System.Drawing.Point(584, 40);
			this.txtQuantidade.Mask = "999";
			this.txtQuantidade.Name = "txtQuantidade";
			this.txtQuantidade.Size = new System.Drawing.Size(108, 26);
			this.txtQuantidade.TabIndex = 127;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(584, 18);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(82, 19);
			this.label7.TabIndex = 128;
			this.label7.Text = "Quantidade:";
			// 
			// lstMaterial
			// 
			this.lstMaterial.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lstMaterial.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstMaterial.ForeColor = System.Drawing.Color.Goldenrod;
			this.lstMaterial.FormattingEnabled = true;
			this.lstMaterial.ItemHeight = 17;
			this.lstMaterial.Location = new System.Drawing.Point(319, 40);
			this.lstMaterial.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
			this.lstMaterial.Name = "lstMaterial";
			this.lstMaterial.ScrollAlwaysVisible = true;
			this.lstMaterial.Size = new System.Drawing.Size(259, 72);
			this.lstMaterial.TabIndex = 126;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(315, 18);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(68, 19);
			this.label8.TabIndex = 125;
			this.label8.Text = "Materiais:";
			// 
			// _RelatoriosDeCustos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel2);
			this.Name = "_RelatoriosDeCustos";
			this.Size = new System.Drawing.Size(735, 380);
			this.Load += new System.EventHandler(this._RelatoriosDeCustos_Load);
			this.panel2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.Button btnTodosMaterias;
		private System.Windows.Forms.Button btnBuscaMaterial;
		private System.Windows.Forms.TextBox txtBuscaMaterial;
		private System.Windows.Forms.Button btnBuscaManutencao;
		private System.Windows.Forms.TextBox txtBuscaManutencao;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.MaskedTextBox txtValorGasto;
		private System.Windows.Forms.ListBox lstManutencao;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnExcluir;
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.Button btnAdicionar;
		private System.Windows.Forms.MaskedTextBox txtQuantidade;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ListBox lstMaterial;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtIDCusto;
	}
}
