using Entitiess.Contexts;
using Entitiess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LenaProjeMustafa.Controllers
{
    public class LoginController : Controller
    {
        FormDBContext db = new FormDBContext();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login()
        {
            var userName = Request.Form["Name"];
            var password = Request.Form["pass"];
            List<Login> data = db.Login.Where(p => p.UserName == userName && p.Password == password).ToList();
            if (data.Count == 0)
            {
                
                return RedirectToAction("Index", "Login");
            }
            else
            {
                Session["User"] = data;
                return RedirectToAction("Index", "FormList");
            }
        }
    }
}