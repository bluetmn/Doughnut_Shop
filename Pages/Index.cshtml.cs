using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesDoughnuts.Services;
using RazorPagesDoughnuts.Models;

namespace RazorPagesDoughnuts.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    public JsonFileDoughnutService DoughnutService;
    public IEnumerable<Doughnut> Doughnuts { get; private set; } = null!;

    public IndexModel(ILogger<IndexModel> logger, JsonFileDoughnutService doughnutService)
    {
        _logger = logger;
        DoughnutService = doughnutService;
    }

    public void OnGet()
    {
        Doughnuts = DoughnutService.GetDoughnuts();
    }
}
