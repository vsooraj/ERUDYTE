using Erudyte.CMS.Data.Interfaces;
using Erudyte.CMS.ViewModels;
using Microsoft.AspNetCore.Mvc;


namespace Erudyte.CMS.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICategoryTypeRepository _categoryTypeRepository;

        public HomeController(ICategoryTypeRepository categoryTypeRepository)
        {
            _categoryTypeRepository = categoryTypeRepository;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.Title = "Erudyte Health’s";

            var homeViewModel = new HomeViewModel()
            {
                Title = "Erudyte Health’s"
            };
            return View(homeViewModel);
        }
    }
}
