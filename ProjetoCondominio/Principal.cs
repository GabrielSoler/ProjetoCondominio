using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCondominio
{
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();
			SidePanel.Height = btnHome.Height;
			homeControl1.BringToFront();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}


		private void BtnFechar_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnHome_Click(object sender, EventArgs e)
		{
			SidePanel.Height = btnHome.Height;
			SidePanel.Top = btnHome.Top;
			homeControl1.BringToFront();
		}

		private void btnRelCusto_Click(object sender, EventArgs e)
		{
			SidePanel.Height = btnRelCusto.Height;
			SidePanel.Top = btnRelCusto.Top;
			_RelatoriosDeCustos1.BringToFront();
		}



		private void btnRegistrarManutecao_Click(object sender, EventArgs e)
		{
			SidePanel.Height = btnRegistrarManutecao.Height;
			SidePanel.Top = btnRegistrarManutecao.Top;
			_ManterManutencoes1.BringToFront();
		}


		private void btnReservas_Click(object sender, EventArgs e)
		{
			SidePanel.Height = btnReservas.Height;
			SidePanel.Top = btnReservas.Top;
			_Reservas1.BringToFront();
		}

		private void btnCadastro_Click(object sender, EventArgs e)
		{
			SidePanel.Height = btnCadastro.Height;
			SidePanel.Top = btnCadastro.Top;
			_ManterUsuario1.BringToFront();
		}

		private void btnMateriais_Click(object sender, EventArgs e)
		{
			SidePanel.Height = btnMateriais.Height;
			SidePanel.Top = btnMateriais.Top;
			_Materiais1.BringToFront();
		}

		private void btn_ManterVisitante_Click(object sender, EventArgs e)
		{
			SidePanel.Height = btn_ManterVisitante.Height;
			SidePanel.Top = btn_ManterVisitante.Top;
			_Materiais1.BringToFront();
		}

		private void panel4_Paint(object sender, PaintEventArgs e)
		{
			
		}
	}
}
