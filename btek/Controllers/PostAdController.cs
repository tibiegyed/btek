using btek.Models;
using btek.ViewModel;
using System;
using System.Web.Mvc;

namespace btek.Controllers
{
    public class PostAdController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PostAdController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: PostAd
        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        public ActionResult Create()
        {
            var viewModel = new AdPostViewModel();
            return View(viewModel);
        }


        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AdPostViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View("Create", viewModel);
            }
            var ad = new AdPostModel
            {
                ClientName = viewModel.ClientName,
                Address = viewModel.Address,
                Date = DateTime.Today,
                Description = viewModel.Description,
                Price = viewModel.Price,
                Email = viewModel.Email
            };

            _context.Ads.Add(ad);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}