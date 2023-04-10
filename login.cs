using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SimpleBook.Database;

namespace SimpleBook
{
	public partial class login : Form
	{
		private List<User> users;
		private string culture;
		public login()
		{
			InitializeComponent();
		}

		//changing labels to french
		private void loginToFrench()
		{
			loginLabel.Text = "Connexion";
			userNameLabel.Text = "Nom d’utilisateur";
			passwordLabel.Text = "Mot de passe";
			loginStartButton.Text = "Début";
			loginCloseButton.Text = "Fermer";
		}

		//changing language to french upon login load
		private void login_Load_1(object sender, EventArgs e)
		{
			culture = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
			//getting users from database
			users = SQL_Data.getUsers();
			//error label should be blank at start
			loginErrorLabel.Text = "";
			if (culture == "fr")
			{
				loginToFrench();
			}
		}

		//appointment in 15 minutes
		private bool upcomingAppt()
		{
			string userName = loginUserNameText.Text;
			bool result = false;
			try
			{
				var conn = ConnectToDB.newConnection();
				//sql query finding appointments in next 15 min
				string sqlQuery = $"SELECT * FROM appointment WHERE start BETWEEN NOW() AND NOW() + INTERVAL 15 MINUTE AND " +
					$"userId=(SELECT userId FROM user WHERE userNAme='{userName}')";

				var upcomingApptCMD = new MySqlCommand(sqlQuery, conn);
				int upcomingApptIndex = Convert.ToInt32(upcomingApptCMD.ExecuteScalar());

				if (upcomingApptIndex == 0)
				{
					result = false;
				}
				else
				{
					result = true;
				}
			}
			catch (MySqlException)
			{
				MessageBox.Show("Error");
			}
			return result;

		}
		private void loginStartButton_Click(object sender, EventArgs e)
		{

			try
			{
				string path = @"user_tracking.txt";
				var conn = ConnectToDB.newConnection();
				string userName = loginUserNameText.Text;
				string password = loginPasswordText.Text;
				//lambda expression determining if entered username matches the database
				List<User> currentUser = users.Where(user => user.userName == userName).ToList();
				//sql query gathering usernames and passwords from database
				string sqlQuery = $"SELECT * FROM user WHERE userName='{userName}' AND password='{password}'";
				var cmd = new MySqlCommand(sqlQuery, conn);
				var dataReader = cmd.ExecuteReader();
				if (dataReader.HasRows)
				{
					var main = new Main(currentUser[0]);
					//checking for appointments within 15 minutes
					if (upcomingAppt() != true)
					{
						MessageBox.Show("Login Successful");
						main.Show();
						this.Hide();

						//successful login to file
						try
						{
							if (File.Exists(path) == false)
							{
								File.Create(path).Dispose();
								using (TextWriter writer = new StreamWriter(path))
								{
									writer.WriteLine($"Successful login for user {userName} at {DateTime.Now} {Environment.NewLine}");
								}
							}
							else if (File.Exists(path) == true)
							{
								File.AppendAllText(path, $"Successful login for user {userName} at {DateTime.Now} {Environment.NewLine}");
							}
						}
						catch (IOException err)
						{
							MessageBox.Show(err.ToString());
						}
					}
					else
					{
						MessageBox.Show("There is an upcoming appointment within the next 15 minutes.");
						main.Show();
						this.Hide();
					}
				}
				else
				{
					if (CultureInfo.CurrentCulture.TwoLetterISOLanguageName == "en")
					{
						MessageBox.Show("Username or Password is incorrect.");
					}
					else if (CultureInfo.CurrentCulture.TwoLetterISOLanguageName == "fr")
					{
						//username or password is incorrect
						MessageBox.Show("Le nom d’utilisateur ou le mot de passe est incorrectLe nom d’utilisateur ou le mot de passe est incorrect.");
					}

					//writing unsuccessful logins to file
					try
					{
						if (File.Exists(path) == false)
						{
							File.Create(path).Dispose();
							using (TextWriter writer = new StreamWriter(path))
							{
								writer.WriteLine($"Unsuccessful login attempt for user {userName} at {DateTime.Now} {Environment.NewLine}");
							}
						}
						else if (File.Exists(path) == true)
						{
							File.AppendAllText(path, $"Unsuccessful login attempt for user {userName} at {DateTime.Now} {Environment.NewLine}");
						}
					}
					catch (LoginFormExceptions error)
					{
						loginErrorLabel.Text = error.Message;
					}
				}
			}
			catch (MySqlException)
			{
				MessageBox.Show("Cannot connect to server.");
			}
		}





		//close button clicked
		private void loginCloseButton_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		
	}
}
