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

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            SuperheroRepo.Superheroes.Add(new SuperheroModel
            {
                Id = SuperheroRepo.Superheroes.Count + 1,
                Name = Name,
                SecretIdentity = SecretIdentity,
                Superpower = Superpower,
                Image = $"superhero{new Random().Next(1, 21)}.jpg"
            });

            return RedirectToPage("/Index");
        }
    }
}

