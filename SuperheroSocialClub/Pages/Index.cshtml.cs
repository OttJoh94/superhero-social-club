using Microsoft.AspNetCore.Mvc.RazorPages;
using SuperheroSocialClub.Database;
using SuperheroSocialClub.Models;

namespace SuperheroSocialClub.Pages
{
    public class IndexModel : PageModel
    {
        public List<SuperheroModel>? Superheroes { get; set; }
        public void OnGet()
        {
            Superheroes = SuperheroRepo.Superheroes;
        }
    }
}
