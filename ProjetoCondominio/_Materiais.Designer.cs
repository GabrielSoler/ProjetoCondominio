﻿namespace ProjetoCondominio
{
	partial class _Materiais
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_Materiais));
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.txtBuscar = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.pnlBuscar = new System.Windows.Forms.Panel();
			this.btnTudo = new System.Windows.Forms.Button();
			this.lstPesquisa = new System.Windows.Forms.ListBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.btnSalvar = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
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
			this.panel1.Location = new System.Drawing.Point(309, 19);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(253, 203);
			this.panel1.TabIndex = 127;
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
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.panel2.Controls.Add(this.panel1);
			this.panel2.Controls.Add(this.button1);
			this.panel2.Controls.Add(this.btnSalvar);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.maskedTextBox3);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.maskedTextBox2);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.maskedTextBox1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(735, 380);
			this.panel2.TabIndex = 126;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button1.Location = new System.Drawing.Point(62, 189);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(84, 33);
			this.button1.TabIndex = 127;
			this.button1.Text = "Excluir";
			this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button1.UseVisualStyleBackColor = false;
			// 
			// btnSalvar
			// 
			this.btnSalvar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSalvar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
			this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSalvar.Location = new System.Drawing.Point(162, 189);
			this.btnSalvar.Name = "btnSalvar";
			this.btnSalvar.Size = new System.Drawing.Size(84, 33);
			this.btnSalvar.TabIndex = 125;
			this.btnSalvar.Text = "Salvar";
			this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSalvar.UseVisualStyleBackColor = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(58, 17);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(121, 19);
			this.label4.TabIndex = 121;
			this.label4.Text = "Nome do material:";
			// 
			// maskedTextBox3
			// 
			this.maskedTextBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.maskedTextBox3.Location = new System.Drawing.Point(65, 39);
			this.maskedTextBox3.Name = "maskedTextBox3";
			this.maskedTextBox3.Size = new System.Drawing.Size(181, 26);
			this.maskedTextBox3.TabIndex = 120;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(61, 121);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(132, 19);
			this.label2.TabIndex = 116;
			this.label2.Text = "Orçamento previsto:";
			// 
			// maskedTextBox2
			// 
			this.maskedTextBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.maskedTextBox2.Location = new System.Drawing.Point(65, 143);
			this.maskedTextBox2.Name = "maskedTextBox2";
			this.maskedTextBox2.Size = new System.Drawing.Size(181, 26);
			this.maskedTextBox2.TabIndex = 115;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(58, 74);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(92, 19);
			this.label1.TabIndex = 114;
			this.label1.Text = "Valor unitário:";
			// 
			// maskedTextBox1
			// 
			this.maskedTextBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.maskedTextBox1.Location = new System.Drawing.Point(65, 96);
			this.maskedTextBox1.Name = "maskedTextBox1";
			this.maskedTextBox1.Size = new System.Drawing.Size(181, 26);
			this.maskedTextBox1.TabIndex = 113;
			// 
			// _Materiais
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.Controls.Add(this.panel2);
			this.Name = "_Materiais";
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
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btnSalvar;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.MaskedTextBox maskedTextBox3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.MaskedTextBox maskedTextBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.MaskedTextBox maskedTextBox1;
	}
}
