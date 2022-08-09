using Microsoft.AspNetCore.Mvc;

namespace DefaultRouteApplication.Controllers {
    public class EmployeeController : Controller {
        public IActionResult EmployeeView() {
            return View();
        }
    }
}
