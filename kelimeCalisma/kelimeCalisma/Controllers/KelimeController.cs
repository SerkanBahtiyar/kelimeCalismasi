using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using kelimeCalisma.Models.Siniflar;
namespace kelimeCalisma.Controllers
{
    public class KelimeController : Controller
    {
        // GET: Kelime
        context sb=new context();
        public ActionResult Index()
        {
            var degerler = sb.bilgilers.ToList();
            return View(degerler);
        }
        [HttpGet]
       
        public ActionResult KelimeEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult KelimeEkle(bilgiler b)
        {
            sb.bilgilers.Add(b);
            sb.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult KelimeSil(int id)
        {
            var kl = sb.bilgilers.Find(id);
            sb.bilgilers.Remove(kl);
            sb.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}