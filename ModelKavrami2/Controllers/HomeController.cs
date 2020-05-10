using ModelKavrami2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ModelKavrami2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string isim = "Negan";
            char[] karakterler = isim.ToCharArray();
            // Bir sayfanın sadece 1 modeli olabilir.
            return View(karakterler);
        }

        // Kategorileri listeleyen bir action ve bunları görüntüleyen bir sayfa açınız.
        public ActionResult KategorileriListele()
        {
            NorthwndEntities db = new NorthwndEntities();
            List<Category> katList = db.Categories.ToList();
            return View(katList);
        }

        public ActionResult KategorininUrunleri(int KatID)
        {
            NorthwndEntities db = new NorthwndEntities();
            List<Product> urunlerim = db.Products.Where(x => x.CategoryID == KatID).ToList();
            return View(urunlerim);
        }
    }
}