using SuperheroSocialClub.Models;

namespace SuperheroSocialClub.Database
{
    public class SuperheroRepo
    {
        public static List<SuperheroModel> Superheroes { get; set; } = new()
        {
            new SuperheroModel {
                Id = 1,
                Name = "Otto",
                SecretIdentity = "Wigwen" ,
                Superpower = new List<string>()
                {
                    "Snabb",
                    "Träffsäker",
                } ,
                Image = $"superhero{new Random().Next(1, 21)}.jpg"
            },
            new SuperheroModel {
                Id = 2,
                Name = "Gustav",
                SecretIdentity = "CatRalf" ,
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
    }
}
