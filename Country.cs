using System;

namespace SimpleBook
{
	public class Country
	{
		public int countryID { get; set; }
		public string countryName { get; set; }
		public DateTime dateCreated { get; set; }
		public string createdBy { get; set; }
		public DateTime lastUpdate { get; set; }
		public string lastUpdatedBy { get; set; }


		//create country object
		public Country(int countryID, string countryName, DateTime dateCreated, string createdBy, DateTime lastUpdate, string lastUpdatedBy)
		{
			this.countryID = countryID;
			this.countryName = countryName;
			this.dateCreated = dateCreated;
			this.createdBy = createdBy;
			this.lastUpdate = lastUpdate;
			this.lastUpdatedBy = lastUpdatedBy;
		}

	}
}
