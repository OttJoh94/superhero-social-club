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
                Superpower = "Thresh" ,
            },
            new SuperheroModel {
                Id = 2,
                Name = "Gustav",
                SecretIdentity = "CatRalf" ,
                Superpower = "Pantheon" ,
            }
        };
    }
}
