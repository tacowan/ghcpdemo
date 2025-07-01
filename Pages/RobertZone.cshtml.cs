using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages;

public class RobertZoneModel : PageModel
{
    private readonly ILogger<RobertZoneModel> _logger;

    public RobertZoneModel(ILogger<RobertZoneModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}