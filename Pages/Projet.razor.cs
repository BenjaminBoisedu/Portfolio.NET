using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace aspnetcoreapp.Pages;

public class ProjetModel : PageModel
{
    private readonly ILogger<ProjetModel> _logger;


    public ProjetModel(ILogger<ProjetModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}