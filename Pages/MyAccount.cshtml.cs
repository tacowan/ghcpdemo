using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages;

public class MyAccountModel : PageModel
{
    private readonly ILogger<MyAccountModel> _logger;

    public MyAccountModel(ILogger<MyAccountModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}