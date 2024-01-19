using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RecordsManagement.Models;

namespace RecordsManagement.Controllers
{
    public class RecordController : Controller
    {
        private RecordContext _context { get; set; }

        public RecordController(RecordContext ctx)
        {
            _context = ctx;
        }

        [HttpGet]
        public IActionResult Alter()
        {
            ViewBag.Action = "Add";
            ViewBag.Categories = _context.Categories.ToList();
            ViewBag.Warehouses = _context.Warehouses.ToList();

            return View();
        }

        [HttpGet]
        public IActionResult AlterWithId(int id)
        {
            ViewBag.Action = "Update";
            ViewBag.Categories = _context.Categories.ToList();
            ViewBag.Warehouses = _context.Warehouses.ToList();
            var record = _context.Records.Find(id);
            if (HttpContext.Session.GetString("InitialCode") == null)
            {
                var initialCode = record.Code;
                HttpContext.Session.SetString("InitialCode", JsonConvert.SerializeObject(initialCode));
            }

            return View("Alter",record);
        }

        [HttpPost]
        public IActionResult Alter(Record record)
        {
            if (record.RecordId == 0)
            {
                var code = _context.Records.Select(c => c.Code).Distinct().ToList();
                if (code.Contains(record.Code))
                {
                    ModelState.AddModelError(nameof(record.Code), "Code already in database. Should be Unique");
                    ViewBag.Categories = _context.Categories.ToList();
                    ViewBag.Warehouses = _context.Warehouses.ToList();
                    ViewBag.Action = "Add";
                    return View(record);
                }
                _context.Records.Add(record);
            }
            else
            {
                var previousCode = JsonConvert.DeserializeObject<string>(HttpContext.Session.GetString("InitialCode"));
                var code = _context.Records.Select(c => c.Code).Distinct().ToList();
                code.Remove(previousCode);
                if (code.Contains(record.Code))
                {
                    ModelState.AddModelError(nameof(record.Code), "Code already in database. Should be Unique");
                    ViewBag.Categories = _context.Categories.ToList();
                    ViewBag.Warehouses = _context.Warehouses.ToList();
                    ViewBag.Action = "Update";
                    return View(record);
                }
                _context.Records.Update(record);
            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var record = _context.Records.Find(id);
            _context.Records.Remove(record);
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Cancel()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}