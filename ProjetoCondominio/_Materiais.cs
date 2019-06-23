using System;
using System.Linq;
using System.Windows.Forms;

namespace ProjetoCondominio
{
	public partial class _Materiais : UserControl
	{

		ProjetoCondominioEntities db = new ProjetoCondominioEntities();

		public _Materiais()
		{
			InitializeComponent();
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			lstPesquisa.Items.Clear();

			var materiais = db.Material.Where(x => x.NMMaterial.Contains(txtBuscar.Text));
			foreach (Material a in materiais)
			{
				lstPesquisa.Items.Add(a);
			}
		}

		private void btnTudo_Click(object sender, EventArgs e)
		{
			lstPesquisa.Items.Clear();

			var materiais = db.Material.Where(s => s.IDMaterial > 0);

			foreach (Material a in materiais)
			{
				lstPesquisa.Items.Add(a);
			}

		}

		private void btnLimpar_Click(object sender, EventArgs e)
		{
			LimparMateriais();
		}

		private void btnSalvar_Click(object sender, EventArgs e)
		{

			Material material = new Material();

			if (txtIDMateial.Text != string.Empty)
			{
				material.IDMaterial = int.Parse(txtIDMateial.Text);
			}


			if (material.IDMaterial == 0)
			{
				db.Material.Add(material);
			}
			else
			{
				material = db.Material.Single(s => s.IDMaterial == material.IDMaterial);
			}

			bool converteu = double.TryParse(txtValorUnitario.Text, out var temp);
			if (converteu)
			{
				material.ValorUnitario = temp;
			}
			else
			{
				material.ValorUnitario = null;
			}

			material.NMMaterial = txtNMMaterial.Text;


			db.SaveChanges();
			MessageBox.Show("Material salva com sucesso!", "Mensagem do sistema");
			LimparMateriais();

		}

		private void btnExcluir_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Tem certeza que deseja excluir? ", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{

				Material v = new Material();

				if (txtIDMateial.Text != string.Empty)
				{
					v.IDMaterial = int.Parse(txtIDMateial.Text);

					var temMaterial = db.MaterialManuntecaoCusto.Where(x => x.IDMaterial == v.IDMaterial).ToList();

					if (temMaterial.Count > 0)
					{
						MessageBox.Show("Este material está sendo usado em relatório de custos", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

					}
					else
					{
						db.Material.Remove(db.Material.Single(x => x.IDMaterial == v.IDMaterial));
						db.SaveChanges();
						LimparMateriais();
						MessageBox.Show("CADASTRO DO MATERIAL EXCLUIDO COM SUCESSO", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

					}
				}
				else
				{
					MessageBox.Show("Selecione um MATERIAL", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

				}
			}
		}

		private void lstPesquisa_Click(object sender, EventArgs e)
		{
			var materia = (Material)lstPesquisa.SelectedItem;
			if (materia != null)
			{
				txtValorUnitario.Text = materia.ValorUnitario.ToString();
				txtIDMateial.Text = materia.IDMaterial.ToString();
				txtNMMaterial.Text = materia.NMMaterial;
			}
		}

		public void LimparMateriais()
		{
			txtValorUnitario.Text = string.Empty;
			txtIDMateial.Text = string.Empty;
			txtNMMaterial.Text = string.Empty;
		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}
	}

}


