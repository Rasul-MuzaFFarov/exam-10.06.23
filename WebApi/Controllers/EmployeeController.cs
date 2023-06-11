using Domain.Dtos;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

namespace MVCapp.Controllers;

public class EmployeeController : Controller
{
    private readonly IEmployeeService _employeeService;

    public EmployeeController(IEmployeeService employeeService)
    {
        _employeeService = employeeService;
    }
    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var result = await _employeeService.GetEmployee();
        return View(result);
    }
    [HttpGet]
    public IActionResult Create()
    {
        
        return View(new EmployeeDto());
    }
}