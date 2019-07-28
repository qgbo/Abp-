using Microsoft.AspNetCore.Antiforgery;
using qgb48.Controllers;

namespace qgb48.Web.Host.Controllers
{
    public class AntiForgeryController : qgb48ControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
