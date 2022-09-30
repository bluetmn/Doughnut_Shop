using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesDoughnuts.data;
using RazorPagesDoughnuts.Models;

namespace RazorPagesDoughnuts.Pages.doughnuts;

public class CreateModel : PageModel{
    private readonly ApplicationDBContext _db;
    public CreateModel(ApplicationDBContext db)
    {
        _db = db;
    }

    [BindProperty]
    public Doughnut? Doughnut { get; set; }
    public void OnGet(){
        
    }

    public async Task<IActionResult> OnPost() {
        await _db.DoughnutDB!.AddAsync(Doughnut!);
        await _db.SaveChangesAsync();

        return RedirectToPage("Index");
    }
}