using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using projektInterferfejsy.Data;
using System.Diagnostics;

namespace projektInterferfejsy.Controllers
{
    //public class PrzepisController : Controller
    //{
    //    private readonly ApplicationDbContext _context;

    //    public PrzepisController(ApplicationDbContext context, IRaceRepository raceRepository)
    //    {
    //        _context = context;
    //    }
    //    public IActionResult Index()
    //    {
    //        List<Przepis> przepisy = _context.Przepisy.ToList();
    //        return View(przepisy);
    //    }
    //    public IActionResult Detail(int id)
    //    {
    //        Przepis przepisy = _context.Przepisy.Include(a => a.Address).FirstOrDefault(c => c.Id == id);
    //        return View(przepis);
    //    }
}

