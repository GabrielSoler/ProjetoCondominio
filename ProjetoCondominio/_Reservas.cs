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
	public partial class _Reservas : UserControl
	{
		ProjetoCondominioEntities db = new ProjetoCondominioEntities();

		public _Reservas()
		{
			InitializeComponent();
		}

		public void limparReserva()
		{
			txtApartamento.Text = string.Empty;
			txtBloco.Text = string.Empty;
			txtCpf.Text = string.Empty;
			txtNome.Text = string.Empty;
			txtIDReserva.Text = string.Empty;
			dtLocal.Text = string.Empty;
		}


		private void btnSalvar_Click(object sender, EventArgs e)
		{
			Reserva reserva = new Reserva();

			if (txtIDReserva.Text != string.Empty)
			{
				reserva.IDReserva = int.Parse(txtIDReserva.Text);
			}


			if (reserva.IDReserva == 0)
			{
				db.Reserva.Add(reserva);
			}
			else
			{
				reserva = db.Reserva.Single(s => s.IDReserva == reserva.IDReserva);
			}

			List<Condomino> p = db.Condomino.Where(x => x.Pessoa.CPF == txtCpf.Text).ToList();

			if(p.Count > 1)
			{
				p = p.Where(x => x.Pessoa.Nome == txtNome.Text).ToList();
			}

			try
			{
				reserva.DTReservada = DateTimeOffset.Parse(dtLocal.Text);
				reserva.DSLocal = lstLocais.SelectedItem as string;

				var dataReservada = db.Reserva.Where(x => x.DTReservada == reserva.DTReservada && x.DSLocal == reserva.DSLocal).SingleOrDefault();

				if (dataReservada == null)
				{
				
					reserva.IDCondomino = p.Select(x => x.IDCondominio).First();
					db.SaveChanges();
					MessageBox.Show("Reserva salva com sucesso!", "Mensagem do sistema");
					limparReserva();
				}
				else
				{
					MessageBox.Show("Essa data já esta reservada por outro usuario!", "Mensagem do sistema");

				}

			}
			catch (Exception)
			{
				MessageBox.Show("Data de reserva invalida!", "Mensagem do sistema");
				dtLocal.Focus();
			}

		}

		private void btnTudo_Click(object sender, EventArgs e)
		{
			lstPesquisa.Items.Clear();

			var reservas = db.Reserva.Where(s => s.IDReserva > 0);

			foreach (Reserva a in reservas)
			{
				lstPesquisa.Items.Add(a);
			}
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			lstPesquisa.Items.Clear();

			var reserva = db.Reserva.Where(x => x.Condomino.Pessoa.Nome.Contains(txtBuscar.Text));
			foreach (Reserva a in reserva)
			{
				lstPesquisa.Items.Add(a);
			}
		}

		private void lstPesquisa_Click(object sender, EventArgs e)
		{
			var reserva = (Reserva)lstPesquisa.SelectedItem;
			if (reserva != null)
			{
				txtApartamento.Text = reserva.Condomino.Pessoa.Apartamento;
				txtBloco.Text = reserva.Condomino.Pessoa.Bloco;
				txtCpf.Text = reserva.Condomino.Pessoa.CPF;
				txtNome.Text = reserva.Condomino.Pessoa.Nome;
				txtIDReserva.Text = reserva.IDReserva.ToString();
				dtLocal.Text = reserva.DTReservada.ToString();
				lstLocais.SelectedItem = reserva.DSLocal;
			}
		}

		private void btnLimpar_Click(object sender, EventArgs e)
		{
			limparReserva();
		}
	}
}
