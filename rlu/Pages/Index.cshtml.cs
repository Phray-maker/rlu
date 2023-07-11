using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace rlu.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            var coll = Request.Headers;
            if (Request.Headers.ContainsKey("remote_user")) 
            {
                var uname = Request.Headers["remote_user"];
                ViewData.Add("uname", uname);
                
            }
            if (Request.Headers.ContainsKey("host"))
            {
                var uhost = Request.Headers["host"];
                ViewData.Add("uhost", uhost);

            }
        }
    }
}