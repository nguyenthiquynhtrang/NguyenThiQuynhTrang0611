using NguyenThiQuynhTrang0611.Data;
using NguyenThiQuynhTrang0611.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace NguyenThiQuynhTrang0611.Controllers
{
    public class CompanyNTQT0611Controller : Controller
    {
        //khai bao DBcontext de lam viec voi Database
        private readonly NTQTDb _context;
        public CompanyNTQT0611Controller (NTQTDb context)
        {
            _context = context;
        }
           public async Task<IActionResult> Index()
        {
            var model = await _context.CompanyNTQT0611s.ToListAsync();
            return View(model);
        }
        public IActionResult Create()
        {
            return View();
        }
        //Action xu ly du lieu gui len tu view va luu vao Database
        [HttpPost]
        public async Task<IActionResult> Create(CompanyNTQT0611 cpn)
        {
            if(ModelState.IsValid)
            {
                _context.Add(cpn);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));

            }
            return View(cpn);
        }
        
     public async Task<IActionResult> Edit(string id)
     {
        if(id == null)
        {
            return View("NotFound");
        }
        var company = await _context.CompanyNTQT0611s.FindAsync(id);
        if (company == null)
        {
            return View("NotFound");
        }
        return View(company);
     }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(string id, [Bind("CompanyID,CompanyName")] CompanyNTQT0611 cpn)
    {
        if (id !=cpn.CompanyID)
        {
            return View("NotFound");
        }
        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(cpn);
                await _context.SaveChangesAsync();
            }
        catch (DbUpdateConcurrencyException)
        {
            if (!CompanyNTQT0611Exists(cpn.CompanyID))
            {
                return View("NotFound");
            }
            else
            {
                throw;
            }
        }
        return RedirectToAction(nameof(Index));
        }
        return View(cpn);
    }
         private bool CompanyNTQT0611Exists(string id)
    {
        return _context.CompanyNTQT0611s.Any(e => e.CompanyID== id);
    }
    }
}
    