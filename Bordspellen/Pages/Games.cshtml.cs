using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Bordspellen.Pages
{
    public class GamesModel : PageModel
    {
        private readonly ILogger<GamesModel> _logger;

        public GamesModel(ILogger<GamesModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
        }
    }
}
