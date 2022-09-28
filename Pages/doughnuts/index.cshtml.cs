using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesDoughnuts.data;
using RazorPagesDoughnuts.Models;

namespace RazorPagesDoughnuts.Pages.doughnuts;

public class IndexModel : PageModel {

    private readonly ApplicationDBContext _db;

    public IEnumerable<Doughnut>? Doughnuts { get; set; }

    public IndexModel(ApplicationDBContext db)
    {
        _db = db;
    }
    public void OnGet() {
        Doughnuts = _db.DoughnutDB;
    }
}