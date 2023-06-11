using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Region
{
    public int Id { get; set; }
    [MaxLength(25)]
    public string RegionName { get; set; }

    public List<Country> Countries { get; set; }
}