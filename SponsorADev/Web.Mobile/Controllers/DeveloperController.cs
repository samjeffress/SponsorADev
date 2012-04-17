using System.Web.Mvc;
using Web.Mobile.Models;

namespace Web.Mobile.Controllers
{
    public class DeveloperController : Controller
    {
        public ActionResult MiniProfile(string name)
        {
            return PartialView("DeveloperMiniProfile", new SponsoredDeveloper { Bio = "blah", DeveloperName = name});
        }

    }
}
