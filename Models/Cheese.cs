namespace CheeseAPI.Models
{
	public class Cheese
	{
		public int CheeseId { get; set; }
		public string Name { get; set; } = null!;
		public string Description { get; set; } = null!;
		public bool Active { get; set; }
		public string? Origin { get; set; }
		public int Score { get; set; }
		public int Contributor { get; set; } // Use DB alias
	}
}
