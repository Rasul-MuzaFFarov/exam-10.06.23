using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Country
{
    public int Id { get; set; }
    [MaxLength(25)]
    public string CountryName { get; set; }
    public int RegionId { get; set; }
    public Region Region { get; set; }
    public List<Location> Locations { get; set; }
}