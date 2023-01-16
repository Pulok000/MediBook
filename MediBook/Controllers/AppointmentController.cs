using Microsoft.AspNetCore.Mvc;

namespace MediBook.Controllers
{
    public class AppointmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
