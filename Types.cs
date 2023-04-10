namespace SimpleBook
{
	public class Types
	{
		public string Type { get; set; }
		public int Count { get; set; }

		public Types(string type, int count)
		{
			Type = type;
			Count = count;
		}
	}
}
