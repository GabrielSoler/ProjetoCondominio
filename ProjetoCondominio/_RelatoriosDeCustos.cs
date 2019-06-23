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
	public partial class _RelatoriosDeCustos : UserControl
	{
		ProjetoCondominioEntities db = new ProjetoCondominioEntities();

		BindingList<GridViewModel> ds = new BindingList<GridViewModel>();

		Manutencao selecionadaManute = new Manutencao();

		public _RelatoriosDeCustos()
		{
			InitializeComponent();
			txtValorGasto.Text = "0";
			txtQuantidade.Text = "0";
		}

		private void _RelatoriosDeCustos_Load(object sender, EventArgs e)
		{



		}


		private void btnBuscaManutencao_Click(object sender, EventArgs e)
		{
			lstManutencao.Items.Clear();

			var manutencao = db.Manutencao.Where(x => x.DSLocal.Contains(txtBuscaManutencao.Text));
			foreach (Manutencao a in manutencao)
			{
				lstManutencao.Items.Add(a);
			}
		}

		private void btnTodosMaterias_Click(object sender, EventArgs e)
		{
			lstMaterial.Items.Clear();

			var materiais = db.Material.Where(s => s.IDMaterial > 0);

			foreach (Material a in materiais)
			{
				lstMaterial.Items.Add(a);
			}
		}

		private void btnBuscaMaterial_Click(object sender, EventArgs e)
		{
			lstMaterial.Items.Clear();

			var materiais = db.Material.Where(x => x.NMMaterial.Contains(txtBuscaMaterial.Text));
			foreach (Material a in materiais)
			{
				lstMaterial.Items.Add(a);
			}
		}

		private void btnAdicionar_Click(object sender, EventArgs e)
		{
			Material material = lstMaterial.SelectedItem as Material;
			if (material != null)
			{
				int qtd = int.Parse(txtQuantidade.Text.Replace("_", "").Replace(" ", ""));

				double total = (qtd * material.ValorUnitario.GetValueOrDefault());
				double valorUNI = material.ValorUnitario.GetValueOrDefault();

				GridViewModel model = new GridViewModel(material.IDMaterial, material.NMMaterial, qtd, valorUNI, total);
				dataGridView.DataSource = ds;

				ds.Add(new GridViewModel(material.IDMaterial, material.NMMaterial, qtd, valorUNI, total));

				dataGridView.Columns[0].Visible = false;
				dataGridView.Columns[1].HeaderText = "Material";
				dataGridView.Columns[1].ReadOnly = true;
				dataGridView.Columns[2].HeaderText = "Quantidade";
				dataGridView.Columns[2].ReadOnly = true;
				dataGridView.Columns[3].HeaderText = "Valor unitario";
				dataGridView.Columns[3].ReadOnly = true;
				dataGridView.Columns[4].HeaderText = "Total";
				dataGridView.Columns[4].ReadOnly = true;

				txtValorGasto.Text = ((double.Parse(txtValorGasto.Text)) + total).ToString();

			}
			else
			{
				MessageBox.Show("SELECIONE UM MATERIAL", "Mensagem do sistema");

			}

		}

		public class GridViewModel
		{
			public int IDMaterial { get; set; }
			public string NMMaterial { get; set; }
			public int Quantidade { get; set; }
			public double ValorUnitario { get; set; }
			public double Total { get; set; }

			public GridViewModel(int IDMaterial, string NMMaterial, int Quantidade, double ValorUnitario, double Total)
			{
				this.NMMaterial = NMMaterial;
				this.Quantidade = Quantidade;
				this.ValorUnitario = ValorUnitario;
				this.Total = Total;
				this.IDMaterial = IDMaterial;
			}
		}

		private void lstManutencao_Click(object sender, EventArgs e)
		{
			if (lstManutencao.SelectedItem != null)
			{
				dataGridView.Rows.Clear();
				txtValorGasto.Text = "0";


				var a = (Manutencao)lstManutencao.SelectedItem;
				lstManutencao.Items.Clear();
				lstManutencao.Items.Add(a);
				selecionadaManute = a;

				var lstGrid = db.MaterialManuntecaoCusto.Where(x => x.IDManutencao == selecionadaManute.IDManutencao).ToList();
				if (lstGrid.Count > 0)
				{
					foreach (MaterialManuntecaoCusto s in lstGrid)
					{
						Material material = db.Material.Where(x => x.IDMaterial == s.IDMaterial).SingleOrDefault();

						double val = material.ValorUnitario.GetValueOrDefault();
						double total = s.Quantidade * material.ValorUnitario.GetValueOrDefault();
						ds.Add(new GridViewModel(material.IDMaterial, material.NMMaterial, s.Quantidade, val, total));
						dataGridView.DataSource = ds;
						txtValorGasto.Text = db.Custos.Where(x => x.IDCusto == s.IDCusto).Select(k => k.ValorGasto).SingleOrDefault().ToString();
					}

					dataGridView.Columns[0].Visible = false;
					dataGridView.Columns[1].HeaderText = "Material";
					dataGridView.Columns[1].ReadOnly = true;
					dataGridView.Columns[2].HeaderText = "Quantidade";
					dataGridView.Columns[2].ReadOnly = true;
					dataGridView.Columns[3].HeaderText = "Valor unitario";
					dataGridView.Columns[3].ReadOnly = true;
					dataGridView.Columns[4].HeaderText = "Total";
					dataGridView.Columns[4].ReadOnly = true;
				}
			}

		}

		private void btnSalvar_Click(object sender, EventArgs e)
		{
			Custos custo = new Custos();

			if (txtIDCusto.Text != string.Empty)
			{
				custo.IDCusto = int.Parse(txtIDCusto.Text);
			}

			if (custo.IDCusto == 0)
			{
				db.Custos.Add(custo);
			}
			else
			{
				custo = db.Custos.Single(s => s.IDCusto == custo.IDCusto);
			}

			custo.ValorGasto = double.Parse(txtValorGasto.Text);

			db.SaveChanges();

			BindingList<GridViewModel> objBindingList = (BindingList<GridViewModel>)dataGridView.DataSource;
			List<GridViewModel> lstGridViewModel = objBindingList.ToList();

			var existe = db.MaterialManuntecaoCusto.Where(x => x.IDManutencao == selecionadaManute.IDManutencao).ToList();
			if (existe.Count == 0)
			{
				foreach (GridViewModel a in lstGridViewModel)
				{
					MaterialManuntecaoCusto mmc = new MaterialManuntecaoCusto();
					db.MaterialManuntecaoCusto.Add(mmc);
					mmc.IDManutencao = selecionadaManute.IDManutencao;
					mmc.IDMaterial = a.IDMaterial;
					mmc.Quantidade = a.Quantidade;
					mmc.IDCusto = custo.IDCusto;
					db.SaveChanges();
				}
				MessageBox.Show("Relatório de custos salvo com sucesso!", "Mensagem do sistema");
			}
			else
			{
				foreach (MaterialManuntecaoCusto m in existe)
				{
					db.MaterialManuntecaoCusto.Remove(m);
				}


				foreach (GridViewModel a in lstGridViewModel)
				{
					MaterialManuntecaoCusto mmc = new MaterialManuntecaoCusto();
					db.MaterialManuntecaoCusto.Add(mmc);
					mmc.IDManutencao = selecionadaManute.IDManutencao;
					mmc.IDMaterial = a.IDMaterial;
					mmc.Quantidade = a.Quantidade;
					mmc.IDCusto = custo.IDCusto;
					db.SaveChanges();
				}
				MessageBox.Show("Relatório de custos salvo com sucesso!", "Mensagem do sistema");

				//var novos = lstGridViewModel.Distinct(existe);
			}




		}

		private void btnExcluir_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Tem certeza que deseja excluir? ", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
				var existe = db.MaterialManuntecaoCusto.Where(x => x.IDManutencao == selecionadaManute.IDManutencao).ToList();

				if (existe.Count > 0)
				{
					foreach (MaterialManuntecaoCusto m in existe)
					{
						db.MaterialManuntecaoCusto.Remove(m);
					}

					dataGridView.Rows.Clear();
					txtValorGasto.Text = "0";
					db.SaveChanges();
					MessageBox.Show("Exclusão realizada com sucesso!", "Mensagem do sistema");

				}
				else
				{
					MessageBox.Show("Selecione uma manutenção!", "Mensagem do sistema");

				}

			}
		}
	}
}
