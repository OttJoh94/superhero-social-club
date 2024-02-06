namespace SuperheroSocialClub.Models
{
    public class SuperheroModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? SecretIdentity { get; set; }
        public string? Superpower { get; set; }
        public string? Image { get; set; }

        public SuperheroModel()
        {
            Image = RandomImage();
        }

        private string RandomImage()
        {
            return $"superhero{new Random().Next(1, 21)}.jpg";
        }
    }


}
