using Erudyte.CMS.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Erudyte.CMS.Controllers
{

    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            var contactViewModel = new ContactViewModel();
            ViewBag.Title = "Feedback Page";
            contactViewModel.Title = "Feedback Page";
            return View(contactViewModel);
        }
    }
}