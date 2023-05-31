namespace CheeseAPI.Models
{
	public class Contributor
	{
		public int ContributorId { get; set; }
		public string FirstName { get; set; } = null!;
		public string? LastName { get; set; }
		public string Username { get; set; } = null!;
		public string? Github { get; set; }
		public string? Discord { get; set; }
		public string Email { get; set; } = null!;
		public bool Active { get; set; }
	}
}
