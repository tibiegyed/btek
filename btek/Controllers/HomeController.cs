using btek.Models;
using GoogleMaps.LocationServices;
using System.Collections.Generic;
using System.Device.Location;
using System.Linq;
using System.Web.Mvc;

namespace btek.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;

        public HomeController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult Index()
        {
            var allAds = _context.Ads
                .Where(g => g.Price <= 10000);

            var User = System.Web.HttpContext.Current.User;
            //var userFromDb = _context.Users.Where(u => u.UserName == User.Identity.Name).Select(u => u.Address);
            var userFromDb = _context.Users.Where(u => u.UserName == User.Identity.Name);
            var userAddress = userFromDb.Select(u => u.Address);
            var isContractor = userFromDb.Select(u => u.IsContractor);
            var isContractorBool = isContractor.First();
            if (isContractorBool == true)
            {
                string actualAddress = userAddress.First();


                var locationService = new GoogleLocationService();
                var point = locationService.GetLatLongFromAddress(actualAddress);
                var latitude = point.Latitude;
                var longitude = point.Longitude;

                List<AdPostModel> myAds = new List<AdPostModel>();

                foreach (AdPostModel ad in allAds)
                {
                    if (ad.Address == "101 Dufferin Ave London ON")
                    {
                        var secondAddress = ad.Address;
                        var point2 = locationService.GetLatLongFromAddress(secondAddress);
                        var latitude2 = point2.Latitude;
                        var longitude2 = point2.Longitude;

                        var sCoord = new GeoCoordinate(latitude, longitude);
                        var eCoord = new GeoCoordinate(latitude2, longitude2);

                        var distance = sCoord.GetDistanceTo(eCoord) / 1000;
                        if (distance <= 10)
                        {
                            myAds.Add(ad);
                        }
                    }
                }
                return View(myAds);
            }
            else
            {
                return View(allAds);
            }
           
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

    }
}