using Calender.DbContext;
using Calender.Modals;
using Microsoft.EntityFrameworkCore;

namespace Calender.Repository
{
    public class LeaveRepository : ILeaveRepository
    {
        private readonly AppDbContext _context;

        public LeaveRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Employee>> GetAllEmployeesAsync()
        {
            return await _context.Employees.ToListAsync();
        }

        public async Task<IEnumerable<Leave>> GetLeavesByEmployeeIdAsync(int employeeId)
        {
            return await _context.Leaves.Where(l => l.EmployeeId == employeeId).ToListAsync();
        }

    }
}
