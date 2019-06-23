namespace ProjetoCondominio
{
	partial class _Reservas
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_Reservas));
			this.pnlBuscar = new System.Windows.Forms.Panel();
			this.btnLimpar = new System.Windows.Forms.Button();
			this.txtIDReserva = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.txtBuscar = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnTudo = new System.Windows.Forms.Button();
			this.lstPesquisa = new System.Windows.Forms.ListBox();
			this.lstLocais = new System.Windows.Forms.ListBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.dtLocal = new System.Windows.Forms.MaskedTextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtApartamento = new System.Windows.Forms.MaskedTextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtBloco = new System.Windows.Forms.MaskedTextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtNome = new System.Windows.Forms.MaskedTextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtCpf = new System.Windows.Forms.MaskedTextBox();
			this.pnlBuscar.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlBuscar
			// 
			this.pnlBuscar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.pnlBuscar.Controls.Add(this.btnLimpar);
			this.pnlBuscar.Controls.Add(this.txtIDReserva);
			this.pnlBuscar.Controls.Add(this.panel1);
			this.pnlBuscar.Controls.Add(this.lstLocais);
			this.pnlBuscar.Controls.Add(this.label2);
			this.pnlBuscar.Controls.Add(this.btnSalvar);
			this.pnlBuscar.Controls.Add(this.dtLocal);
			this.pnlBuscar.Controls.Add(this.label4);
			this.pnlBuscar.Controls.Add(this.txtApartamento);
			this.pnlBuscar.Controls.Add(this.label5);
			this.pnlBuscar.Controls.Add(this.txtBloco);
			this.pnlBuscar.Controls.Add(this.label6);
			this.pnlBuscar.Controls.Add(this.txtNome);
			this.pnlBuscar.Controls.Add(this.label7);
			this.pnlBuscar.Controls.Add(this.txtCpf);
			this.pnlBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlBuscar.Location = new System.Drawing.Point(0, 0);
			this.pnlBuscar.Name = "pnlBuscar";
			this.pnlBuscar.Size = new System.Drawing.Size(602, 363);
			this.pnlBuscar.TabIndex = 123;
			// 
			// btnLimpar
			// 
			this.btnLimpar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnLimpar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLimpar.Location = new System.Drawing.Point(148, 292);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(75, 30);
			this.btnLimpar.TabIndex = 158;
			this.btnLimpar.Text = "Limpar";
			this.btnLimpar.UseVisualStyleBackColor = false;
			this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
			// 
			// txtIDReserva
			// 
			this.txtIDReserva.Location = new System.Drawing.Point(285, 248);
			this.txtIDReserva.Name = "txtIDReserva";
			this.txtIDReserva.Size = new System.Drawing.Size(100, 20);
			this.txtIDReserva.TabIndex = 157;
			this.txtIDReserva.Visible = false;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.btnBuscar);
			this.panel1.Controls.Add(this.txtBuscar);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Location = new System.Drawing.Point(260, 16);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(253, 203);
			this.panel1.TabIndex = 156;
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
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(3, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 19);
			this.label1.TabIndex = 118;
			this.label1.Text = "Pesquisar:";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.panel2.Controls.Add(this.btnTudo);
			this.panel2.Controls.Add(this.lstPesquisa);
			this.panel2.Location = new System.Drawing.Point(24, 37);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(206, 157);
			this.panel2.TabIndex = 116;
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
			// lstLocais
			// 
			this.lstLocais.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lstLocais.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstLocais.ForeColor = System.Drawing.Color.Goldenrod;
			this.lstLocais.FormattingEnabled = true;
			this.lstLocais.ItemHeight = 17;
			this.lstLocais.Items.AddRange(new object[] {
            "Salão de festas",
            "Area de lazer",
            "Churrasqueira"});
			this.lstLocais.Location = new System.Drawing.Point(29, 181);
			this.lstLocais.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
			this.lstLocais.Name = "lstLocais";
			this.lstLocais.ScrollAlwaysVisible = true;
			this.lstLocais.Size = new System.Drawing.Size(194, 38);
			this.lstLocais.TabIndex = 144;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(25, 222);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(215, 19);
			this.label2.TabIndex = 155;
			this.label2.Text = "Data em que o local sera utilizado:";
			// 
			// btnSalvar
			// 
			this.btnSalvar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSalvar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
			this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSalvar.Location = new System.Drawing.Point(29, 289);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(84, 33);
			this.btnSalvar.TabIndex = 145;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSalvar.UseVisualStyleBackColor = false;
			this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
			// 
			// dtLocal
			// 
			this.dtLocal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtLocal.Location = new System.Drawing.Point(29, 244);
			this.dtLocal.Mask = "00/00/0000";
			this.dtLocal.Name = "dtLocal";
			this.dtLocal.Size = new System.Drawing.Size(208, 26);
			this.dtLocal.TabIndex = 154;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(122, 121);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(91, 19);
			this.label4.TabIndex = 153;
			this.label4.Text = "Apartamento:";
			// 
			// txtApartamento
			// 
			this.txtApartamento.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtApartamento.Location = new System.Drawing.Point(126, 143);
			this.txtApartamento.Name = "txtApartamento";
			this.txtApartamento.Size = new System.Drawing.Size(84, 26);
			this.txtApartamento.TabIndex = 152;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(25, 121);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(48, 19);
			this.label5.TabIndex = 151;
			this.label5.Text = "Bloco:";
			// 
			// txtBloco
			// 
			this.txtBloco.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBloco.Location = new System.Drawing.Point(29, 143);
			this.txtBloco.Name = "txtBloco";
			this.txtBloco.Size = new System.Drawing.Size(67, 26);
			this.txtBloco.TabIndex = 150;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(25, 13);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(50, 19);
			this.label6.TabIndex = 149;
			this.label6.Text = "Nome:";
			// 
			// txtNome
			// 
			this.txtNome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNome.Location = new System.Drawing.Point(29, 35);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(181, 26);
			this.txtNome.TabIndex = 148;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(25, 68);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(41, 19);
			this.label7.TabIndex = 147;
			this.label7.Text = "CPF:";
			// 
			// txtCpf
			// 
			this.txtCpf.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCpf.Location = new System.Drawing.Point(29, 90);
			this.txtCpf.Name = "txtCpf";
			this.txtCpf.Size = new System.Drawing.Size(181, 26);
			this.txtCpf.TabIndex = 146;
			// 
			// _Reservas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.pnlBuscar);
			this.Name = "_Reservas";
			this.Size = new System.Drawing.Size(602, 363);
			this.pnlBuscar.ResumeLayout(false);
			this.pnlBuscar.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlBuscar;
		private System.Windows.Forms.ListBox lstLocais;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.MaskedTextBox dtLocal;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.MaskedTextBox txtApartamento;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.MaskedTextBox txtBloco;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.MaskedTextBox txtNome;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.MaskedTextBox txtCpf;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.TextBox txtBuscar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnTudo;
		private System.Windows.Forms.ListBox lstPesquisa;
		private System.Windows.Forms.TextBox txtIDReserva;
		private System.Windows.Forms.Button btnLimpar;
	}
}
