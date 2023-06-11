using Domain.Dtos;

namespace Infrastructure.Services;

public class IEmployeeService
{
    Task<List<EmployeeDto>> GetEmployee();
    Task<EmployeeDto> GetEmployeeById(int id);
    Task<EmployeeDto> AddEmployee(EmployeeDto model);
    Task<EmployeeDto> UpdateEmployee(EmployeeDto model);
    Task<bool> Delete(int id);
}