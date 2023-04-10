using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SimpleBook.Database;

namespace SimpleBook
{
	public partial class Modify_Appointment : Form
	{
		private Main LastForm;
		private int selectedApptID = -1;
		public Modify_Appointment(Main lastForm, int appointmentID)
		{
			InitializeComponent();
			LastForm = lastForm;
			selectedApptID = appointmentID;
		}

		public void comboBox()
		{
			string sqlQuery = "SELECT DISTINCT customerId from customer";
			var conn = ConnectToDB.newConnection();
			MySqlDataAdapter da = new MySqlDataAdapter(sqlQuery, conn);
			DataSet dt = new DataSet();
			da.Fill(dt, "customerId");
			customerIDComboBox.DisplayMember = "customerId";
			customerIDComboBox.ValueMember = "customerId";
			customerIDComboBox.DataSource = dt.Tables["customerId"];
			if (customerIDComboBox.Items.Count > 1)
			{
				customerIDComboBox.SelectedIndex = -1;
			}
		}

		private void modifyApptSaveButton_Click(object sender, EventArgs e)
		{
			try
			{
				DateTime now = DateTime.Now;
				//business hours
				TimeSpan businessOpen = new DateTime(now.Year, now.Month, now.Day, 9, 0, 0).TimeOfDay;
				TimeSpan businessClose = new DateTime(now.Year, now.Month, now.Day, 18, 0, 0).TimeOfDay;
				int selectedCustomerID = Int32.Parse(((DataRowView)customerIDComboBox.SelectedItem).Row["customerId"].ToString());
				string title = titleText.Text.ToString();
				string typeSelected = typeComboBox.SelectedItem.ToString();
				DateTime selectedStartDate = startDatePicker.Value;
				DateTime selectedEndDate = endDatePicker.Value;
				bool overlap = false;

				//overlapping appointment
				foreach (var appt in Main.apptList)
				{
					if (appt.startDate <= selectedStartDate && appt.endDate > selectedStartDate && (!(selectedApptID >= 0)) || selectedApptID >= 0)
					{
						overlap = true;
					}
					if (selectedStartDate <= appt.startDate && selectedEndDate > appt.startDate && (!(selectedApptID >= 0)) || selectedApptID >= 0)
					{
						overlap = true;
					}
				}


				//customer must be selected
				if (selectedCustomerID < 1)
				{
					throw new ApplicationException("Please select a customer.");
				}

				//title must be added
				if (titleText.Text == "")
				{
					throw new ApplicationException("Appointments must have a title.");
				}

				//selecting an end date that is before the start date
				if (selectedStartDate > selectedEndDate)
				{
					throw new ApplicationException("The start time must be before the end time.");
				}

				//selecting a time outside of business hours
				if ((selectedStartDate.TimeOfDay < businessOpen) || (selectedStartDate.TimeOfDay > businessClose) ||
					(selectedEndDate.TimeOfDay < businessOpen) || (selectedEndDate.TimeOfDay > businessClose))
				{
					throw new ApplicationException("Appointments cannot be scheduled outside of the business hours of 9am - 6pm");
				}

				Appointment appointment = Main.apptList.Where(appt => appt.appointmentID == selectedApptID).Single();
				SQL_Data.modifyAppt(appointment, selectedCustomerID, title, typeSelected, selectedStartDate, selectedEndDate);

				this.Close();
			}
			//if appointment type is not selected
			catch (NullReferenceException)
			{
				MessageBox.Show("Please select an appointment type.", "Instructions", MessageBoxButtons.OK);
			}
			catch (ApplicationException err)
			{
				MessageBox.Show(err.Message, "Instructions", MessageBoxButtons.OK);
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK);
			}
		}

		private void modifyApptCloseButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Modify_Appointment_FormClosed(object sender, FormClosedEventArgs e)
		{
			LastForm.UpdateSelection();
			LastForm.Show();
		}

		private void startDatePicker_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = true;
		}

		private void endDatePicker_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = true;
		}
	}
}

