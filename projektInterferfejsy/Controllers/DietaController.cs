using Microsoft.AspNetCore.Mvc;
using projektInterferfejsy.Data;
namespace projektInterferfejsy.Controllers
{
    public class DietaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
