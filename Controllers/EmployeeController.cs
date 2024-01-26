using backend.Repository;
using Microsoft.AspNetCore.Mvc;
using MySql.Model;
namespace backend.Controllers
{
    [ApiController]
    [Route("Employee")]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeRepository repository;
        public EmployeeController(EmployeeRepository repository) { this.repository = repository; }

        [HttpGet]
        public async Task<IEnumerable<Employee>> GetEmployeesAsync()
        {
            var employees = (await repository.GetEmployeesAsync())
                        .Select(emp => emp.EmployeeDto());
            return employees;
        }
    }
}