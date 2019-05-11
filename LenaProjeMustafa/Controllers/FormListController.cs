using Entitiess.Contexts;
using Entitiess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LenaProjeMustafa.Controllers
{
    public class FormListController : Controller
    {
        FormDBContext db = new FormDBContext();
        // GET: FormList
        public ActionResult Index(string searchKey)
        {
            if (Session["User"] == null)
            {
                return RedirectToAction("Index", "Login");
            }
            else if (!string.IsNullOrEmpty(searchKey))
            {
                List<FormList> data = db.FormList.Where(p => p.FormName == searchKey).ToList();
                return View(data);
            }
            else
            {
                List<FormList> data = db.FormList.Select(p => p).ToList();
                return View(data);
            }

        }
        public ActionResult Details(int id)
        {
            if (Session["User"] == null)
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {
                List<FormList> data = db.FormList.Where(p=>p.FormId == id).ToList();
                return View(data);
            }
        }
        [HttpPost]
        public ActionResult Search()
        {
            var key = Request.Form["search"];
            return RedirectToAction("Index", "FormList", new { searchKey = key });
        }
        [HttpPost]
        public ActionResult Popup()
        {
            db.FormList.Add(new FormList
            {
                FormName = Request.Form["formName"],
                Description = Request.Form["formDescription"],
                CreatedAt = DateTime.Now,
                CreatedBy = 1,
                UserName = Request.Form["name"],
                UserSurname = Request.Form["surname"],
                UserAge = Convert.ToInt32(Request.Form["age"])
            });
            db.SaveChanges();

            return RedirectToAction("Index", "FormList");
        }
    }
}