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
	public partial class _ManterManutencoes : UserControl
	{
		ProjetoCondominioEntities db = new ProjetoCondominioEntities();

		public _ManterManutencoes()
		{
			InitializeComponent();
		}

		private void btnSalvar_Click(object sender, EventArgs e)
		{
			Manutencao manutencao = new Manutencao();

			if (txtIDManutencao.Text != string.Empty)
			{
				manutencao.IDManutencao = int.Parse(txtIDManutencao.Text);
			}


			if (manutencao.IDManutencao == 0)
			{
				db.Manutencao.Add(manutencao);
			}
			else
			{
				manutencao = db.Manutencao.Single(s => s.IDManutencao == manutencao.IDManutencao);
			}



			bool converteu = double.TryParse(txtOrcamentoPrevisto.Text, out var temp);
			if (converteu)
			{
				manutencao.OrcamentoPrevisto = temp;
			}
			else
			{
				manutencao.OrcamentoPrevisto = null;
			}

			try
			{
				manutencao.DTConclusao = DateTimeOffset.Parse(txtDtConclusao.Text);

				manutencao.DSLocal = txtLocal.Text;
				manutencao.DSProblema = txtDSProblema.Text;
				if (rbtSim.Checked)
				{
					manutencao.CDConcluido = true;
				}
				else
				{
					manutencao.CDConcluido = false;
				}
				db.SaveChanges();
				MessageBox.Show("Manutenção salva com sucesso!", "Mensagem do sistema");
				LimparManterManutecao();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Data inválida", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

			}


		}

		private void btnExcluir_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Tem certeza que deseja excluir? ", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{

				Manutencao v = new Manutencao();

				if (txtIDManutencao.Text != string.Empty)
				{
					v.IDManutencao = int.Parse(txtIDManutencao.Text);

					var temManuntencao = db.MaterialManuntecaoCusto.Where(x => x.IDManutencao == v.IDManutencao).ToList();

					if (temManuntencao.Count > 0)
					{
						MessageBox.Show("Este manutenção está sendo usado em relatório de custos", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else
					{
						db.Manutencao.Remove(db.Manutencao.Single(x => x.IDManutencao == v.IDManutencao));
						db.SaveChanges();
						LimparManterManutecao();
						MessageBox.Show("CADASTRO DA MANUTENÇÃO EXCLUIDO COM SUCESSO", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}

				}
				else
				{
					MessageBox.Show("Selecione uma manutenção", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

				}
			}
		}

		private void btnTudo_Click(object sender, EventArgs e)
		{
			lstPesquisa.Items.Clear();

			var manutencao = db.Manutencao.Where(s => s.IDManutencao > 0);

			foreach (Manutencao a in manutencao)
			{
				lstPesquisa.Items.Add(a);
			}
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			lstPesquisa.Items.Clear();

			var manutencao = db.Manutencao.Where(x => x.DSLocal.Contains(txtLocal.Text));
			foreach (Manutencao a in manutencao)
			{
				lstPesquisa.Items.Add(a);
			}
		}

		private void lstPesquisa_Click(object sender, EventArgs e)
		{
			var manutencao = (Manutencao)lstPesquisa.SelectedItem;
			LimparManterManutecao();
			if (manutencao != null)
			{

				txtOrcamentoPrevisto.Text = manutencao.OrcamentoPrevisto.ToString();
				txtDtConclusao.Text = manutencao.DTConclusao.Date.ToString().Replace("00:00:00","");
				txtLocal.Text = manutencao.DSLocal;
				txtDSProblema.Text = manutencao.DSProblema;
				txtIDManutencao.Text = manutencao.IDManutencao.ToString();

				if (manutencao.CDConcluido != null)
				{
					bool temp = manutencao.CDConcluido.GetValueOrDefault();
					if (temp)
					{
						rbtSim.Checked = true;
					}
					else
					{
						rbtNao.Checked = true;
					}
				}				
			}
		}

		private void btnLimpar_Click(object sender, EventArgs e)
		{
			LimparManterManutecao();

		}

		public void LimparManterManutecao()
		{
			txtOrcamentoPrevisto.Text = string.Empty;
			txtDtConclusao.Text = string.Empty;
			txtLocal.Text = string.Empty;
			txtDSProblema.Text = string.Empty;
			txtIDManutencao.Text = string.Empty;
			rbtSim.Checked = false;
			rbtNao.Checked = false;
		}
	}
}
