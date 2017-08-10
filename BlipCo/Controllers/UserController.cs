using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlipCo.Models;

namespace BlipCo.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            // Create a new user object to hold the data to be displayed on the form
            // and assign a GUID for the user during initialization.
            var user = new User()
            {
                UserID = Guid.NewGuid().ToString()
            };

            return View(user);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index([Bind(Include = "UserID,Username")] User user, string answer)
        {
            if (ModelState.IsValid && !String.IsNullOrWhiteSpace(answer))
            {
                switch (answer)
                {
                    case "Accept":
                        user.Decided = DateTime.Now;
                        user.TermsStatus = "Accepted";
                        break;
                    case "Decline":
                        user.Decided = DateTime.Now;
                        user.TermsStatus = "Declined";
                        break;
                    case "Defer":
                        user.Reminder = DateTime.Now.AddDays(10);
                        user.TermsStatus = "Deferred";
                        break;
                    default:
                        user.Decided = DateTime.Now;
                        user.TermsStatus = "Deferred";
                        break;
                }
            }
            return View(user);
        }

        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: User/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: User/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: User/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
