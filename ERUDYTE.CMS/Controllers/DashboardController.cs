using Erudyte.CMS.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace Erudyte.CMS.Controllers
{
    public class DashboardController : Controller
    {
        private readonly ICategoryTypeRepository _categoryTypeRepository;

        public DashboardController(ICategoryTypeRepository categoryTypeRepository)
        {
            _categoryTypeRepository = categoryTypeRepository;
        }
        public IActionResult Index()
        {
            ViewBag.Title = "Dashboard Page";
            return View();
        }
    }
}
