using System;

namespace SimpleBook
{
	class LoginFormExceptions : ApplicationException
	{
		public LoginFormExceptions() : base("Incorrect input")
		{
		}

		public LoginFormExceptions(string exemption) : base(exemption)
		{
		}

		public LoginFormExceptions(string exemption, ApplicationException inner) : base(exemption, inner)
		{
		}
	}
}
