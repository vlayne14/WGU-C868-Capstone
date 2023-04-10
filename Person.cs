using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBook
{
	public abstract class Person
	{
		public int active { get; set; }
		public DateTime dateCreated { get; set; }
		public string createdBy { get; set; }
		public DateTime lastUpdate { get; set; }
		public string lastUpdatedBy { get; set; }
	}
}
