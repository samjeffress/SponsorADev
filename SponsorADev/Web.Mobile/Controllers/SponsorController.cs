using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Web.Mobile.Models;

namespace Web.Mobile.Controllers
{
    public class SponsorController : Controller
    {
        public IUserRepository UserRepository { get; set; }

        public ActionResult Index()
        {
            try
            {
                var sponsorshipOverview = new SponsorshipOverview();
                sponsorshipOverview.SponsoredDevelopers = new List<SponsoredDeveloper>
                {
                    new SponsoredDeveloper
                        {
                            Bio = "Lets get some bush telly my she'll be right cockie. He's got a massive compo no worries as dry as a butcher. Lets throw a boogie board no worries lets get some swag. Stands out like a nipper flamin lets get some dickhead. Lets throw a swagger how grab us a dole bludger. Lets get some bush telly my she'll be right cockie. He's got a massive compo no worries as dry as a butcher. Lets throw a boogie board no worries lets get some swag. Stands out like a nipper flamin lets get some dickhead. Lets throw a swagger how grab us a dole bludger. Lets get some bush telly my she'll be right cockie. He's got a massive compo no worries as dry as a butcher. Lets throw a boogie board no worries lets get some swag. Stands out like a nipper flamin lets get some dickhead. Lets throw a swagger how grab us a dole bludger. Lets get some bush telly my she'll be right cockie. He's got a massive compo no worries as dry as a butcher. Lets throw a boogie board no worries lets get some swag. Stands out like a nipper flamin lets get some dickhead. Lets throw a swagger how grab us a dole bludger.", 
                            DeveloperName = "toby toogood", 
                            ImageUrl = @Url.Content("~/Content/glyphicons/glyphicons_251_scuba_diving.png")
                        },
                    new SponsoredDeveloper
                        {
                            Bio = "She'll be right g'day no dramas as cross as a piker. You little ripper bogged how lets get some skite. Mad as a boil-over where she'll be right cobber. Trent from punchy rock up flamin you little ripper porky. Grab us a ciggies no worries shazza got us some bush telly. It'll be budgie smugglers piece of piss as cross as a gobful. As stands out like rapt flamin flat out like a rubbish. As busy as a cranky built like a tinny. Trent from punchy rock up when trent from punchy dunny rat. Lets get some fruit loop stands out like a ace!.", 
                            DeveloperName = "darren notsoawesome", 
                            ImageUrl = @Url.Content("~/Content/glyphicons/glyphicons_043_group.png")
                        },
                    new SponsoredDeveloper
                        {
                            Bio = "Shazza got us some tucker with it'll be bull bar. He's got a massive compo my lets throw a hooroo. Lets throw a too right! my as stands out like hit the turps. She'll be right garbo my she'll be right figjam. You little ripper pav bloody lets get some cane toad. As cross as a counter meal with we're going battler. Grab us a clacker when grab us a bored sh*tless. Stands out like a hottie gutful of show pony. She'll be right cream when as dry as a ocker.", 
                            DeveloperName = "forgot myname", 
                            ImageUrl = ""
                        }
                };
                foreach (var developer in sponsorshipOverview.SponsoredDevelopers)
                {
                    if (string.IsNullOrWhiteSpace(developer.ImageUrl))
                        developer.ImageUrl = @Url.Content("~/Content/glyphicons/glyphicons_002_dog.png");
                }
                sponsorshipOverview.SelectedDeveloper = sponsorshipOverview.SponsoredDevelopers.First();
                return View("SponsorshipOverview", sponsorshipOverview);
                if (UserRepository.IsCurrentSponsor(HttpContext.User.Identity.Name))
                {
                    return View("SponsorshipOverview");
                }
                else
                {
                    return View("SponsorshipOverview");
                    //return View("NoSponsorshipOverview");
                }
            }
            catch(Exception e)
            {
                return View("Error");
            }
        }

        public ActionResult DeveloperView(string developerName)
        {

            try
            {
                var sponsorshipOverview = new SponsorshipOverview();
                sponsorshipOverview.SponsoredDevelopers = new List<SponsoredDeveloper>
                {
                    new SponsoredDeveloper
                        {
                            Bio = "Lets get some bush telly my she'll be right cockie. He's got a massive compo no worries as dry as a butcher. Lets throw a boogie board no worries lets get some swag. Stands out like a nipper flamin lets get some dickhead. Lets throw a swagger how grab us a dole bludger. Lets get some bush telly my she'll be right cockie. He's got a massive compo no worries as dry as a butcher. Lets throw a boogie board no worries lets get some swag. Stands out like a nipper flamin lets get some dickhead. Lets throw a swagger how grab us a dole bludger. Lets get some bush telly my she'll be right cockie. He's got a massive compo no worries as dry as a butcher. Lets throw a boogie board no worries lets get some swag. Stands out like a nipper flamin lets get some dickhead. Lets throw a swagger how grab us a dole bludger. Lets get some bush telly my she'll be right cockie. He's got a massive compo no worries as dry as a butcher. Lets throw a boogie board no worries lets get some swag. Stands out like a nipper flamin lets get some dickhead. Lets throw a swagger how grab us a dole bludger.", 
                            DeveloperName = "toby toogood", 
                            ImageUrl = @Url.Content("~/Content/glyphicons/glyphicons_251_scuba_diving.png")
                        },
                    new SponsoredDeveloper
                        {
                            Bio = "She'll be right g'day no dramas as cross as a piker. You little ripper bogged how lets get some skite. Mad as a boil-over where she'll be right cobber. Trent from punchy rock up flamin you little ripper porky. Grab us a ciggies no worries shazza got us some bush telly. It'll be budgie smugglers piece of piss as cross as a gobful. As stands out like rapt flamin flat out like a rubbish. As busy as a cranky built like a tinny. Trent from punchy rock up when trent from punchy dunny rat. Lets get some fruit loop stands out like a ace!.", 
                            DeveloperName = "darren notsoawesome", 
                            ImageUrl = @Url.Content("~/Content/glyphicons/glyphicons_043_group.png")
                        },
                    new SponsoredDeveloper
                        {
                            Bio = "Shazza got us some tucker with it'll be bull bar. He's got a massive compo my lets throw a hooroo. Lets throw a too right! my as stands out like hit the turps. She'll be right garbo my she'll be right figjam. You little ripper pav bloody lets get some cane toad. As cross as a counter meal with we're going battler. Grab us a clacker when grab us a bored sh*tless. Stands out like a hottie gutful of show pony. She'll be right cream when as dry as a ocker.", 
                            DeveloperName = "forgot myname", 
                            ImageUrl = ""
                        }
                };

                foreach (var developer in sponsorshipOverview.SponsoredDevelopers)
                {
                    if (string.IsNullOrWhiteSpace(developer.ImageUrl))
                        developer.ImageUrl = @Url.Content("~/Content/glyphicons/glyphicons_002_dog.png");
                }
                sponsorshipOverview.SelectedDeveloper = sponsorshipOverview.SponsoredDevelopers.Where(s => s.DeveloperName == developerName).FirstOrDefault();
                return View("SponsorshipOverview", sponsorshipOverview);
                if (UserRepository.IsCurrentSponsor(HttpContext.User.Identity.Name))
                {
                    return View("SponsorshipOverview");
                }
                else
                {
                    return View("SponsorshipOverview");
                    //return View("NoSponsorshipOverview");
                }
            }
            catch (Exception e)
            {
                return View("Error");
            }
        }

    }
}
