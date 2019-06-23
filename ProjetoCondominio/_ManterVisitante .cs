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
	public partial class _ManterVisitante : UserControl
	{
		ProjetoCondominioEntities db = new ProjetoCondominioEntities();

		public _ManterVisitante()
		{
			InitializeComponent();
		}

		private void btnSalvar_Click(object sender, EventArgs e)
		{

			Visitante visisitante = new Visitante();
			visisitante.Pessoa = new Pessoa();

			if (txtIDVisitante.Text != string.Empty)
			{
				visisitante.IDVisitante = int.Parse(txtIDVisitante.Text);
			}


			if (visisitante.IDVisitante == 0)
			{
				db.Visitante.Add(visisitante);
			}
			else
			{
				visisitante = db.Visitante.Single(s => s.IDVisitante == visisitante.IDVisitante);
			}


			visisitante.Pessoa.Apartamento = txtApartamento.Text;
			visisitante.Pessoa.Bloco = txtBloco.Text;
			visisitante.Pessoa.CPF = txtCpf.Text;
			visisitante.Pessoa.Nome = txtNome.Text;
			visisitante.DTVisitante = DateTimeOffset.Now;


			db.SaveChanges();
			MessageBox.Show("Visitante salvo com sucesso!", "Mensagem do sistema");
			limparManterVisitante();
		}

		private void limparManterVisitante()
		{
			txtApartamento.Text = string.Empty;
			txtBloco.Text = string.Empty;
			txtNome.Text = string.Empty;
			txtCpf.Text = string.Empty;
			txtIDVisitante.Text = string.Empty;
		}

		private void btnTudo_Click(object sender, EventArgs e)
		{
			lstPesquisa.Items.Clear();

			var visistantes = db.Visitante.Where(s => s.IDVisitante > 0);

			foreach (Visitante a in visistantes)
			{
				lstPesquisa.Items.Add(a);
			}
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			lstPesquisa.Items.Clear();

			var visitantes = db.Visitante.Where(x => x.Pessoa.Nome.Contains(txtBuscar.Text));
			foreach (Visitante a in visitantes)
			{
				lstPesquisa.Items.Add(a);
			}
		}

		private void lstPesquisa_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void lstPesquisa_Click(object sender, EventArgs e)
		{
			var visitantes = (Visitante)lstPesquisa.SelectedItem;
			if (visitantes != null)
			{
				txtCpf.Text = visitantes.Pessoa.CPF;
				txtNome.Text = visitantes.Pessoa.Nome;
				txtBloco.Text = visitantes.Pessoa.Bloco;
				txtApartamento.Text = visitantes.Pessoa.Apartamento;
				txtIDVisitante.Text = visitantes.IDVisitante.ToString();
			}
		}

		private void btnExcluir_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Tem certeza que deseja excluir? ", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{

				Visitante v = new Visitante();

				if (txtIDVisitante.Text != string.Empty)
				{
					v.IDVisitante = int.Parse(txtIDVisitante.Text);

					db.Visitante.Remove(db.Visitante.Single(x => x.IDVisitante == v.IDVisitante));
					db.SaveChanges();
					limparManterVisitante();
					MessageBox.Show("CADASTRO DO VISITANTE EXCLUIDO COM SUCESSO", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("Selecione um visitante", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

				}
			}
		}

		private void btnLimpar_Click(object sender, EventArgs e)
		{
			limparManterVisitante();
		}
	}
}
