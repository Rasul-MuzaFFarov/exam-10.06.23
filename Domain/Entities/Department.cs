using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Department
{
    public int Id { get; set; }
    [MaxLength(25)]
    public string Name { get; set; }
    public int Manager { get; set; }
    public int LocationId { get; set; }
    public Location Location { get; set; }
    public List<Employees> Employees { get; set; }
    public List<JobHistory> JobHistories { get; set; }
}