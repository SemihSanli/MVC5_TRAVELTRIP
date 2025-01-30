using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TravelTripProject.Models.Siniflar;
using Context = TravelTripProject.Models.Siniflar.Context;
namespace TravelTripProject.Controllers
{
    public class GirisYapController : Controller
    {
        // GET: GirisYap
      Context c = new Context();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost] //veri gönderme işlemi oldugunda
        public ActionResult Login(Admin ad)
        {
            var bilgiler = c.Admins.FirstOrDefault
                (x => x.kullanici == ad.kullanici && x.Sifre == ad.Sifre);
            if (bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.kullanici, false);
                Session["Kullanici"]=bilgiler.kullanici.ToString(); 
                return RedirectToAction("Index","Admin");
            }
            else
            {
                return View();
            }
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "GirisYap");
        }
    }
}