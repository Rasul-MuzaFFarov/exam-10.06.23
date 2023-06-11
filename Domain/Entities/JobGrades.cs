using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class JobGrades
{
    [MaxLength(25)]
    public string GradeLevel { get; set; }
    public int LowestSal { get; set; }
    public int HightestSal { get; set; }
}