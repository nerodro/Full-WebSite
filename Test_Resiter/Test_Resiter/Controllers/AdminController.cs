using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_Resiter.Models;

namespace Test_Resiter.Controllers
{
    public class AdminController : Controller
    {
        IRepository repo;
        public AdminController(IRepository r)
        {
            repo = r;
        }
        readonly UserContext db;

        public AdminController(UserContext context)
        {
            db = context;
        }
        [HttpGet]
        public IActionResult AddModer()
        {
            return View(repo.AddUser());
        }
        [HttpPost]
        public ActionResult AddModer(Admin user)
        {
            db.Entry(user).State = EntityState.Added;
            db.SaveChanges();
            return RedirectToAction("AdminPanel", "Home");
        }
        public IActionResult DeleteAdmin(int id)
        {
            User s = new User { Id = id };
            db.Entry(s).State = EntityState.Deleted;
            db.SaveChanges();
            return RedirectToAction("AdminPanel", "Home");
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            User del = db.Users.Find(id);
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
            User User = db.Users.Find(id);
            if (User == null)
            {
                return HttpNotFound();
            }
            db.Users.Remove(User);
            db.SaveChanges();
            return RedirectToAction("AdminPanel", "Home");
        }
        [HttpGet]
        public ActionResult EditAdmin(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            // Находим в бд студента
            User form = db.Users.Find(id);
            if (form != null)
            {
                // Создаем список данных которые можем изменить
                return View(form);
            }
            return RedirectToAction("AdminPanel","Home");
        }

        [HttpPost]
        public ActionResult EditAdmin(User form)
        {
            db.Entry(form).State = EntityState.Modified;
            db.SaveChanges();
            repo.EditAdmin();
            return RedirectToAction("AdminPanel","Home");
        }
    }
}
