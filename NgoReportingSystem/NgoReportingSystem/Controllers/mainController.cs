using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NgoReportingSystem.Controllers
{
    public class mainController : Controller
    {
        //
        // GET: /main/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /main/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /main/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /main/Create

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

        //
        // GET: /main/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /main/Edit/5

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

        //
        // GET: /main/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /main/Delete/5

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
