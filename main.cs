using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace SimpleBook
{
	public partial class Main : Form
	{
		//current application user
		public static User currentUser;

		//binding lists for customers, appointments, and types
		public static BindingList<Patient> customerList = new BindingList<Patient>();
		public static BindingList<Appointment> apptList = new BindingList<Appointment>();
		public static BindingList<Types> typeList = new BindingList<Types>();
		//dictionaries for addresses, cities, and countries
		public static Dictionary<int, Address> dictionaryAddress = new Dictionary<int, Address>();
		public static Dictionary<int, City> dictionaryCity = new Dictionary<int, City>();
		public static Dictionary<int, Country> dictionaryCountry = new Dictionary<int, Country>();

		//update selection
		public void UpdateSelection()
		{
		}


		public Main(User user)
		{
			InitializeComponent();
			currentUser = user;
		}

		//main form load
		private void Main_Load(object sender, EventArgs e)
		{

			SQL_Data.getAddress();
			SQL_Data.getCities();
			SQL_Data.getCountries();
			SQL_Data.getCustomers();
			//appointments DGV
			mainApptDGV.AutoGenerateColumns = true;
			SQL_Data.getAppointment();
			mainApptDGV.DataSource = Main.apptList;
			loadComboType();


		}


		//appointment buttons
		//add appointment button clicked
		private void mainApptAddButton_Click(object sender, EventArgs e)
		{

			Add_Appointment form = new Add_Appointment(this);
			//type combo box
			form.typeComboBox.DataSource = new[] { "Routine Care", "Follow-Up", "Urgent" };
			form.typeComboBox.SelectedItem = null;

			//populating customer combobox
			form.comboBox();
			form.Show();

		}

		//modify appointment button
		private void mainApptModifyButton_Click(object sender, EventArgs e)
		{

			//getting appt id
			DataGridViewRow selectedRow = mainApptDGV.SelectedRows[0];
			var selectedApptId = Convert.ToInt32(selectedRow.Cells[0].Value);
			Modify_Appointment ma = new Modify_Appointment(this, selectedApptId);

			//customerID combo box
			ma.comboBox();

			//type combo box
			ma.typeComboBox.DataSource = new[] { "Routine Care", "Follow-Up", "Urgent" };
			ma.typeComboBox.SelectedItem = null;

			//populating form
			Appointment appointment = Main.apptList.Where(appt => appt.appointmentID == selectedApptId).FirstOrDefault();
			ma.customerIDComboBox.Text = appointment.customerID.ToString();
			ma.titleText.Text = appointment.title;
			ma.typeComboBox.Text = appointment.type;
			ma.startDatePicker.Value = appointment.startDate;
			ma.endDatePicker.Value = appointment.endDate;
			ma.addApptIDLabel.Text = appointment.appointmentID.ToString();

			ma.Show();

		}


		//delete appointment button clicked
		private void mainApptDeleteButton_Click(object sender, EventArgs e)
		{
			try
			{
				//if no appointment is selected
				if (mainApptDGV.SelectedRows.Count < 1)
				{
					throw new ApplicationException("Please select an appointment to delete.");
				}
				DialogResult deleteConfirm = MessageBox.Show("Are you sure you want to delete this appointment? This cannot be undone.",
					"Application Instruction", MessageBoxButtons.YesNo);
				//if delete confirmed
				if (deleteConfirm == DialogResult.Yes)
				{
					var selectedRow = mainApptDGV.SelectedRows[0];
					int selectedApptID = Convert.ToInt32(selectedRow.Cells[0].Value);
					Appointment selectedAppointment = Main.apptList.Where(appt => appt.appointmentID == selectedApptID).Single();
					SQL_Data.deleteAppt(selectedAppointment);
					UpdateSelection();
				}
				else
				{
					mainApptDGV.ClearSelection();
				}
			}
			catch (ApplicationException error)
			{
				MessageBox.Show(error.Message, "Instructions", MessageBoxButtons.OK);
			}
			catch (Exception err)
			{
				MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK);
			}
		}



		//log off button clicked
		private void mainLogOffButton_Click(object sender, EventArgs e)
		{
			this.Close();
			//new login form
			login login = new login();
			login.Show();
		}

		//view appointments button clicked
		private void viewApptButton_Click(object sender, EventArgs e)
		{
			View_Appointments form = new View_Appointments();
			form.Show();
		}

		//consultant schedule button clicked
		private void consultantScheButton_Click(object sender, EventArgs e)
		{
			Consultant_Schedule form = new Consultant_Schedule();
			form.Show();
		}

		//appointment types button clicked
		private void apptTypesButton_Click(object sender, EventArgs e)
		{
			Appointment_Types form = new Appointment_Types();
			form.Show();
		}

		//appointments by customer button clicked
		private void apptCustomerButton_Click(object sender, EventArgs e)
		{
			Appointments_by_Patient form = new Appointments_by_Patient();
			form.Show();
		}

		//customers button clicked
		private void customersButton_Click(object sender, EventArgs e)
		{
			var customerForm = new Patients(this);
			customerForm.Show();
		}

		//customer ID radio button
		private void customerIDRadio_CheckedChanged(object sender, EventArgs e)
		{
			//toggling label and text box visibility
			customerIDLabel.Visible = true;
			typeLabel.Visible = false;
			customerIDText.Visible = true;
			typeCombo.Visible = false;
			startLabel.Visible = false;
			endLabel.Visible = false;
			startDTP.Visible = false;
			endDTP.Visible = false;
		}

		//appointment type radio button
		private void typeRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			//toggling label and text box visibility
			customerIDLabel.Visible = false;
			typeLabel.Visible = true;
			customerIDText.Visible = false;
			typeCombo.Visible = true;
			startLabel.Visible = false;
			endLabel.Visible = false;
			startDTP.Visible = false;
			endDTP.Visible = false;
		}

		//date range radio button
		private void dateRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			//toggling label and text box visibility
			customerIDLabel.Visible = false;
			typeLabel.Visible = false;
			customerIDText.Visible = false;
			typeCombo.Visible = false;
			startLabel.Visible = true;
			endLabel.Visible = true;
			startDTP.Visible = true;
			endDTP.Visible = true;
		}

		//search button clicked
		private void searchButton_Click(object sender, EventArgs e)
		{
			if (customerIDRadio.Checked == true)
			{
				refreshDGVOnCustID();
			}
			if (typeRadioButton.Checked == true)
			{
				refreshDGVOnType();
			}
			if (dateRadioButton.Checked == true)
			{
				refreshDGVOnDateRange();
			}
		}

		//returning appointments by customer ID
		private BindingList<Appointment> getApptsByCustID(int ID)
		{
			return new BindingList<Appointment>(Main.apptList.Where(appt => appt.customerID == ID).ToList());
		}

		//updating DGV based on customer ID radio button selected
		private void refreshDGVOnCustID()
		{
			int customerID = 0;
			int.TryParse(customerIDText.Text, out customerID);
			if (customerID < 1)
			{
				MessageBox.Show("Please enter an ID greater than 0.");
			}
			BindingList<Appointment> appts = getApptsByCustID(customerID);
			if (appts.Count == 0)
			{
				MessageBox.Show("No appointments available for selected customer ID.");
			}
			mainApptDGV.DataSource = appts;
		}

		//returning appointments in specified date range
		private BindingList<Appointment> getApptsByDateRange(DateTime start, DateTime end)
		{
			return new BindingList<Appointment>(Main.apptList.Where(appt => appt.startDate >= start && appt.endDate <= end).ToList());
		}

		//updating DGV based on date range selected
		private void refreshDGVOnDateRange()
		{
			var start = startDTP.Value;
			var end = endDTP.Value.AddMilliseconds(1);

			if (start > end)
			{
				MessageBox.Show($"The start date: {start} is later than the end date: {end} .");
				return;
			}
			BindingList<Appointment> appts = getApptsByDateRange(start, end);
			if (appts.Count == 0)
			{
				MessageBox.Show("No appointments found for date range selected.");
				return;
			}
			mainApptDGV.DataSource = appts;
		}

		//getting appointments by type
		private BindingList<Appointment> getApptsByType(string apptType)
		{
			return new BindingList<Appointment>(Main.apptList.Where(appt => appt.type == apptType).ToList());
		}

		private void refreshDGVOnType()
		{
			BindingList<Appointment> appts = getApptsByType(typeCombo.Text);
			if (appts.Count == 0)
			{
				MessageBox.Show("No appointments found for selected type.");
				return;
			}
			mainApptDGV.DataSource = appts;
		}

		//populating type comobo box
		private void loadComboType()
		{
			typeCombo.DataSource = new[] { "Routine Care", "Follow-Up", "Urgent" };
			typeCombo.SelectedItem = null;
		}

		
	}
}
