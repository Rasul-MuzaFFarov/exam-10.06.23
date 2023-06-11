using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Job
{
    [MaxLength(25)]
    public int Id { get; set; }
    [MaxLength(25)]
    public string JobTittle { get; set; }
    public int MinSalary { get; set; }
    public int MaxSalary { get; set; }
}