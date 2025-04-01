using Microsoft.AspNetCore.Mvc;

namespace AppCRUD.Controllers
{
    public class ProductosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
