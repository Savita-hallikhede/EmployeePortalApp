using Microsoft.AspNetCore.Mvc;

namespace EmployeePortalApp.Controllers
{
    public class AccountController : Controller
    {

        //[Route("Hello")]
        public IActionResult Register()
        {
            return View();
        }
    }
}
