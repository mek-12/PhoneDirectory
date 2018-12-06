using Microsoft.AspNetCore.Mvc;
using PhoneDirectory.Bll.Abstract;
using PhoneDirectory.Bll.Concrete;

namespace PhoneDirectory.MVCWebUI.Controllers
{
    public class EmployeeController : Controller
    {
        private IEmployeeManager employeeManager= null;
        private FactoryOfManager manager = null; 
        public EmployeeController()
        {
            manager = new FactoryOfManager();
            employeeManager = manager.GetEmployeeManager();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}