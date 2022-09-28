using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesDoughnuts.Services;
using RazorPagesDoughnuts.Models;

namespace RazorPagesDoughnuts.Pages;

public class DoughnutPageModel : PageModel
{
    private readonly ILogger<DoughnutPageModel> _logger;
    public JsonFileDoughnutService DoughnutService;
    public IEnumerable<Doughnut> Doughnuts { get; private set; } = null!;

    public DoughnutPageModel(ILogger<DoughnutPageModel> logger, JsonFileDoughnutService doughnutService)
    {
        _logger = logger;
        DoughnutService = doughnutService;
    }

    public void OnGet()
    {
        Doughnuts = DoughnutService.GetDoughnuts();
    }
}
