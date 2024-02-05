namespace SuperheroSocialClub.Models
{
	public class Superhero
	{
		public int Id { get; set; }
		public string Name { get; set; } = null!;
		public string? SecretIdentity { get; set; }
		public string? Superpower { get; set; }
		public string? Image { get; set; }
	}
}
