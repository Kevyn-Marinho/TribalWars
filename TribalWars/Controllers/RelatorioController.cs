using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TribalWars.Controllers
{
    public class RelatorioController : Controller
    {
        // GET: RelatorioController
        public ActionResult Index()
        {
            return View();
        }

        // GET: RelatorioController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RelatorioController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RelatorioController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RelatorioController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RelatorioController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RelatorioController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RelatorioController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
