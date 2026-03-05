using Microsoft.AspNetCore.Mvc;

namespace EmployeePortalApp.Controllers
{
    public class EmployeePolicy : Controller
    {
        public IActionResult Rules()
        {
            return View();
        }
    }
}
