using System;
using System.Windows.Forms;
using SimpleBook.Database;

namespace SimpleBook
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			ConnectToDB.startConnection();
			Application.Run(new login());
			ConnectToDB.closeConnection();
		}
	}
}
