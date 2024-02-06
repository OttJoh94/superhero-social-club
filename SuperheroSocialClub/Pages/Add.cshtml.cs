using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SuperheroSocialClub.Database;
using SuperheroSocialClub.Models;

namespace SuperheroSocialClub.Pages
{
    [BindProperties]
    public class AddModel : PageModel
    {

        public string Name { get; set; }
        public string SecretIdentity { get; set; }
        public string Superpower { get; set; }
        public List<string> SuperpowersList { get; set; } = SuperheroRepo.Superpowers;
        public string Image { get; set; } = $"superhero{new Random().Next(1, 21)}.jpg";

        public void OnGet()
        {
            SuperheroRepo.Superpowers.Clear();
        }

        public IActionResult OnPostAddSuperhero()
        {
            //if (!ModelState.IsValid)
            //{
            //    return Page();
            //}

            List<string> superPowers = new(SuperheroRepo.Superpowers);

            SuperheroRepo.Superheroes.Add(new SuperheroModel
            {
                Id = SuperheroRepo.Superheroes.Count + 1,
                Name = Name,
                SecretIdentity = SecretIdentity,
                Superpower = superPowers,
                Image = Image
            });

            return RedirectToPage("/Index");
        }

        public void OnPostAddSuperpower()
        {
            SuperheroRepo.Superpowers.Add(Superpower);
            SuperpowersList = SuperheroRepo.Superpowers;

        }
    }
}

