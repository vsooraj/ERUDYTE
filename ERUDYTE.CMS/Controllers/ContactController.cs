using Microsoft.AspNetCore.Mvc;

namespace Erudyte.CMS.Controllers
{
    [Route("Contact")]
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Contact Page";
            return View();
        }
    }
}