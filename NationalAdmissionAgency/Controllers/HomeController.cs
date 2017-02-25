using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NationalAdmissionAgency.Controllers;
using NationalAdmissionAgency.Data;
using NationalAdmissionAgency.Models;
using NationalAdmissionAgency.Service;
using NationalAdmissionAgency.Service.IService;
using NationalAdmissionAgency.Service.Service;

namespace NationalAdmissionAgency.Controllers
{
    public class HomeController : Controller
    {
        private NAAEntities _NAA_Entities;
        public HomeController()
        {
            _NAA_Entities = new NAAEntities();
        }
        // GET: Home
        public ActionResult Index()
        {
            IList<NAA_Profile> _applicants =
                _NAA_Entities.NAA_Profile.ToList();
            return View(_applicants);
        }
        // GET: Home
        

        // GET: Home/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
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

        // GET: Home/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Home/Edit/5
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

        // GET: Home/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Home/Delete/5
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
