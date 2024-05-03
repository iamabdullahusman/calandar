using Calender.Modals;

namespace Calender.Repository
{
    public interface ILeaveRepository
    {
        Task<IEnumerable<Employee>> GetAllEmployeesAsync();
        Task<IEnumerable<Leave>> GetLeavesByEmployeeIdAsync(int employeeId);
    }
}
