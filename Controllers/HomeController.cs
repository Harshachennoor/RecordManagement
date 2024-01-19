using System.Diagnostics;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RecordsManagement.Models;

namespace RecordsManagement.Controllers;

public class HomeController : Controller
{
    private RecordContext _context;

    public HomeController(RecordContext ctx)
    {
        _context = ctx;
    }

    public IActionResult Index(string id)
    {
        var filters = new Filters(id);
        ViewBag.Filters = filters;
        ViewBag.Categories = _context.Categories.ToList();
        ViewBag.Warehouses = _context.Warehouses.ToList();

        IQueryable<Record> query = _context.Records.Include(c => c.Category).Include(w => w.Warehouse);

        if (filters.HasCategory)
        {
            query = query.Where(r => r.CategoryId == filters.CategoryId);
        }
        if (filters.HasWarehouse)
        {
            query = query.Where(r => r.WarehouseId == filters.WarehouseId);
        }

        return View(query);
    }

    [HttpPost]
    public IActionResult Filter(string[] filter)
    {
        string id = string.Join('-', filter);
        return RedirectToAction("Index", new { ID = id });
    }


}
