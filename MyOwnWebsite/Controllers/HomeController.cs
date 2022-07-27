using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using MyOwnWebsite.ViewModels;
using System.Linq;

namespace MyOwnWebsite.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork<Owner> _owner;
        private readonly IUnitOfWork<PortofolioItems> _portofolio;

        public HomeController(
            IUnitOfWork<Owner> owner,
             IUnitOfWork<PortofolioItems> portofolio
            )
        {
            _owner = owner;
            _portofolio = portofolio;
        }
        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                owner = _owner.repository.GetAll().First(),
                portofolioItems = _portofolio.repository.GetAll().ToList()
            };

            return View(homeViewModel);
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
