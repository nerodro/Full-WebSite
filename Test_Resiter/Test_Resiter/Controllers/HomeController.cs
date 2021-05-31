using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Test_Resiter.Models;
using Test_Resiter.ViewModels;

namespace Test_Resiter.Controllers
{
    public class HomeController : Controller
    {
        ISend repo;
        public HomeController(ISend r)
        {
            repo = r;
        }
        readonly UserContext db;

        public HomeController(UserContext context)
        {
            db = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View(repo.sends());
        }
        [HttpPost]
        public ActionResult Index(SendForm form)
        {
            db.Entry(form).State = EntityState.Added;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Moder()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Moder(User form)
        {
            db.Entry(form).State = EntityState.Added;
            db.SaveChanges();
            return RedirectToAction("AdminPanel");
        }
        public ActionResult DeleteForm(int id)
        {
            SendForm s = new SendForm { Id = id };
            db.Entry(s).State = EntityState.Deleted;
            db.SaveChanges();
            return RedirectToAction("Admins");
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            SendForm del = db.Forms.Find(id);
            if (del == null)
            {
                return HttpNotFound();
            }
            return View(del);
        }

        private ActionResult HttpNotFound()
        {
            throw new NotImplementedException();
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            SendForm b = db.Forms.Find(id);
            if (b == null)
            {
                return HttpNotFound();
            }
            db.Forms.Remove(b);
            db.SaveChanges();
            return RedirectToAction("Admins");
        }
        [HttpGet]
        public ActionResult EditData(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            // Находим в бд студента
            SendForm form = db.Forms.Find(id);
            if (form != null)
            {
                // Создаем список данных которые можем изменить
                return View(form);
            }
            return RedirectToAction("Admins");
        }

        [HttpPost]
        public ActionResult EditData(SendForm form)
        {
            db.Entry(form).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Admins");
        }
        [Authorize]
        public IActionResult AdminPanel()
        {
            return View(db.Users.ToList());
        }
        [Authorize]
        public IActionResult Admins()
        {
            return View(db.Forms.ToList());
        }
        [HttpGet]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
