using SuperheroSocialClub.Models;

namespace SuperheroSocialClub.Database
{
    public class SuperheroRepo
    {
        public static List<SuperheroModel> Superheroes { get; set; } = new()
        {
            new SuperheroModel {
                Id = 1,
                Name = "Wigwen",
                SecretIdentity = "Otto" ,
                Superpower = new List<string>()
                {
                    "Snabb",
                    "Träffsäker",
                } ,
                Image = $"superhero{new Random().Next(1, 21)}.jpg"
            },
            new SuperheroModel {
                Id = 2,
                Name = "CatRalf",
                SecretIdentity = "Gustav" ,
                Superpower = new List<string>()
                {
                    "Snygg",
                    "Stark",
                    "Snäll"
                } ,
                Image = $"superhero{new Random().Next(1, 21)}.jpg"
            }
        };

        public static List<string> Superpowers { get; set; } = new();

        public static string RandomImage()
        {
            return $"superhero{new Random().Next(1, 21)}.jpg";
        }
    }
}
