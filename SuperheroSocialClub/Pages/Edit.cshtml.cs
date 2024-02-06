using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SuperheroSocialClub.Database;
using SuperheroSocialClub.Models;

namespace SuperheroSocialClub.Pages
{
    [BindProperties]
    public class EditModel : PageModel
    {
        public SuperheroModel? Superhero { get; set; }
        public string? Image { get; set; }
        public string? Name { get; set; }
        public string? SecretIdentity { get; set; }
        public string? Superpower { get; set; }
        public void OnGet(int id)
        {
            Superhero = SuperheroRepo.Superheroes.FirstOrDefault(hero => hero.Id == id);

            Image = Superhero.Image;
            Name = Superhero.Name;
            SecretIdentity = Superhero.SecretIdentity;
            Superpower = Superhero.Superpower;
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            var superheroToUpdate = SuperheroRepo.Superheroes.FirstOrDefault(hero => hero.Id == Superhero.Id);


            superheroToUpdate.Name = Name;
            superheroToUpdate.SecretIdentity = SecretIdentity;
            superheroToUpdate.Superpower = Superpower;


            return RedirectToPage("/Index");
        }
    }
}
