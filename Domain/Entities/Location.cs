using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Location
{
    public int Id { get; set; }
    [MaxLength(25)]
    public string StreetAddress { get; set; }
    [MaxLength(25)]
    public string PostalCode { get; set; }
    [MaxLength(25)]
    public string City { get; set; }
    [MaxLength(25)]
    public string StateProvince { get; set; }
    public int CountryId { get; set; }
    public Country Country { get; set; }
    public List<Department> Departments { get; set; }
}