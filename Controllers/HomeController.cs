using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using tut01.Data;
using tut01.Interfaces;
using tut01.Models;

namespace tut01.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class HomeController : Controller
    {
        private EmployeeRepository _employeeRepository;
        public HomeController(EmployeeRepository repository)
        {
            _employeeRepository = repository;
        }
        class Res {
            public string Name { get; set; }
        }

        [HttpGet("")]
        public async Task<IActionResult> Index()
        {
            var data = await _employeeRepository.FindAll();
            return Ok(data);
        }
    }
}