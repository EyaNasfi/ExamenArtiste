using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AM.UI.WEB.Controllers
{
    public class ChansonController : Controller
    {
        IChanson _ch;
        IArtise _ar;

        public ChansonController(IChanson ch, IArtise ar)
        {
            _ch = ch;
            _ar = ar;
        }

        // GET: ChansonController
        public ActionResult Index()
        {
            return View(_ch.GetAll().OrderBy(p=>p.VuesYoutubes).ToList());
        }

        // GET: ChansonController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ChansonController/Create
        public ActionResult Create()
        {
            ViewBag.Planes = new SelectList(_ar.GetAll().ToList(),
           "ArtisteId", "Nom", "Prenom");
            return View();
        }

        // POST: ChansonController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Chanson ch)
        {
            try
            {
                _ch.Add(ch);
                _ch.Commit();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ChansonController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ChansonController/Edit/5
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

        // GET: ChansonController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ChansonController/Delete/5
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
