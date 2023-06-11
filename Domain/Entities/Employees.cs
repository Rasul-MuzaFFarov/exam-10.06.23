using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Employees
{
    [Key]
    public int Id { get; set; }
    [MaxLength(20)]
    public string FirstName { get; set; }
    [MaxLength(25)]
    public string LastName { get; set; }
    [MaxLength(25)]
    public string Email { get; set; }
    [MaxLength(25)]
    public string PhoneNumber { get; set; }
    public DateTime HireDate { get; set; }
    [MaxLength(25)]
    public int JobId { get; set; }
    public Job Job { get; set; }
    public int Salary { get; set; }
    public int ComissionPct { get; set; }
    public int Manager { get; set; }
    public int DepartmentId { get; set; }
    public Department Department { get; set; }
    
    
}