using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesDoughnuts.Services;
using RazorPagesDoughnuts.Models;

namespace RazorPagesDoughnuts.Pages
{
    public class DoughnutModel : PageModel
    {
        [BindProperty]
        public Doughnut NewDoughnut { get; set; } = new();
        public List<Doughnut> doughnuts = new();
        public void OnGet()
        {
            doughnuts = DoughnutService.GetAll();
        }

        public string HasGlazeText(Doughnut doughnut) {
            return doughnut.HasGlaze ? "Glazed" : "Not Glazed";
        }

        public IActionResult OnPost() {
            if (!ModelState.IsValid) {
                return Page();
            }

            DoughnutService.Add(NewDoughnut);
            return RedirectToAction("Get");
        }

        public IActionResult OnPostDelete(int id) {
            DoughnutService.Delete(id);
            return RedirectToAction("Get");
        }
    }
}
