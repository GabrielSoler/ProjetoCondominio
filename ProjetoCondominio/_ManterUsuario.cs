using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCondominio
{
	public partial class _ManterUsuario : UserControl
	{
		public _ManterUsuario()
		{
			InitializeComponent();
		}
		ProjetoCondominioEntities db = new ProjetoCondominioEntities();

		private void btnSalvar_Click(object sender, EventArgs e)
		{
			Condomino condomino = new Condomino();
			condomino.Pessoa = new Pessoa();

			if (txtIDUsuario.Text != string.Empty)
			{
				condomino.IDCondominio = int.Parse(txtIDUsuario.Text);
			}


			if (condomino.IDCondominio == 0)
			{
				db.Condomino.Add(condomino);
			}
			else
			{
				condomino = db.Condomino.Single(s => s.IDCondominio == condomino.IDCondominio);
			}

			condomino.Pessoa.Nome = txtNOme.Text;
			condomino.Pessoa.CPF = txtCpf.Text;
			condomino.RG = txtRG.Text;
			condomino.VagaGaragem = txtVagaGaragem.Text;
			condomino.Pessoa.Apartamento = txtApartamento.Text;
			condomino.Pessoa.Bloco = txtBloco.Text;

			int qtd;
			if (int.TryParse(txtQuantidadeChaves.Text, out qtd))
			{
				condomino.QTDChaves = qtd;
			}
			else
			{
				MessageBox.Show("Quantidade invalida", "Mensagem do sistema");
			}


			db.SaveChanges();
			MessageBox.Show("Condomino salvo com sucesso!", "Mensagem do sistema");
			limparManterUsuario();
		}

		public void limparManterUsuario()
		{
			txtApartamento.Text = string.Empty;
			txtBloco.Text = string.Empty;
			txtCpf.Text = string.Empty;
			txtIDUsuario.Text = string.Empty;
			txtNOme.Text = string.Empty;
			txtQuantidadeChaves.Text = string.Empty;
			txtRG.Text = string.Empty;
			txtVagaGaragem.Text = string.Empty;
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			lstPesquisa.Items.Clear();

			var condominos = db.Condomino.Where(x => x.Pessoa.Nome.Contains(txtBuscar.Text));
			foreach (Condomino a in condominos)
			{
				lstPesquisa.Items.Add(a);
			}
		}

		private void lstPesquisa_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void lstPesquisa_Click(object sender, EventArgs e)
		{
			var condominos = (Condomino)lstPesquisa.SelectedItem;
			if (condominos != null)
			{
				txtNOme.Text = condominos.Pessoa.Nome;
				txtCpf.Text = condominos.Pessoa.CPF;
				txtRG.Text = condominos.RG;
				txtVagaGaragem.Text = condominos.VagaGaragem;
				txtApartamento.Text = condominos.Pessoa.Apartamento;
				txtBloco.Text = condominos.Pessoa.Bloco;
				txtQuantidadeChaves.Text = condominos.QTDChaves.ToString();
				txtIDUsuario.Text = condominos.IDCondominio.ToString();
			}
		}

		private void btnTudo_Click(object sender, EventArgs e)
		{
			lstPesquisa.Items.Clear();

			var condominos = db.Condomino.Where(s => s.IDCondominio > 0);

			foreach (Condomino a in condominos)
			{
				lstPesquisa.Items.Add(a);
			}
		}

		private void btnExcluir_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Tem certeza que deseja excluir? ", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{

				Condomino c = new Condomino();

				if (txtIDUsuario.Text != string.Empty)
				{
					c.IDCondominio = int.Parse(txtIDUsuario.Text);

					db.Condomino.Remove(db.Condomino.Single(x => x.IDCondominio == c.IDCondominio));
					db.SaveChanges();
					limparManterUsuario();
					MessageBox.Show("CADASTRO DO CONDOMINO EXCLUIDO COM SUCESSO", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("Selecione um CONDOMINO", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

				}
			}
		}

		private void btnLimpar_Click(object sender, EventArgs e)
		{
			limparManterUsuario();
		}
	}
}
