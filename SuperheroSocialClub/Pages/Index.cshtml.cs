using Microsoft.AspNetCore.Mvc;
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

        public IActionResult OnPostDeleteHero(int id)
        {
            SuperheroModel? superheroToDelete = SuperheroRepo.Superheroes.FirstOrDefault(s => s.Id == id);

            if (superheroToDelete != null)
            {
                SuperheroRepo.Superheroes.Remove(superheroToDelete);
            }

            Superheroes = SuperheroRepo.Superheroes;
            return Page();
        }
    }
}
