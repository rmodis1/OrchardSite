using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace OrchardSite.Pages;

public class BlogPostModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public BlogPostModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {

    }
}