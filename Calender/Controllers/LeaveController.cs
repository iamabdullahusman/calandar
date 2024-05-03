using Calender.Modals;
using Calender.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Calender.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeaveController : ControllerBase
    {
        private readonly ILeaveRepository _repository;

        public LeaveController(ILeaveRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("employees")]
        public async Task<ActionResult<IEnumerable<Employee>>> GetAllEmployees()
        {
            var employees = await _repository.GetAllEmployeesAsync();
            return Ok(employees);
        }

        [HttpGet("leaves/{employeeId}")]
        public async Task<ActionResult<IEnumerable<Leave>>> GetLeavesByEmployee(int employeeId)
        {
            var leaves = await _repository.GetLeavesByEmployeeIdAsync(employeeId);
            return Ok(leaves);
        }
    }
}
