using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SimpleBook.Database;

namespace SimpleBook
{
	public partial class Appointments_by_Patient : Form
	{
		public Appointments_by_Patient()
		{
			InitializeComponent();
		}

		private void Appointments_by_Customer_Load(object sender, EventArgs e)
		{

			MySqlConnection conn = ConnectToDB.newConnection();

			var sqlQuery = "SELECT appointment.title, customer.customerName, appointment.start, appointment.end FROM appointment JOIN customer ON appointment.customerId = customer.customerId GROUP BY customer.customerName, appointment.title;";
			MySqlDataAdapter da = new MySqlDataAdapter(sqlQuery, conn);
			DataTable dt = new DataTable();
			da.Fill(dt);
			//datagridview fill
			apptByCustDGV.DataSource = dt;
			apptByCustDGV.Refresh();

		}

		private void formatDGV()
		{
			var DGV = apptByCustDGV;
			DGV.AutoResizeColumns();
			DGV.RowHeadersVisible = false;
			DGV.ReadOnly = true;
		}



		private void apptByCustomerCloseButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void apptByCustDGV_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			formatDGV();
		}
	}
}
